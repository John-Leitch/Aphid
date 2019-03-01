using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UnitTests.Shared
{
    public class Window : UIComponent
    {
        public ObservableCollection<UIComponent> Children { get; set; }

        public Window() => Children = new ObservableCollection<UIComponent>();

        public Window(string name)
            : base(name) => Children = new ObservableCollection<UIComponent>();
    }
}
