using System;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Components.ObjectDatabase
{
    [Serializable]
    public abstract class ObjectDatabaseEntityBase : IObjectDatabaseEntity
    {
        [NonSerialized]
        private long _offset;

        [IgnoreDataMember, XmlIgnore, ScriptIgnore]
        public long Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        [NonSerialized]
        private string _filename;

        [IgnoreDataMember, XmlIgnore, ScriptIgnore]
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        [NonSerialized]
        private IDatabaseContext _context;

        [IgnoreDataMember, XmlIgnore, ScriptIgnore]
        public IDatabaseContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
    }
}
