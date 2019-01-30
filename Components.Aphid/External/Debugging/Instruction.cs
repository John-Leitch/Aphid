using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    public class StringTable : IEnumerable<string>
    {
        private List<string> _values = new List<string>();

        public int this[string value]
        {
            get
            {
                var index = _values.IndexOf(value);

                if (index < 0)
                {
                    index = _values.Count;
                    _values.Add(value);
                }

                return index;
            }
        }

        public string this[int key] => _values[key];

        public int GetKey(string value)
        {
            var index = _values.IndexOf(value);

            if (index < 0)
            {
                index = _values.Count;
                _values.Add(value);
            }

            return index;
        }

        public StringTable()
        {
        }

        public StringTable(List<string> values) => _values = values;

        public static implicit operator StringTable(List<string> value) => new StringTable(value);

        public IEnumerator<string> GetEnumerator() => _values.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => ((IEnumerable)_values).GetEnumerator();

        public void Serialize(BinaryWriter writer)
        {
            var pos = (int)writer.BaseStream.Position;
            writer.BaseStream.Position = 0;
            writer.Write(pos);
            writer.BaseStream.Position = pos;
            writer.Write(_values.Count);

            foreach (var v in _values)
            {
                var bytes = v.GetBytes();
                writer.Write(bytes.Length);
                writer.Write(bytes);
            }
        }

        public static StringTable Deserialize(BinaryReader reader)
        {
            reader.BaseStream.Position = 0;
            reader.BaseStream.Position = reader.ReadInt32();
            var c = reader.ReadInt32();
            return Enumerable
                .Range(0, c)
                .Select(x => reader.ReadBytes(reader.ReadInt32()).GetString())
                .ToList();
        }
    }

    [Serializable]
    public class Instruction
    {
        public uint Address { get; set; }

        public string Mnemonic { get; set; }

        public string ByteString { get; set; }

        public NativeFunction Function { get; set; }

        public void Serialize(StringTable table, BinaryWriter writer)
        {
            writer.Write(Address);
            writer.Write(table.GetKey(Mnemonic));
            writer.Write(table.GetKey(ByteString));
        }

        public static Instruction Deserialize(StringTable table, BinaryReader reader)
        {
            return new Instruction
            {
                Address = reader.ReadUInt32(),
                Mnemonic = table[reader.ReadInt32()],
                ByteString = table[reader.ReadInt32()],
            };
        }
    }
}
