using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Dynamic;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System.Collections;
using Components.External.ConsolePlus;
using static NUnit.Framework.Assert;

namespace Components.Aphid.UnitTests.Shared
{
    public class InterpreterEventArgs : EventArgs
    {
        public AphidInterpreter Interpreter { get; }

        public InterpreterEventArgs(AphidInterpreter interpreter) => Interpreter = interpreter;
    }
}
