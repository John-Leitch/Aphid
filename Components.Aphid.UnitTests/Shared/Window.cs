using System.Collections.ObjectModel;

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
