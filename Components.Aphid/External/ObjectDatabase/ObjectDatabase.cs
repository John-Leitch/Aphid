using Components.External;
using Components.IO;
using Components.ObjectDatabase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace Components.ObjectDatabase
{
    public class ObjectDatabase<TElement> : ObjectDatabaseBase<TElement>
    {
        public const string DatabaseFileExtension = "odb",
            DatabaseMemoryFileExtension = "odm",
            IndexFileExtension = "odi",
            TypeIndexExtension = "odt";

        public int PageSize { get; set; } = 0x20;

        private string _memoryManagerLockKey;

        private Stream _stream, _memoryManagerStream;

        private MemoryMappedFile _memoryManagerVersionFile;

        private BinaryReader _memoryManagerVersionReader;

        private BinaryWriter _memoryManagerVersionWriter;

        private int _memoryManagerVersion;

        private readonly Action<Stream, TElement> _serialize;

        private readonly Func<Stream, TElement> _deserialize;

        private MemoryManager _memoryManager, _lastSafeMemoryManager;

        private bool _isCommitted = false, _isDisposed = false;

        private Table<long, ObjectDatabaseRecord<TElement>> _items = new Table<long, ObjectDatabaseRecord<TElement>>();

        public bool UseUnsafeMemoryManager { get; private set; }

        public bool IsReadOnly { get; set; }

        public string MemoryManagerFilename { get; private set; }

        public bool TrackEntities { get; set; }

        public bool SetEntityMetaData { get; set; }

        public ObjectDatabase(
            string filename,
            Action<Stream, TElement> serialize,
            Func<Stream, TElement> deserialize,
            bool useUnsafeMemoryManager = false)
            : base(Path.GetFullPath(filename))
        {
            _serialize = serialize;
            _deserialize = deserialize;
            UseUnsafeMemoryManager = useUnsafeMemoryManager;
            TrackEntities = false;
            SetEntityMetaData = false;
        }

        protected override void OpenCore()
        {
            _stream = new FileStream(
                Filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite,
                0x1000,
                FileOptions.WriteThrough);

            OpenMemoryManager();
        }

        private void OpenMemoryManager()
        {
            MemoryManagerFilename = GetMemoryManagerFilename();
            _memoryManagerLockKey = MemoryManagerFilename.ToLower();
            
            _memoryManagerVersionFile = MemoryMappedFile.CreateOrOpen(
                _memoryManagerLockKey.Replace('\\', '$'),
                0x4,
                MemoryMappedFileAccess.ReadWrite,
                MemoryMappedFileOptions.None,
                HandleInheritability.None);

            var s =_memoryManagerVersionFile.CreateViewStream();
            _memoryManagerVersionReader = new BinaryReader(s);
            _memoryManagerVersionWriter = new BinaryWriter(s);

            LockMemoryManager(() =>
            {
                var hasMMFile = File.Exists(MemoryManagerFilename);

                _memoryManagerStream = CreateMemoryManagerStream();

                if (!hasMMFile)
                {
                    var m = new MemoryManager(_stream, PageSize);
                    WriteMemoryManagerUnsafe(m);
                }

                if (UseUnsafeMemoryManager)
                {
                    _memoryManager = ReadMemoryManagerUnsafe();
                }
                else
                {
                    _memoryManagerVersion = ReadVersion();
                    _lastSafeMemoryManager = ReadMemoryManagerUnsafe();
                }
            });
        }

        private int ReadVersion()
        {
            _memoryManagerVersionReader.BaseStream.Position = 0;
            return _memoryManagerVersionReader.ReadInt32();
        }

        private FileStream CreateMemoryManagerStream() =>
            new FileStream(
                MemoryManagerFilename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite,
                0x1000,
                FileOptions.WriteThrough);

        public MemoryManager ReadMemoryManagerUnsafe()
        {
            _memoryManagerStream.Position = 0;

            return MemoryManagerSerializer.Deserialize(_memoryManagerStream, _stream);
        }

        public void WriteMemoryManagerUnsafe(MemoryManager memoryManager)
        {
            AssertReadOnly("write memory manager");
            _memoryManagerStream.Position = 0;
            MemoryManagerSerializer.Serialize(_memoryManagerStream, memoryManager);
            _memoryManagerStream.Flush();
        }

        public void LockMemoryManager(Action action) =>
            // Technically, the ToLower call here creates a bug that will 
            // manifest when a case sensitive file system is used.
            Sync(_memoryManagerLockKey, action);

        public MemoryManager LockMemoryManager(Func<MemoryManager> func) =>
            Sync(_memoryManagerLockKey, func);

        private string GetMemoryManagerFilename() =>
            PathHelper.GetSiblingFileName(
                Filename,
                string.Format(
                    "{0}.{1}",
                    Path.GetFileNameWithoutExtension(Filename),
                    DatabaseMemoryFileExtension));

        public override void Create(TElement element)
        {
            AssertReadOnly();

            byte[] buffer;

            using (var s = new MemoryStream())
            {
                _serialize(s, element);
                buffer = s.ToArray();
            }

            var alloc = default(Allocation);
            long offset = -1;

            LockMemoryManager(() =>
            {
                if (!UseUnsafeMemoryManager)
                {
                    var mm = ReadVersionedMemoryManagerUnsafe(out var version);
                    alloc = mm.Allocate(buffer.Length);
                    WriteMemoryManagerUnsafe(mm);
                    offset = mm.GetPosition(alloc);
                    IncrementVersion(version);
                }
                else
                {
                    alloc = _memoryManager.Allocate(buffer.Length);
                    offset = _memoryManager.GetPosition(alloc);
                }
            });

            alloc.Write(buffer);

            if (TrackEntities)
            {
                lock (_items)
                {
                    _items[offset] = new ObjectDatabaseRecord<TElement>(element, offset, this);
                }
            }
        }

        private void IncrementVersion(int version)
        {
            _memoryManagerVersionWriter.BaseStream.Position = 0;
            _memoryManagerVersionWriter.Write(_memoryManagerVersion = ++version);
        }

        private MemoryManager ReadVersionedMemoryManagerUnsafe(out int version)
        {
            if ((version = ReadVersion()) != _memoryManagerVersion)
            {
                _memoryManagerVersion = version;
                return _lastSafeMemoryManager = ReadMemoryManagerUnsafe();
            }
            else
            {
                return _lastSafeMemoryManager;
            }
        }

        private MemoryManager ReadVersionedMemoryManagerUnsafe() => ReadVersionedMemoryManagerUnsafe(out var version);

        public override TElement ReadUnsafe(long offset)
        {
            _stream.Position = offset;

            var element = _deserialize(_stream);

            IObjectDatabaseEntity entity;

            if (SetEntityMetaData && (entity = element as IObjectDatabaseEntity) != null)
            {
                entity.Offset = offset;
                entity.Filename = Filename;
                entity.Context = this;
            }

            if (TrackEntities)
            {
                lock (_items)
                {
                    _items[offset] = new ObjectDatabaseRecord<TElement>(element, offset, this);
                }
            }

            return element;
        }

        public override IEnumerable<TElement> ReadUnsafe()
        {
            var mm = !UseUnsafeMemoryManager ? ReadVersionedMemoryManagerUnsafe() : _memoryManager;

            foreach (var a in mm.Allocations)
            {
                yield return ReadUnsafe((long)a.Key * mm.PageSize);

                //TElement element = default(TElement);
                //var success = false;

                //try
                //{
                //    element = ReadUnsafe((long)a.Key * mm.PageSize);
                //    success = true;
                //}
                //catch (Exception e)
                //{
                //    Debug.WriteLine("Error deserializing object: {0}", e.Message);
                //}

                //if (success)
                //{
                //    yield return element;
                //}
            }
        }

        public IEnumerable<TElement> SkipUnsafe(int count)
        {
            var mm = !UseUnsafeMemoryManager ? ReadVersionedMemoryManagerUnsafe() : _memoryManager;

            foreach (var a in mm.Allocations.Skip(count))
            {
                yield return ReadUnsafe((long)a.Key * mm.PageSize);
            }
        }

        public override void Update(TElement element)
        {
            if (!TrackEntities)
            {
                throw new InvalidOperationException("Cannot update when TrackEntities is false.");
            }

            AssertReadOnly("updated record");
            KeyValuePair<long, ObjectDatabaseRecord<TElement>> ctxItem;

            lock (_items)
            {
                ctxItem = _items.GetDictionary().FirstOrDefault(x => x.Value.Value.Equals(element));

                if (ctxItem.Value == null)
                {
                    throw new InvalidOperationException();
                }
            }

            byte[] buffer;

            using (var s = new MemoryStream())
            {
                _serialize(s, ctxItem.Value.Value);
                s.Position = 0;
                buffer = s.GetBuffer();
            }

            LockMemoryManager(() =>
            {
                if (!UseUnsafeMemoryManager)
                {
                    var mm = ReadVersionedMemoryManagerUnsafe(out var version);
                    var offset = Update(mm, ctxItem.Key, buffer);

                    if (offset != -1)
                    {
                        WriteMemoryManagerUnsafe(mm);

                        lock (_items)
                        {
                            _items.GetDictionary().Remove(ctxItem.Key);
                            _items[offset] = ctxItem.Value;
                        }

                        IncrementVersion(version);
                    }
                }
                else
                {
                    Update(_memoryManager, ctxItem.Key, buffer);
                }
            });
        }

        // Todo: add option to zero memory to avoid info disclosure
        private long Update(MemoryManager memoryManager, long offset, byte[] buffer)
        {
            var size = memoryManager.GetSizeFromOffset(offset);

            if (buffer.Length <= size)
            {
                _stream.Position = offset;
                _stream.Write(buffer);

                return -1;
            }
            else
            {
                memoryManager.FreeOffset(offset);
                var allocation = memoryManager.Allocate(buffer.Length);
                allocation.Write(buffer);

                return allocation.Handle * PageSize;
            }
        }

        public override int Count()
        {
            int count = 0;

            LockMemoryManager(() =>
            {
                if (!UseUnsafeMemoryManager)
                {
                    count = MemoryManagerSerializer.DeserializeCount(_memoryManagerStream);
                    //count = ReadVersion() != _memoryManagerVersion ? 
                    //    MemoryManagerSerializer.DeserializeCount(_memoryManagerStream) :
                    //    _lastSafeMemoryManager.Allocations.Count;
                }
                else
                {
                    count = _memoryManager.Allocations.Count;
                }
            });

            return count;
        }

        public override Dictionary<TIndex, List<int>> Index<TIndex>(Func<TElement, TIndex> selector)
        {
            var indexTable = new Dictionary<TIndex, List<int>>();
            var mm = !UseUnsafeMemoryManager ? ReadVersionedMemoryManagerUnsafe() : _memoryManager;

            foreach (var a in mm.Allocations)
            {
                _stream.Position = a.Key * mm.PageSize;
                var key = selector(_deserialize(_stream));

                if (indexTable.TryGetValue(key, out var value))
                {
                    value.Add(a.Key);
                }
                else
                {
                    indexTable.Add(key, new List<int> { a.Key });
                }
            }

            return indexTable;
        }

        public override void Dispose()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException("ObjectDatabase");
            }

            if (!_isCommitted && !IsReadOnly)
            {
                CommitMemoryManager();
            }

            _stream.Dispose();
            _memoryManagerStream.Dispose();
            _memoryManagerStream = null;
            _isDisposed = true;
            base.Dispose();
        }

        public void CommitMemoryManager()
        {
            AssertReadOnly("commit memory manager");
            _isCommitted = true;

            if (UseUnsafeMemoryManager)
            {
                LockMemoryManager(() =>
                {
                    // Inlined because the memory _memoryManagerStream may be
                    // closed at this point.
                    if (_memoryManagerStream == null)
                    {
                        using (var s = CreateMemoryManagerStream())
                        {
                            MemoryManagerSerializer.Serialize(s, _memoryManager);
                        }
                    }
                    else if (_memoryManagerStream.CanWrite)
                    {
                        _memoryManagerStream.Position = 0;
                        MemoryManagerSerializer.Serialize(_memoryManagerStream, _memoryManager);
                    }
                });
            }
        }

        ~ObjectDatabase()
        {
            if (UseUnsafeMemoryManager && !_isDisposed && !_isCommitted && !IsReadOnly)
            {
                CommitMemoryManager();
            }
        }

        private void AssertReadOnly(string name = null)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException(
                    $"Cannot {name ?? "create record"} in read-only mode.");
            }
        }
    }

    public static class ObjectDatabase
    {
        public static ObjectDatabase<string> OpenStringDatabase(
            string filename,
            bool useUnsafeMemoryManager = false) =>
            new ObjectDatabase<string>(
                filename,
                (x, s) =>
                {
                    x.Write(BitConverter.GetBytes(s.Length));
                    x.Write(s.GetBytes());
                },
                (x) => x.Read(BitConverter.ToInt32(x.Read(4), 0)).GetString(),
                useUnsafeMemoryManager)
                .Do(x => x.Open());
    }
}