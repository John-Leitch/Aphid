using NUnit.Framework;

namespace Components.ObjectDatabase.Tests
{
    public class PageSizeAttribute : ValuesAttribute
    {
        public PageSizeAttribute()
            : base(0x8, 0x20, 0x100, 0x2000, 0x200000)
        {
        }
    }
}
