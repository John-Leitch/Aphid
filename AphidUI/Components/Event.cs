using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace Components.Aphid.Wpf
{
    [ContentProperty("Handler")]
    public class Event : DependencyObject
    {
        public string EventName { get; set; }

        public static readonly DependencyProperty HandlerProperty = DependencyProperty.RegisterAttached(
            "Handler",
            typeof(Aphid),
            typeof(DependencyObject),
            new FrameworkPropertyMetadata(
                new Aphid(),
                FrameworkPropertyMetadataOptions.None,
                new PropertyChangedCallback(HandlerChanged)));

        //public static readonly DependencyProperty EventNameProperty = DependencyProperty.RegisterAttached(
        //    "EventName",
        //    typeof(string),
        //    typeof(Aphid),
        //    new FrameworkPropertyMetadata(
        //        null,
        //        FrameworkPropertyMetadataOptions.AffectsRender,
        //        new PropertyChangedCallback(EventNameChanged)));

        public Event()
        {
        }

        public static void SetHandler(UIElement element, Aphid value) =>
            element.SetValue(HandlerProperty, value);

        public static Aphid GetHandler(UIElement element) =>
            (Aphid)element.GetValue(HandlerProperty);

        //public static void SetEventName(UIElement element, string value) => element.SetValue(EventNameProperty, value);

        //public static string GetEventName(UIElement element) => (string)element.GetValue(EventNameProperty);

        private static void HandlerChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var ev = (DependencyObject)sender;
            var parent = VisualTreeHelper.GetParent(ev);

            //foreach (var o in (IEnumerable)args.OldValue)
            //{
            //}
        }

        private static void EventNameChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
        }
    }
}
