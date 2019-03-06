#if CHECKED
#define ODB_NULL_CHECKS
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using Components.External;
using Components.IO;

namespace Components.ObjectDatabase
{
    public class ObjectDatabase<TElement> : ObjectDatabaseBase<TElement>
    {
        public const string DatabaseFileExtension = "odb",
            DatabaseMemoryFileExtension = "odm",
            IndexFileExtension = "odi",
            TypeIndexExtension = "odt";

        private string _memoryManagerLockKey;

        private Stream _stream, _memoryManagerStream;

        private MemoryMappedFile _memoryManagerVersionFile;

        private BinaryReader _memoryManagerVersionReader;

        private BinaryWriter _memoryManagerVersionWriter;

        private int _memoryManagerVersion;

        private readonly Action<Stream, TElement> _serialize;

        private readonly Func<Stream, TElement> _deserialize;

        private MemoryManager _memoryManager, _lastSafeMemoryManager;

        private bool _isCommitted;

        private readonly Dictionary<long, ObjectDatabaseRecord<TElement>> _entityOffsetTable = new Dictionary<long, ObjectDatabaseRecord<TElement>>();

        private readonly Dictionary<TElement, ObjectDatabaseRecord<TElement>> _recordTable = new Dictionary<TElement, ObjectDatabaseRecord<TElement>>(new ReferenceEqualityComparer<TElement>());

        public bool UseUnsafeMemoryManager { get; }

        public bool IsReadOnly { get; set; }

        public string MemoryManagerFilename { get; private set; }

        public bool TrackEntities { get; set; }

        public bool SetEntityMetaData { get; set; }

        public bool IsDisposed { get; set; }

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

            var s = _memoryManagerVersionFile.CreateViewStream();
            _memoryManagerVersionReader = new BinaryReader(s);
            _memoryManagerVersionWriter = new BinaryWriter(s);

            LockMemoryManager(() =>
            {
                var hasMMFile = File.Exists(MemoryManagerFilename);

                _memoryManagerStream = CreateMemoryManagerStream();

                if (!hasMMFile)
                {
                    var m = new MemoryManager(_stream);
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

#if ODB_NULL_CHECKS
            if (element == null)
            {
                throw new NullReferenceException("Create serializing null value.");
            }
#endif

            byte[] buffer;
            int bufferLength;

            using (var s = new MemoryStream())
            {
                _serialize(s, element);
                buffer = s.ToArray();

                if (s.Length > int.MaxValue)
                {
                    throw new InvalidOperationException(
                        string.Format("Entity cannot be more than {0:n0} bytes", int.MaxValue));
                }

                bufferLength = (int)s.Length;
            }

            var alloc = default(Allocation);
            long offset = -1;

            LockMemoryManager(() =>
            {
                if (!UseUnsafeMemoryManager)
                {
                    var mm = ReadVersionedMemoryManagerUnsafe(out var version);
                    alloc = mm.Allocate(bufferLength);
                    WriteMemoryManagerUnsafe(mm);
                    offset = mm.GetPosition(alloc);
                    IncrementVersion(version);
                }
                else
                {
                    alloc = _memoryManager.Allocate(bufferLength);
                    offset = _memoryManager.GetPosition(alloc);
                }
            });

            alloc.Write(buffer, bufferLength);

            if (TrackEntities)
            {
                lock (_recordTable)
                {
                    _recordTable.Add(element, new ObjectDatabaseRecord<TElement>(element, offset, this));
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

            return _lastSafeMemoryManager;
        }

        private MemoryManager ReadVersionedMemoryManagerUnsafe() =>
            ReadVersionedMemoryManagerUnsafe(out var version);

        public override TElement ReadUnsafe(long offset)
        {
            _stream.Position = offset;

            var element = _deserialize(_stream);

#if ODB_NULL_CHECKS
            if (element == null)
            {
                throw new NullReferenceException("ReadUnsafe deserialized null value.");
            }
#endif

            IObjectDatabaseEntity entity;

            if (SetEntityMetaData && (entity = element as IObjectDatabaseEntity) != null)
            {
                entity.Offset = offset;
                entity.Filename = Filename;
                entity.Context = this;
            }

            if (TrackEntities)
            {
                lock (_recordTable)
                {
                    var record = new ObjectDatabaseRecord<TElement>(element, offset, this);

                    if (!_recordTable.ContainsKey(element))
                    {
                        _recordTable.Add(element, record);
                    }
                    else
                    {
                        _recordTable[element] = record;
                    }
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

        public IEnumerable<Lazy<TElement>> LazyReadUnsafe()
        {
            var mm = !UseUnsafeMemoryManager ? ReadVersionedMemoryManagerUnsafe() : _memoryManager;

            foreach (var a in mm.Allocations)
            {
                yield return new Lazy<TElement>(() =>
                    ReadUnsafe((long)a.Key * mm.PageSize));
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

        public IEnumerable<Lazy<TElement>> LazySkipUnsafe(int count)
        {
            var mm = !UseUnsafeMemoryManager ? ReadVersionedMemoryManagerUnsafe() : _memoryManager;

            foreach (var a in mm.Allocations.Skip(count))
            {
                yield return new Lazy<TElement>(() =>
                    ReadUnsafe((long)a.Key * mm.PageSize));
            }
        }

        public override void Update(TElement element)
        {
            if (!TrackEntities)
            {
                throw new InvalidOperationException("Cannot update when TrackEntities is false.");
            }

#if ODB_NULL_CHECKS
            if (element == null)
            {
                throw new NullReferenceException("Updated attempted to serialize null element.");
            }
#endif

            AssertReadOnly("updated record");
            ObjectDatabaseRecord<TElement> record;

            lock (_recordTable)
            {
                if (!_recordTable.TryGetValue(element, out record))
                {
                    throw new InvalidOperationException("Could not find entity in tracking table.");
                }

#if ODB_NULL_CHECKS
                if (record.Entity == null)
                {
                    throw new NullReferenceException("Null value found in entity tracking table.");
                }
#endif
            }

            byte[] buffer;
            int bufferLength;

            using (var s = new MemoryStream())
            {
                _serialize(s, record.Entity);
                s.Position = 0;
                buffer = s.GetBuffer();

                if (s.Length > int.MaxValue)
                {
                    throw new InvalidOperationException(
                        string.Format("Entity cannot be more than {0:n0} bytes", int.MaxValue));
                }

                bufferLength = (int)s.Length;
            }

            LockMemoryManager(() =>
            {
                if (!UseUnsafeMemoryManager)
                {
                    var mm = ReadVersionedMemoryManagerUnsafe(out var version);
                    var offset = Update(mm, record.Offset, buffer, bufferLength);

                    if (offset != -1)
                    {
                        WriteMemoryManagerUnsafe(mm);
                        record.UpdateOffset(offset);
                        IncrementVersion(version);
                    }
                }
                else
                {
                    Update(_memoryManager, record.Offset, buffer, bufferLength);
                }
            });
        }

        // Todo: add option to zero memory to avoid info disclosure
        private long Update(MemoryManager memoryManager, long offset, byte[] buffer, int length)
        {
            var size = memoryManager.GetSizeFromOffset(offset);

            if (length <= size)
            {
                _stream.Position = offset;
                _stream.Write(buffer, 0, length);
                _stream.Flush();
                return -1;
            }

            memoryManager.FreeOffset(offset);
            var allocation = memoryManager.Allocate(length);
            allocation.Write(buffer, length);

            return allocation.Handle * memoryManager.PageSize;
        }

        public void UpdateMemoryManager(Action<MemoryManager> update)
        {
            if (!UseUnsafeMemoryManager)
            {
                LockMemoryManager(() =>
                {
                    var mm = ReadVersionedMemoryManagerUnsafe(out var version);
                    update(mm);
                    WriteMemoryManagerUnsafe(mm);
                    IncrementVersion(version);
                });
            }
            else
            {
                LockMemoryManager(() => update(_memoryManager));
            }
        }

        public override int Count()
        {
            var count = 0;

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
            if (IsDisposed)
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

            if (_memoryManagerVersionReader != null)
            {
                _memoryManagerVersionReader.BaseStream.Dispose();
                _memoryManagerVersionFile.Dispose();
            }

            IsDisposed = true;
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

        private void AssertReadOnly(string name = null)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException(
                    $"Cannot {name ?? "create record"} in read-only mode.");
            }
        }

        ~ObjectDatabase()
        {
            if (UseUnsafeMemoryManager && !IsDisposed && !_isCommitted && !IsReadOnly)
            {
                CommitMemoryManager();
            }
        }
    }
}