namespace Components.Aphid.TypeSystem
{
    public class AphidRef
    {
        public string Name { get; set; }

        public AphidObject Object { get; set; }

        public AphidObject Get() => Object[Name];
    }
}
