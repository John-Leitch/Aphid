
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using static Components.Aphid.TypeSystem.ValueHelper;

namespace Components.Aphid.Wpf
{
    public static class ServiceProviderExtension
    {
        public static TService GetService<TService>(this IServiceProvider provider) =>
            (TService)provider.GetService(typeof(TService));
    }
}
