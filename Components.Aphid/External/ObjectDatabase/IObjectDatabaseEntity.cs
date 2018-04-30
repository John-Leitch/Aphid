
namespace Components.ObjectDatabase
{
    public interface IObjectDatabaseEntity
    {
        long Offset { get; set; }

        string Filename { get; set; }

        IDatabaseContext Context { get; set; }
    }
}
