using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests.Shared
{
    public abstract class UIComponent
    {
        public string Name { get; set; }

        public Vector3D Position { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public bool IsTrusted { get; set; }

        public UIComponent()
            : this(300, 200)
        {
        }

        public UIComponent(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        public UIComponent(string name)
            : this() => Name = name;
    }
}
