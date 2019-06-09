using Components.Aphid.TypeSystem;

namespace Components.Aphid.UnitTests.Shared
{
    public class TestClass
    {
        private TestClass()
        {
            RootControl = new TextBox("TextBox1")
            {
                Position = new Vector3D(10, 20, 5),
                Width = 20,
                Height = 30,
                Value = "Name1",
                MaxLength = 0x100,
                IsTrusted = false,
            };
        }

        public static bool StaticBoolField;

        public static bool StaticBoolProperty { get; set; }

        public static AphidObject StaticAphidObjectProperty { get; set; }

        public static UIComponent RootControl { get; set; }
    }
}
