using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Components.IO
{
    // This could be improved by using uints.
    public class MemoryManagerSerializer
    {
        public void Serialize(Stream stream, MemoryManager memoryManager)
        {
            if (memoryManager.Bitmap.Length % 8 != 0)
            {
                throw new ArgumentException("Memorymanager bitmap length must be divisible by 8.");
            }

            var writer = new BinaryWriter(stream);

            // Write MemoryManager.Bitmap
            var bitmap = new byte[memoryManager.Bitmap.Length / 8];
            new BitArray(memoryManager.Bitmap).CopyTo(bitmap, 0);
            writer.Write(bitmap.Length);
            writer.Write(bitmap);

            // Write MemoryManager.SizeTable
            writer.Write(memoryManager.Allocations.Count);

            foreach (var kvp in memoryManager.Allocations)
            {
                writer.Write(kvp.Key);
                writer.Write(kvp.Value);
            }

            // Write MemoryManager.PageSize
            writer.Write(memoryManager.PageSize);

            // Write MemoryManager.ZeroMemory
            writer.Write(memoryManager.ZeroMemory);

            // Write MemoryManager.StartingPosition
            writer.Write(memoryManager.StartingPosition);
        }

        public MemoryManager Deserialize(Stream stream, Stream dataStream)
        {
            var reader = new BinaryReader(stream);            

            // Read MemoryManager.Bitmap
            var len = reader.ReadInt32();
            var buffer = reader.ReadBytes(len);
            var bitmap = new bool[buffer.Length * 8];
            new BitArray(buffer).CopyTo(bitmap, 0);

            // Read MemoryManager.SizeTable
            len = reader.ReadInt32();
            var sizeTable = new Dictionary<int, int>();
            var isCorrupted = false;

            var streamLen = stream.Length;

            for (int i = 0; i < len; i++)
            {
                if (reader.BaseStream.Position + 8 <= streamLen)
                {
                    sizeTable.Add(reader.ReadInt32(), reader.ReadInt32());
                }
                else
                {
                    isCorrupted = true;
                }
            }

            int pageSize;
            bool zeroMemory;
            int startingPosition;

            if (!isCorrupted)
            {
                // Read MemoryManager.PageSize
                pageSize = reader.ReadInt32();

                // Read MemoryManager.ZeroMemory
                zeroMemory = reader.ReadBoolean();

                if (stream.Position + 4 <= streamLen)
                {
                    startingPosition = reader.ReadInt32();
                }
                else
                {
                    startingPosition = 0;
                }
            }
            else
            {
                pageSize = 0x20;
                zeroMemory = true;
                startingPosition = 0;
            }

            return new MemoryManager(
                dataStream,
                bitmap,
                sizeTable,
                pageSize,
                zeroMemory,
                startingPosition);
        }

        public int DeserializeCount(Stream stream)
        {
            if (stream.Length <= 0)
            {
                return 0;
            }

            stream.Position = 0;
            var reader = new BinaryReader(stream);
            var offset = reader.ReadInt32();
            stream.Position += offset;
            return reader.ReadInt32();
        }
    }
}
