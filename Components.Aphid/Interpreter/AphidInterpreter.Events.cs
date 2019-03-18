using Components.Aphid.Parser;
using System;
using System.Collections.Generic;

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
