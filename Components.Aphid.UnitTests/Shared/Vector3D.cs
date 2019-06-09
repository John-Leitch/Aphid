namespace Components.Aphid.UnitTests.Shared
{
    public class Vector3D : Vector2D
    {
        public decimal Z { get; set; }

        public Vector3D()
            : base()
        {
        }

        public Vector3D(decimal x, decimal y, decimal z)
            : base(x, y) => Z = z;
    }
}
