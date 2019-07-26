using Components.Aphid.Lexer;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Components.Aphid.Parser;
using Mantispid;
// <copyright file="AphidMutatorTest.Mutate.g.cs">Copyright © AutoSec Tools LLC 2019</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;
using Microsoft.Pex.Engine.Exceptions;

namespace Components.Aphid.Parser.Tests
{
    public partial class AphidMutatorTest
    {

[TestMethod]
[PexGeneratedBy(typeof(AphidMutatorTest))]
public void Mutate797()
{
    IndexTrackingMutator indexTrackingMutator;
    List<AphidExpression> list;
    indexTrackingMutator = new IndexTrackingMutator((string[])null);
    list =
      this.Mutate((AphidMutator)indexTrackingMutator, (List<AphidExpression>)null);
    Assert.IsNull((object)list);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidMutatorTest))]
public void Mutate150()
{
    IndexTrackingMutator indexTrackingMutator;
    List<AphidExpression> list;
    List<AphidExpression> list1;
    indexTrackingMutator = new IndexTrackingMutator((string[])null);
    AphidExpression[] aphidExpressions = new AphidExpression[0];
    list = new List<AphidExpression>((IEnumerable<AphidExpression>)aphidExpressions);
    list1 = this.Mutate((AphidMutator)indexTrackingMutator, list);
    Assert.IsNotNull((object)list1);
    Assert.AreEqual<int>(0, list1.Capacity);
    Assert.AreEqual<int>(0, list1.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidMutatorTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void MutateThrowsNullReferenceException123()
{
    IndexTrackingMutator indexTrackingMutator;
    List<AphidExpression> list;
    List<AphidExpression> list1;
    indexTrackingMutator = new IndexTrackingMutator((string[])null);
    AphidExpression[] aphidExpressions = new AphidExpression[1];
    list = new List<AphidExpression>((IEnumerable<AphidExpression>)aphidExpressions);
    list1 = this.Mutate((AphidMutator)indexTrackingMutator, list);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidMutatorTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void MutateThrowsNullReferenceException725()
{
    IndexTrackingMutator indexTrackingMutator;
    UnaryOperatorExpression unaryOperatorExpression;
    CallExpression callExpression;
    List<AphidExpression> list;
    List<AphidExpression> list1;
    string[] ss = new string[1];
    indexTrackingMutator = new IndexTrackingMutator(ss);
    AphidExpressionContext s0 = new AphidExpressionContext();
    s0.Filename = (string)null;
    s0.Code = (string)null;
    unaryOperatorExpression = new UnaryOperatorExpression
                                  (s0, AphidTokenType.None, (AphidExpression)null, false);
    ((AphidExpression)unaryOperatorExpression).Index = 0;
    ((AphidExpression)unaryOperatorExpression).Length = 0;
    AphidExpressionContext s1 = new AphidExpressionContext();
    s1.Filename = (string)null;
    s1.Code = (string)null;
    callExpression = new CallExpression
                         (s1, (AphidExpression)unaryOperatorExpression, (List<AphidExpression>)null);
    ((AphidExpression)callExpression).Index = 0;
    ((AphidExpression)callExpression).Length = 0;
    AphidExpression[] aphidExpressions = new AphidExpression[1];
    aphidExpressions[0] = (AphidExpression)callExpression;
    list = new List<AphidExpression>((IEnumerable<AphidExpression>)aphidExpressions);
    list1 = this.Mutate((AphidMutator)indexTrackingMutator, list);
}

[TestMethod]
[PexGeneratedBy(typeof(AphidMutatorTest))]
[PexRaisedException(typeof(NullReferenceException), Microsoft.Pex.Engine.Exceptions.PexExceptionState.Expected), ExpectedException(typeof(NullReferenceException))]
public void MutateThrowsNullReferenceException301()
{
    IndexTrackingMutator indexTrackingMutator;
    CallExpression callExpression;
    List<AphidExpression> list;
    List<AphidExpression> list1;
    indexTrackingMutator = new IndexTrackingMutator((string[])null);
    callExpression = new CallExpression((AphidExpressionContext)null, 
                                        (AphidExpression)null, (List<AphidExpression>)null);
    ((AphidExpression)callExpression).Index = 0;
    ((AphidExpression)callExpression).Length = 0;
    AphidExpression[] aphidExpressions = new AphidExpression[1];
    aphidExpressions[0] = (AphidExpression)callExpression;
    list = new List<AphidExpression>((IEnumerable<AphidExpression>)aphidExpressions);
    list1 = this.Mutate((AphidMutator)indexTrackingMutator, list);
}
    }
}
