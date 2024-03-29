using System.Collections.Generic;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
// <copyright file="AphidFunctionFactory.cs">Copyright © AutoSec Tools LLC 2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Components.Aphid.Interpreter;
using System.Linq;
using System.Collections.ObjectModel;

namespace Components.Aphid.TypeSystem
{
    /// <summary>A factory for Components.Aphid.TypeSystem.AphidFunction instances</summary>
    public static partial class AphidFunctionFactory
    {
        public static Lazy<ReadOnlyCollection<AphidFunction>> Functions { get; } = new Lazy<ReadOnlyCollection<AphidFunction>>(() =>
            {
                var interpreter = new AphidInterpreter();
                interpreter.Interpret(AphidExpressionFactory.Block.ToList());
                return new ReadOnlyCollection<AphidFunction>(interpreter.CurrentScope.OfType<AphidFunction>().ToArray());
    });

        /// <summary>A factory for Components.Aphid.TypeSystem.AphidFunction instances</summary>
        [PexFactoryMethod(typeof(AphidFunction))]
        public static AphidFunction Create(int seed) => Functions.Value[seed % Functions.Value.Count];

    }
}

