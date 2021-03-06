// <copyright file="GenericEqualityComparerFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace System.Collections.Generic
{
    /// <summary>A factory for System.Collections.Generic.GenericEqualityComparer`1[System.String] instances</summary>
    public static partial class GenericEqualityComparerFactory
    {
        /// <summary>A factory for System.Collections.Generic.GenericEqualityComparer`1[System.String] instances</summary>
        [PexFactoryMethod(typeof(GC), "System.Collections.Generic.GenericEqualityComparer`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]")]
        public static object Create()
        {
            throw new NotImplementedException();

            // TODO: Edit factory method of GenericEqualityComparer`1<String>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
