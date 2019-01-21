using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class AphidVerilogEmitter
    {
        private string[] _edges = new[]
        {
            "posedge",
            "negedge",
        };

        private Dictionary<AphidTokenType, string> _operatorMap = new Dictionary<AphidTokenType, string>
        {
            { AphidTokenType.AssignmentOperator, "<=" },

            { AphidTokenType.LessThanOperator, "<" },
            { AphidTokenType.LessThanOrEqualOperator, "<=" },
            { AphidTokenType.GreaterThanOperator, ">" },
            { AphidTokenType.GreaterThanOrEqualOperator, ">=" },

            { AphidTokenType.EqualityOperator, "==" },
            { AphidTokenType.NotEqualOperator, "!=" },

            { AphidTokenType.AdditionOperator, "+" },
            { AphidTokenType.MinusOperator, "-" },
            { AphidTokenType.MultiplicationOperator, "*" },
            { AphidTokenType.DivisionOperator, "/" },

            { AphidTokenType.AndOperator, "&&" },
            { AphidTokenType.OrOperator, "||" },

            { AphidTokenType.BinaryAndOperator, "&" },
            { AphidTokenType.BinaryOrOperator, "|" },
            { AphidTokenType.XorOperator, "^" },

            { AphidTokenType.ShiftLeft, "<<" },
            { AphidTokenType.ShiftRight, ">>" },

            { AphidTokenType.RangeOperator, ":" },
        };

        private Dictionary<string, int> _typeTable = new Dictionary<string, int>();

        private Dictionary<string, int> _paramTable = new Dictionary<string, int>();

        private StringBuilder _code;

        private string _tab = "  ";

        private string _indent = "";

        private void AddTab()
        {
            _indent += _tab;
        }

        private void RemoveTab()
        {
            _indent = _indent.Remove(_indent.Length - _tab.Length);
        }

        private void Append(string format, params object[] arg)
        {
            AppendUnindented(_indent + format, arg);
        }

        private void AppendUnindented(string format, params object[] arg)
        {
            _code.AppendFormat(format, arg);
        }

        private TExpression TryCast<TExpression>(object expression)
            where TExpression : class
        {
            var t = expression as TExpression;

            if (t == null)
            {
                throw new NotImplementedException();
            }

            return t;
        }

        public string Emit(IEnumerable<AphidExpression> ast)
        {
            _code = new StringBuilder();

            foreach (var n in ast)
            {
                Emit(n);
            }

            return _code.ToString();
        }

        private void Emit(AphidExpression node)
        {
            switch (node.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    Emit((IdentifierExpression)node);
                    break;

                case AphidExpressionType.NumberExpression:
                    Emit((NumberExpression)node);
                    break;

                case AphidExpressionType.ArrayAccessExpression:
                    Emit((ArrayAccessExpression)node);
                    break;

                case AphidExpressionType.BooleanExpression:
                    Emit((BooleanExpression)node);
                    break;

                case AphidExpressionType.ArrayExpression:
                    Emit((ArrayExpression)node);
                    break;

                case AphidExpressionType.UnaryOperatorExpression:
                    Emit((UnaryOperatorExpression)node);
                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    Emit((BinaryOperatorExpression)node);
                    break;

                case AphidExpressionType.TernaryOperatorExpression:
                    Emit((TernaryOperatorExpression)node);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void Emit(IdentifierExpression node)
        {
            _code.Append(node.Identifier);
        }

        private void Emit(NumberExpression node)
        {
            _code.Append(node.Value);
        }

        private void Emit(BooleanExpression node)
        {
            AppendUnindented(node.Value ? "1" : "0");
        }

        private void Emit(ArrayAccessExpression node)
        {
            Emit(node.ArrayExpression);
            AppendUnindented("[");
            EmitTuple(node.KeyExpressions.ToArray(), Emit, multiline: false);
            AppendUnindented("]");
        }

        private void Emit(ArrayExpression node)
        {
            AppendUnindented("{{ ");
            EmitTuple(node.Elements.ToArray(), Emit, multiline: false);
            AppendUnindented(" }}");
        }

        private void Emit(UnaryOperatorExpression node)
        {
            string s;

            switch (node.Operator)
            {
                case AphidTokenType.NotOperator:
                    s = "!";
                    break;

                case AphidTokenType.ComplementOperator:
                    s = "~";
                    break;

                default:
                    throw new NotImplementedException();
            }

            AppendUnindented(s);
            AppendUnindented("(");
            Emit(node.Operand);
            AppendUnindented(")");
        }

        private void Emit(BinaryOperatorExpression node)
        {
            switch (node.Operator)
            {
                case AphidTokenType.AssignmentOperator:
                    EmitAssignment(node);
                    break;

                default:
                    string op;

                    if (!_operatorMap.TryGetValue(node.Operator, out op))
                    {
                        throw new NotImplementedException();
                    }

                    if (node.Operator != AphidTokenType.RangeOperator)
                    {
                        AppendUnindented("(");
                    }

                    Emit(node.LeftOperand);
                    _code.AppendFormat(" {0} ", op);
                    Emit(node.RightOperand);

                    if (node.Operator != AphidTokenType.RangeOperator)
                    {
                        AppendUnindented(")");
                    }

                    break;
            }
        }

        private void Emit(TernaryOperatorExpression node)
        {
            switch (node.Operator)
            {
                case AphidTokenType.ConditionalOperator:
                    Emit(node.FirstOperand);
                    AppendUnindented(" ? ");
                    Emit(node.SecondOperand);
                    AppendUnindented(" : ");
                    Emit(node.ThirdOperand);
                    break;

                default:
                    throw new InvalidOperationException();
            }
        }

        private void EmitAssignment(BinaryOperatorExpression node)
        {
            var id = TryCast<IdentifierExpression>(node.LeftOperand);

            switch (node.RightOperand.Type)
            {
                case AphidExpressionType.FunctionExpression:
                    var body = TryCast<FunctionExpression>(node.RightOperand);
                    EmitModule(id, body);
                    break;

                case AphidExpressionType.NumberExpression:
                    if (_typeTable.ContainsKey(id.Identifier))
                    {
                        throw new InvalidOperationException();
                    }

                    _typeTable.Add(
                        id.Identifier,
                        (int)((NumberExpression)node.RightOperand).Value);

                    break;

                default:
                    throw new NotImplementedException();
            }

        }

        private void EmitModule(IdentifierExpression id, FunctionExpression body)
        {
            Append("module {0}", id.Identifier);

            if (FilterArgs(true, body.Args).Any())
            {
                AppendUnindented(" #(\r\n");
                AddTab();
                EmitModuleParameters(body.Args);
                RemoveTab();
                AppendUnindented(")");
            }

            if (FilterArgs(false, body.Args).Any())
            {
                AppendUnindented("(\r\n");
                AddTab();
                EmitModuleArguments(body.Args);
                RemoveTab();
                AppendUnindented(")");
            }

            AppendUnindented(";\r\n");
            AddTab();
            EmitModuleBody(body.Body);
            RemoveTab();
            Append("endmodule\r\n\r\n");
        }

        private void EmitModuleParameters(IEnumerable<AphidExpression> args)
        {
            _paramTable.Clear();

            EmitTuple(
                FilterArgs(isParam: true, expressions: args)
                    .Cast<BinaryOperatorExpression>()
                    .ToArray(),
                EmitModuleParameter);
        }

        private void EmitModuleParameter(BinaryOperatorExpression parameter)
        {
            var id = TryCast<IdentifierExpression>(parameter.LeftOperand);
            Append("parameter {0} = ", id.Identifier);

            switch (parameter.RightOperand.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var id2 = TryCast<IdentifierExpression>(parameter.RightOperand);
                    _paramTable.Add(id.Identifier, ResolveType(id2.Identifier));
                    AppendUnindented(ResolveType(id2.Identifier).ToString());
                    break;

                default:
                    Emit(parameter.RightOperand);
                    break;
            }
        }

        private IdentifierExpression GetArgumentId(AphidExpression arg)
        {
            switch (arg.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return (IdentifierExpression)arg;

                case AphidExpressionType.BinaryOperatorExpression:
                    return (IdentifierExpression)((BinaryOperatorExpression)arg).LeftOperand;

                default:
                    throw new NotImplementedException();
            }
        }

        private TValue Resolve<TKey, TValue>(Dictionary<TKey, TValue> table, TKey key)
        {

            if (!table.TryGetValue(key, out var size))
            {
                throw new InvalidOperationException(string.Format("Could not resolve '{0}'.", key));
            }

            return size;
        }

        private int ResolveType(string type)
        {
            return Resolve(_typeTable, type);
        }

        private int ResolveParameter(string parameter)
        {
            return Resolve(_paramTable, parameter);
        }

        private VerilogAttributes ParseAttributes(IdentifierExpression identifier)
        {
            var attrStack = new Queue<string>(identifier.Attributes.Select(x => x.Identifier));

            bool isInput = false, isWire = true;

            if (attrStack.Count > 0)
            {
                switch (attrStack.Peek())
                {
                    case VerilogKeyword.Input:
                        isInput = true;
                        attrStack.Dequeue();
                        break;

                    case VerilogKeyword.Output:
                        attrStack.Dequeue();
                        break;
                }
            }

            if (attrStack.Count > 0)
            {
                switch (attrStack.Peek())
                {
                    case VerilogKeyword.Wire:
                        attrStack.Dequeue();
                        break;

                    case VerilogKeyword.Reg:
                        isWire = false;
                        attrStack.Dequeue();
                        break;
                }
            }

            int size = 1;
            var isSizeParam = false;
            string sizeParam = null;

            if (attrStack.Count > 0)
            {
                var sizeAttr = attrStack.Dequeue();

                try
                {
                    size = ResolveType(sizeAttr);
                }
                catch (InvalidOperationException)
                {
                    isSizeParam = true;

                    if (!_paramTable.ContainsKey(sizeAttr))
                    {
                        throw new InvalidOperationException();
                    }

                    sizeParam = sizeAttr;
                }
            }

            if (attrStack.Count > 0)
            {
                throw new InvalidOperationException("Unknown attributes.");
            }

            return new VerilogAttributes(isInput, isWire, isSizeParam, size, sizeParam);
        }

        private string GetSizeRange(int size)
        {
            // Todo: big endian support
            return string.Format("[{0}:0]", size - 1);
        }

        private string GetParamSizeRange(string param)
        {
            // Todo: big endian support
            return string.Format("[{0} - 1:0]", param);
        }

        private string GetConstSize(int size)
        {
            return size == 1 ? null : GetSizeRange(size);
        }

        private void EmitVarDeclaration(AphidExpression expression)
        {
            IdentifierExpression identifier;
            AphidExpression value = null;

            switch (expression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    identifier = TryCast<IdentifierExpression>(expression);
                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOp = (BinaryOperatorExpression)expression;
                    identifier = TryCast<IdentifierExpression>(binOp.LeftOperand);
                    value = binOp.RightOperand;
                    break;

                default:
                    throw new InvalidOperationException();
            }

            var attrs = ParseAttributes(identifier);

            var attrStrings = new List<string>
            {
                attrs.IsInput ? VerilogKeyword.Input : VerilogKeyword.Output,
                attrs.IsWire ? VerilogKeyword.Wire : VerilogKeyword.Reg,
            };

            var sizeStr = !attrs.IsSizeParam ?
                GetConstSize(attrs.Size) :
                GetParamSizeRange(attrs.SizeParam);

            if (sizeStr != null)
            {
                attrStrings.Add(sizeStr);
            }

            attrStrings.Add(identifier.Identifier);
            Append(string.Join(" ", attrStrings));

            if (value != null)
            {
                AppendUnindented(" = ");
                Emit(value);
            }
        }

        private IEnumerable<AphidExpression> FilterArgs(
            bool isParam,
            IEnumerable<AphidExpression> expressions)
        {
            return expressions.Where(x =>
                GetArgumentId(x).Attributes.Any(y => y.Identifier == VerilogKeyword.Param) == isParam);
        }

        private void EmitTuple<TElement>(TElement[] items, Action<TElement> emit, bool multiline = true)
        {
            for (int i = 0; i < items.Length; i++)
            {
                emit(items[i]);

                if (i != items.Length - 1)
                {
                    AppendUnindented(",");

                    if (!multiline)
                    {
                        AppendUnindented(" ");
                    }
                }

                if (multiline)
                {
                    AppendUnindented("\r\n");
                }
            }
        }

        private void EmitModuleArguments(List<AphidExpression> args)
        {
            EmitTuple(FilterArgs(false, args).ToArray(), EmitVarDeclaration);
        }

        private void EmitModuleBody(List<AphidExpression> body)
        {
            foreach (var node in body)
            {
                EmitModuleStatement(node);
            }
        }

        private void EmitModuleStatement(AphidExpression statement)
        {
            switch (statement.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    var id = (IdentifierExpression)statement;
                    EmitVar(id);
                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    EmitModuleBinaryExpression((BinaryOperatorExpression)statement);
                    break;

                case AphidExpressionType.FunctionExpression:
                    EmitAlwaysBlock((FunctionExpression)statement);
                    break;

                case AphidExpressionType.CallExpression:
                    EmitCallStatement((CallExpression)statement);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void EmitBlock(IEnumerable<AphidExpression> statements, Action<AphidExpression> emit)
        {
            AddTab();
            Append(VerilogKeyword.Begin + "\r\n");
            AddTab();

            foreach (var s in statements)
            {
                emit(s);
            }

            RemoveTab();
            Append(VerilogKeyword.End + "\r\n\r\n");
            RemoveTab();
        }

        private bool CallHasArgs(CallExpression call, params AphidExpressionType[] args)
        {
            return call.Args.Count == args.Length ?
                call.Args.Select((x, i) => x.Type == args[i]).All(x => x) :
                false;
        }

        private void CheckCallArgs(CallExpression call, params AphidExpressionType[] args)
        {
            if (!CallHasArgs(call, args))
            {
                throw new InvalidOperationException();
            }
        }

        private void EmitBlock(AphidExpression block)
        {
            switch (block.Type)
            {
                case AphidExpressionType.FunctionExpression:
                    EmitBlock(
                        ((FunctionExpression)block).Body,
                        EmitCodeBlockStatement);

                    break;

                default:
                    EmitCodeBlockStatement(block);
                    break;
            }
        }

        private void EmitCallStatement(CallExpression call)
        {
            var id = TryCast<IdentifierExpression>(call.FunctionExpression);

            switch (id.Identifier)
            {
                case VerilogKeyword.Initial:
                case VerilogKeyword.Forever:
                    if (call.Args.Count != 1)
                    {
                        throw new InvalidOperationException();
                    }

                    Append(id.Identifier + "\r\n");
                    EmitBlock(call.Args[0]);
                    break;

                case "sleep":
                    CheckCallArgs(call, AphidExpressionType.NumberExpression);
                    var number = ((NumberExpression)call.Args[0]).Value;
                    Append("#{0}\r\n", number);
                    break;

                default:
                    throw new InvalidOperationException();
            }
        }

        private void EmitVar(IdentifierExpression id, AphidExpression value = null)
        {
            var size = _typeTable[GetVarType(id)];
            var isWire = id.Attributes.Any(x => x.Identifier == VerilogKeyword.Wire);

            EmitVar(
                isWire ? VerilogKeyword.Wire : VerilogKeyword.Reg,
                size,
                id.Identifier);

            if (value != null)
            {
                AppendUnindented(" = ");
                Emit(value);
            }

            EmitEndOfStatement();
        }

        private void EmitModuleBinaryExpression(BinaryOperatorExpression binOpExp)
        {
            var id = TryCast<IdentifierExpression>(binOpExp.LeftOperand);
            string op;

            switch (binOpExp.Operator)
            {
                case AphidTokenType.AssignmentOperator:
                    switch (binOpExp.RightOperand.Type)
                    {
                        case AphidExpressionType.CallExpression:
                            EmitModuleInstantiation(binOpExp);
                            break;

                        default:
                            EmitVar(id, binOpExp.RightOperand);
                            break;
                    }

                    return;

                case AphidTokenType.SelectOperator:
                    op = VerilogKeyword.Assign;
                    break;

                default:
                    throw new InvalidOperationException();
            }

            Append(
                "{0} {1} = ",
                op,
                id.Identifier);

            Emit(binOpExp.RightOperand);
            EmitEndOfStatement();
        }

        private string GetValue(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.IdentifierExpression:
                    return ((IdentifierExpression)expression).Identifier;

                case AphidExpressionType.NumberExpression:
                    return ((NumberExpression)expression).Value.ToString();

                default:
                    throw new InvalidOperationException();
            }
        }

        private void EmitModuleInstantiation(BinaryOperatorExpression instantiation)
        {
            var id = (IdentifierExpression)instantiation.LeftOperand;
            var call = (CallExpression)instantiation.RightOperand;
            var callId = TryCast<IdentifierExpression>(call.FunctionExpression);
            AppendUnindented("\r\n");
            Append("{0} {1} (\r\n", callId.Identifier, id.Identifier);
            AddTab();

            if (call.Args.All(x => x.Type == AphidExpressionType.IdentifierExpression))
            {
                EmitTuple(
                    call.Args
                        .Cast<IdentifierExpression>()
                        .Select(x => x.Identifier)
                        .ToArray(),
                    x => Append(x));
            }
            else if (call.Args.Count == 1 &&
                call.Args[0].Type == AphidExpressionType.ObjectExpression)
            {
                var objExp = (ObjectExpression)call.Args[0];

                EmitTuple(
                    objExp.Pairs
                    .Select(x => Tuple.Create(
                        (IdentifierExpression)x.LeftOperand,
                        x.RightOperand))
                    .Select(x => string.Format(
                        ".{0}({1})",
                        x.Item1.Identifier,
                        GetValue(x.Item2)))
                    .ToArray(),
                    x => Append(x));
            }
            else
            {
                throw new InvalidOperationException();
            }

            RemoveTab();
            Append(");\r\n\r\n");
        }

        private void EmitAlwaysBlock(FunctionExpression function)
        {
            Append("always @(");
            EmitAlwaysList(function.Args.Cast<IdentifierExpression>().ToList());
            AppendUnindented(")\r\n");
            AddTab();
            Append("begin\r\n");
            AddTab();
            EmitCodeBlock(function.Body);
            RemoveTab();
            Append("end\r\n\r\n");
            RemoveTab();
        }

        private void EmitAlwaysList(List<IdentifierExpression> sensitivityList)
        {
            var isFirst = true;

            foreach (var item in sensitivityList)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    _code.Append(" or ");
                }

                EmitAlwaysListItem(item);
            }
        }

        private void EmitCodeBlock(List<AphidExpression> body)
        {
            foreach (var statement in body)
            {
                EmitCodeBlockStatement(statement);
            }
        }

        private void EmitCodeBlockStatement(AphidExpression statement)
        {
            switch (statement.Type)
            {
                case AphidExpressionType.IfExpression:
                    EmitIfExpression((IfExpression)statement);
                    break;

                case AphidExpressionType.UnaryOperatorExpression:
                    EmitCodeBlockUnaryStatement((UnaryOperatorExpression)statement);
                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    EmitCodeBlockBinaryExpression((BinaryOperatorExpression)statement);
                    break;

                case AphidExpressionType.CallExpression:
                    EmitCallStatement((CallExpression)statement);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void EmitCodeBlockBinaryExpression(BinaryOperatorExpression binOpExp)
        {
            switch (binOpExp.Operator)
            {
                case AphidTokenType.AssignmentOperator:
                    EmitCodeBlockAssignmentStatement(binOpExp);
                    break;

                default:
                    throw new InvalidOperationException();
            }
        }

        private void EmitCodeBlockAssignmentStatement(BinaryOperatorExpression binOpExp)
        {
            Append("");
            Emit(binOpExp.LeftOperand);
            AppendUnindented(" <= ");
            //var id = TryCast<IdentifierExpression>(binOpExp.LeftOperand);
            //Append("{0} <= ", id.Identifier);
            Emit(binOpExp.RightOperand);
            EmitEndOfStatement();
        }

        private void EmitIfExpression(IfExpression ifExpression)
        {
            Append("if (");
            Emit(ifExpression.Condition);
            AppendUnindented(")\r\n");
            AddTab();
            Append("begin\r\n");
            AddTab();
            EmitCodeBlock(ifExpression.Body);
            RemoveTab();
            Append("end\r\n");
            RemoveTab();

            if (ifExpression.ElseBody != null)
            {
                EmitElseStatement(ifExpression.ElseBody);
            }
        }

        private void EmitElseStatement(List<AphidExpression> elseBody)
        {
            Append("else\r\n");
            AddTab();
            Append("begin\r\n");
            AddTab();
            EmitCodeBlock(elseBody);
            RemoveTab();
            Append("end\r\n");
            RemoveTab();
        }

        private void EmitCodeBlockUnaryStatement(UnaryOperatorExpression unaryExpression)
        {
            switch (unaryExpression.Operator)
            {
                case AphidTokenType.IncrementOperator:
                    EmitIncrementStatement(unaryExpression);
                    break;

                default:
                    throw new InvalidOperationException();
            }
        }

        private void EmitIncrementStatement(UnaryOperatorExpression unaryExpression)
        {
            var id = TryCast<IdentifierExpression>(unaryExpression.Operand);
            Append("{0} <= {0} + 1", id.Identifier);
            EmitEndOfStatement();
        }

        private void EmitAlwaysListItem(IdentifierExpression id)
        {
            var edge = id.Attributes
                .Select(x => x.Identifier)
                .SingleOrDefault(_edges.Contains);

            if (edge == null)
            {
                throw new NotImplementedException();
            }

            _code.AppendFormat("{0} {1}", edge, id.Identifier);
        }

        private void EmitVar(string elementType, int size, string name)
        {
            Append(elementType + " ");
            var s = GetConstSize(size);

            if (s != null)
            {
                AppendUnindented(s + " ");
            }

            AppendUnindented(name);

            //Append("reg [{0}:0] {1}", size - 1, name);
        }

        private void EmitEndOfStatement()
        {
            _code.AppendLine(";");
        }

        private string GetVarType(IdentifierExpression id)
        {
            // Todo: handle this better so unresolved types cause
            // exceptions
            return id.Attributes
                .Select(x => x.Identifier)
                .SingleOrDefault(_typeTable.Keys.Contains) ?? "bit";
        }
    }
}
