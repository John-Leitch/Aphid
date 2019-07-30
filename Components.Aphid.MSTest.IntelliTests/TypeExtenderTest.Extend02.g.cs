using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
// <copyright file="TypeExtenderTest.Extend02.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
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
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void Extend02ThrowsNullReferenceException162()
{
    TypeExtender typeExtender;
    typeExtender =
      new TypeExtender((AphidInterpreter)null, (ReaderWriterLockSlim)null);
    this.Extend02(typeExtender, (string)null, (string[])null, 
                  (AphidObject)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void Extend02ThrowsNullReferenceException85()
{
    TypeExtender typeExtender;
    typeExtender =
      new TypeExtender((AphidInterpreter)null, (ReaderWriterLockSlim)null);
    this.Extend02(typeExtender, "", (string[])null, 
                  (AphidObject)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void Extend02ThrowsNullReferenceException868()
{
    TypeExtender typeExtender;
    typeExtender =
      new TypeExtender((AphidInterpreter)null, (ReaderWriterLockSlim)null);
    this.Extend02(typeExtender, "\0", (string[])null, 
                  (AphidObject)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeExtenderTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void Extend02ThrowsNullReferenceException128()
{
    TypeExtender typeExtender;
    typeExtender =
      new TypeExtender((AphidInterpreter)null, (ReaderWriterLockSlim)null);
    this.Extend02(typeExtender, "䵁", (string[])null, 
                  (AphidObject)null, (string)null, (string)null);
}
    }
}