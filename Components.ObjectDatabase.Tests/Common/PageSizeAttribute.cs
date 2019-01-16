using NUnit.Framework;

namespace Components.ObjectDatabase.Tests
{
    public class PageSizeAttribute : ValuesAttribute
    {
        public PageSizeAttribute()
            : base(0x1, 0x2, 0x20, 0x2000, 0x200000)
        {
        }
    }
}
