namespace Components.Aphid.UnitTests.Shared
{
    public class Vector2D
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public Vector2D()
        {
        }

        public Vector2D(decimal x, decimal y)
            : this()
        {
            X = x;
            Y = y;
        }
    }
}
