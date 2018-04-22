using Components.Aphid.Tests.Integration.Shared;
using Components.Aphid.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Components.Aphid.TypeSystem;
using System.Linq.Expressions;

namespace Components.Aphid.Tests.Integration
{
    public partial class InteropTests
    {
        private const string _init = "using Components.Aphid.Tests.Integration.Shared; ";

        [Test]
        public void TextBoxDefaultCtorTest()
        {
            Is<TextBox>(
                _init + "var t = new TextBox(); ret t;",
                x => x.Name == null && x.Width == 300 && x.Height == 200);
        }

        [Test]
        public void TextBoxCtorArgTest()
        {
            Is<TextBox>(
                _init + "var t = new TextBox('TextBoxName'); ret t;",
                x => x.Name == "TextBoxName" && x.Width == 300 && x.Height == 200);
        }

        [Test]
        public void TextBoxValueSetTest()
        {
            Is<TextBox>(
                _init + "var t = new TextBox('TextBoxName'); t.Value = 'hello world'; ret t;",
                x => x.Value == "hello world");
        }

        [Test]
        public void TextBoxValueGetSetTest()
        {
            Is<TextBox>(
                _init + "var t = new TextBox('TextBoxName'); t.Value = 'hello '; t.Value += 'world'; ret t;",
                x => 
                    x.Value == "hello world");
        }

        [Test]
        public void WindowDefaultCtorTest()
        {
            Is<Window>(
                _init + "var t = new Window(); ret t;",
                x => x.Children.Count == 0);
        }

        [Test]
        public void WindowCtorArgTest()
        {
            Is<Window>(
                _init + "var t = new Window('WindowName'); ret t;",
                x => x.Name == "WindowName" && x.Children.Count == 0);
        }

        [Test]
        public void WindowAddChildTest()
        {
            Is<Window>(
                _init + "var t = new Window('TextBoxName'); t.Children.Add(new TextBox()); ret t;",
                x =>
                    x.Children.Count == 1 &&
                    x.Children.OfType<TextBox>().SingleOrDefault() != null);
        }
    }
}
