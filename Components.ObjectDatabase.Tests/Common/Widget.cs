using System;
using System.Linq;

namespace Components.ObjectDatabase.Tests
{
    [Serializable]
    public class Widget : ObjectDatabaseEntityBase, IEquatable<Widget>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public byte[] Data { get; set; }
        public string Message { get; set; }
        public Widget Parent { get; set; }

        public Widget()
        {
        }

        public Widget(int x, int y, byte[] data, string message, Widget parent)
            : this()
        {
            X = x;
            Y = y;
            Data = data;
            Message = message;
            Parent = parent;
        }

        public bool Equals(Widget other) =>
            other != null &&
                X == other.X &&
                Y == other.Y &&
                ((Data == other.Data) ||
                    (Data != null && other.Data != null && Data.SequenceEqual(other.Data))) &&
                Message == other.Message &&
                (Parent == other.Parent || (Parent?.Equals(other.Parent) ?? false));

        public override int GetHashCode()
        {
            unchecked
            {
                var seed = 0x10;
                int nonZero(int x) => x != 0 ? x : ~seed;
                var h = nonZero(base.GetHashCode());
                void hash(object x) => h *= nonZero(((x?.GetHashCode() ?? ~seed) ^ (seed <<= 0x1)));
                hash(X);
                hash(Y);
                hash(Data);
                hash(Message);
                hash(Parent);
                    
                return h;
            }
        }

        public override string ToString() =>
            $"X={X}, Y={Y}, Data={Data}, Message={Message}, Parent={Parent}";
    }
}
