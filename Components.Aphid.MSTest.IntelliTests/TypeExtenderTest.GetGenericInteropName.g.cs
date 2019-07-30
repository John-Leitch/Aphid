using System.Reflection;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="TypeExtenderTest.GetGenericInteropName.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;
using Microsoft.Pex.Engine.Exceptions;

namespace Components.Aphid.TypeSystem.Tests
{
    public partial class TypeExtenderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(TargetInvocationException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(TargetInvocationException))]
public void GetGenericInteropNameThrowsTargetInvocationException778()
{
    string s;
    s = this.GetGenericInteropName((Type)null);
}
    }
}