using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Components.Aphid.Interpreter
{
    public partial class AphidInterpreter
    {
        public Func<List<AphidExpression>, AphidExecutionContext, List<AphidExpression>> OnInterpretBlock { get; set; }
        public bool OnInterpretBlockExecuting { get; private set; }

        public Action<AphidExecutionContext<AphidExpression>> OnInterpretStatement { get; set; }
        public bool OnInterpretStatementExecuting { get; private set; }

        public Action<AphidExecutionContext<AphidExpression>> OnInterpretExpression { get; set; }
        public bool OnInterpretExpressionExecuting { get; private set; }

        public Action<AphidExecutionContext<ObjectExpression>> OnInterpretObject { get; set; }
        public bool OnInterpretObjectExecuting { get; private set; }
    }
}
