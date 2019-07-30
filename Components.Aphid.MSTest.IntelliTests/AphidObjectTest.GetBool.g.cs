using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Components.Aphid.TypeSystem;
// <copyright file="AphidObjectTest.GetBool.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
    public partial class AphidObjectTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetBoolThrowsNullReferenceException646()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(679);
    b = this.GetBool((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(InvalidCastException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(InvalidCastException))]
public void GetBoolThrowsInvalidCastException345()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(0);
    b = this.GetBool((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetBoolThrowsNullReferenceException64601()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(36);
    b = this.GetBool((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetBoolThrowsNullReferenceException117()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create(7);
    b = this.GetBool((AphidObject)o);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidObjectTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void GetBoolThrowsNullReferenceException11701()
{
    object o;
    bool b;
    o = AphidObjectFactory.Create();
    b = this.GetBool((AphidObject)o);
}
    }
}