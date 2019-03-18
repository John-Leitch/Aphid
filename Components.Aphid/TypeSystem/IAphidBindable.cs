namespace Components.Aphid.TypeSystem
{
    public interface IAphidBindable
    {
        void OnBinding(AphidObject source);
        void OnBound(AphidObject source);
    }
}
