using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidExecutionContext
    {
        public bool IsModified { get; set; }

        public bool IsHandled { get; set; }

        public AphidObject Result { get; set; }

        public AphidExecutionContext()
        {
        }

        public AphidExecutionContext(bool isModified, bool isHandled)
            : this()
        {
            IsModified = true;
            IsHandled = true;
        }
    }

    public class AphidExecutionContext<TExpression> : AphidExecutionContext
    {
        public TExpression Expression { get; set; }

        public AphidExecutionContext(TExpression expression)
            : base() => Expression = expression;

        public AphidExecutionContext(TExpression expression, bool isModified, bool isHandled)
            : base(isModified, isHandled) => Expression = expression;

        public static implicit operator AphidExecutionContext<TExpression>(TExpression expression) => new AphidExecutionContext<TExpression>(expression);
    }
}
