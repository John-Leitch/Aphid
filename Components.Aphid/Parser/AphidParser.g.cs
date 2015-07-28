namespace Components.Aphid.Parser
{
    using Components.Aphid.Lexer;
    using System.Linq;
    using System.Collections.Generic;


    public enum AphidExpressionType
    {

        ArrayAccessExpression,

        ArrayExpression,

        BinaryOperatorExpression,

        BooleanExpression,

        BreakExpression,

        CallExpression,

        DoWhileExpression,

        DynamicMemberExpression,

        ExtendExpression,

        ForEachExpression,

        ForExpression,

        FunctionExpression,

        IdentifierExpression,

        IfExpression,

        LoadLibraryExpression,

        LoadScriptExpression,

        NullExpression,

        NumberExpression,

        ObjectExpression,

        PartialFunctionExpression,

        PatternExpression,

        PatternMatchingExpression,

        UnaryOperatorExpression,

        StringExpression,

        SwitchCase,

        SwitchExpression,

        TernaryOperatorExpression,

        ThisExpression,

        TryExpression,

        WhileExpression,
    }

    public partial class ArrayAccessExpression : AphidExpression, IParentNode
    {

        private AphidExpression _arrayExpression;

        private AphidExpression _keyExpression;

        public ArrayAccessExpression(AphidExpression arrayExpression, AphidExpression keyExpression)
        {
            _arrayExpression = arrayExpression;
            _keyExpression = keyExpression;
        }

        public AphidExpression ArrayExpression
        {
            get
            {
                return _arrayExpression;
            }
        }

        public AphidExpression KeyExpression
        {
            get
            {
                return _keyExpression;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ArrayAccessExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    ArrayExpression,
                    KeyExpression};
        }
    }

    public partial class ArrayExpression : AphidExpression, IParentNode
    {

        private System.Collections.Generic.List<AphidExpression> _elements;

        public ArrayExpression(System.Collections.Generic.List<AphidExpression> elements)
        {
            _elements = elements;
        }

        public System.Collections.Generic.List<AphidExpression> Elements
        {
            get
            {
                return _elements;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ArrayExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Elements.ToArray();
        }
    }

    public partial class BinaryOperatorExpression : AphidExpression, IParentNode
    {

        private AphidExpression _leftOperand;

        private AphidTokenType _operator;

        private AphidExpression _rightOperand;

        public BinaryOperatorExpression(AphidExpression leftOperand, AphidTokenType @operator, AphidExpression rightOperand)
        {
            _leftOperand = leftOperand;
            _operator = @operator;
            _rightOperand = rightOperand;
        }

        public AphidExpression LeftOperand
        {
            get
            {
                return _leftOperand;
            }
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public AphidExpression RightOperand
        {
            get
            {
                return _rightOperand;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.BinaryOperatorExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    LeftOperand,
                    RightOperand};
        }
    }

    public partial class BooleanExpression : AphidExpression
    {

        private bool _value;

        public BooleanExpression(bool value)
        {
            _value = value;
        }

        public bool Value
        {
            get
            {
                return _value;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.BooleanExpression;
            }
        }
    }

    public partial class BreakExpression : AphidExpression
    {

        public BreakExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.BreakExpression;
            }
        }
    }

    public partial class CallExpression : AphidExpression, IParentNode
    {

        private AphidExpression _functionExpression;

        private System.Collections.Generic.List<AphidExpression> _args;

        public CallExpression(AphidExpression functionExpression, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> args)
        {
            _functionExpression = functionExpression;
            if ((args != null))
            {
                _args = args;
            }
            else
            {
                _args = new System.Collections.Generic.List<AphidExpression>();
            }
        }

        public AphidExpression FunctionExpression
        {
            get
            {
                return _functionExpression;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Args
        {
            get
            {
                return _args;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.CallExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    FunctionExpression}.Concat(Args).ToArray();
        }
    }

    public partial class DoWhileExpression : AphidExpression, IParentNode
    {

        private AphidExpression _condition;

        private System.Collections.Generic.List<AphidExpression> _body;

        public DoWhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body)
        {
            _condition = condition;
            _body = body;
        }

        public AphidExpression Condition
        {
            get
            {
                return _condition;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.DoWhileExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Condition}.Concat(Body).ToArray();
        }
    }

    public partial class DynamicMemberExpression : AphidExpression, IParentNode
    {

        private AphidExpression _memberExpression;

        public DynamicMemberExpression(AphidExpression memberExpression)
        {
            _memberExpression = memberExpression;
        }

        public AphidExpression MemberExpression
        {
            get
            {
                return _memberExpression;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.DynamicMemberExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    MemberExpression};
        }
    }

    public partial class ExtendExpression : AphidExpression, IParentNode
    {

        private string _extendType;

        private ObjectExpression _object;

        public ExtendExpression(string extendType, ObjectExpression @object)
        {
            _extendType = extendType;
            _object = @object;
        }

        public string ExtendType
        {
            get
            {
                return _extendType;
            }
        }

        public ObjectExpression Object
        {
            get
            {
                return _object;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ExtendExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Object};
        }
    }

    public partial class ForEachExpression : AphidExpression, IParentNode
    {

        private AphidExpression _collection;

        private AphidExpression _element;

        private System.Collections.Generic.List<AphidExpression> _body;

        public ForEachExpression(AphidExpression collection, AphidExpression element, System.Collections.Generic.List<AphidExpression> body)
        {
            _collection = collection;
            _element = element;
            _body = body;
        }

        public AphidExpression Collection
        {
            get
            {
                return _collection;
            }
        }

        public AphidExpression Element
        {
            get
            {
                return _element;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ForEachExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Collection,
                    Element}.Concat(Body).ToArray();
        }
    }

    public partial class ForExpression : AphidExpression, IParentNode
    {

        private AphidExpression _initialization;

        private AphidExpression _condition;

        private AphidExpression _afterthought;

        private System.Collections.Generic.List<AphidExpression> _body;

        public ForExpression(AphidExpression initialization, AphidExpression condition, AphidExpression afterthought, System.Collections.Generic.List<AphidExpression> body)
        {
            _initialization = initialization;
            _condition = condition;
            _afterthought = afterthought;
            _body = body;
        }

        public AphidExpression Initialization
        {
            get
            {
                return _initialization;
            }
        }

        public AphidExpression Condition
        {
            get
            {
                return _condition;
            }
        }

        public AphidExpression Afterthought
        {
            get
            {
                return _afterthought;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ForExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Initialization,
                    Condition,
                    Afterthought}.Concat(Body).ToArray();
        }
    }

    public partial class FunctionExpression : AphidExpression, IParentNode
    {

        private System.Collections.Generic.List<AphidExpression> _args;

        private System.Collections.Generic.List<AphidExpression> _body;

        public FunctionExpression(System.Collections.Generic.List<AphidExpression> args, System.Collections.Generic.List<AphidExpression> body)
        {
            _args = args;
            _body = body;
        }

        public System.Collections.Generic.List<AphidExpression> Args
        {
            get
            {
                return _args;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.FunctionExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Args.Concat(Body).ToArray();
        }
    }

    public partial class IdentifierExpression : AphidExpression, IParentNode
    {

        private string _identifier;

        private System.Collections.Generic.List<IdentifierExpression> _attributes;

        public IdentifierExpression(string identifier, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<IdentifierExpression> attributes)
        {
            _identifier = identifier;
            if ((attributes != null))
            {
                _attributes = attributes;
            }
            else
            {
                _attributes = new System.Collections.Generic.List<IdentifierExpression>();
            }
        }

        public string Identifier
        {
            get
            {
                return _identifier;
            }
        }

        public System.Collections.Generic.List<IdentifierExpression> Attributes
        {
            get
            {
                return _attributes;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.IdentifierExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Attributes.ToArray();
        }
    }

    public partial class IfExpression : AphidExpression, IParentNode
    {

        private AphidExpression _condition;

        private System.Collections.Generic.List<AphidExpression> _body;

        private System.Collections.Generic.List<AphidExpression> _elseBody;

        public IfExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body, System.Collections.Generic.List<AphidExpression> elseBody)
        {
            _condition = condition;
            _body = body;
            _elseBody = elseBody;
        }

        public AphidExpression Condition
        {
            get
            {
                return _condition;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public System.Collections.Generic.List<AphidExpression> ElseBody
        {
            get
            {
                return _elseBody;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.IfExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Condition}.Concat(Body).Concat(ElseBody).ToArray();
        }
    }

    public partial class LoadLibraryExpression : AphidExpression, IParentNode
    {

        private AphidExpression _libraryExpression;

        public LoadLibraryExpression(AphidExpression libraryExpression)
        {
            _libraryExpression = libraryExpression;
        }

        public AphidExpression LibraryExpression
        {
            get
            {
                return _libraryExpression;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.LoadLibraryExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    LibraryExpression};
        }
    }

    public partial class LoadScriptExpression : AphidExpression, IParentNode
    {

        private AphidExpression _fileExpression;

        public LoadScriptExpression(AphidExpression fileExpression)
        {
            _fileExpression = fileExpression;
        }

        public AphidExpression FileExpression
        {
            get
            {
                return _fileExpression;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.LoadScriptExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    FileExpression};
        }
    }

    public partial class NullExpression : AphidExpression
    {

        public NullExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.NullExpression;
            }
        }
    }

    public partial class NumberExpression : AphidExpression
    {

        private decimal _value;

        public NumberExpression(decimal value)
        {
            _value = value;
        }

        public decimal Value
        {
            get
            {
                return _value;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.NumberExpression;
            }
        }
    }

    public partial class ObjectExpression : AphidExpression, IParentNode
    {

        private System.Collections.Generic.List<BinaryOperatorExpression> _pairs;

        public ObjectExpression(System.Collections.Generic.List<BinaryOperatorExpression> pairs)
        {
            _pairs = pairs;
        }

        public System.Collections.Generic.List<BinaryOperatorExpression> Pairs
        {
            get
            {
                return _pairs;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ObjectExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Pairs.ToArray();
        }
    }

    public partial class PartialFunctionExpression : AphidExpression, IParentNode
    {

        private CallExpression _call;

        public PartialFunctionExpression(CallExpression call)
        {
            _call = call;
        }

        public CallExpression Call
        {
            get
            {
                return _call;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.PartialFunctionExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Call};
        }
    }

    public partial class PatternExpression : AphidExpression, IParentNode
    {

        private AphidExpression _value;

        private System.Collections.Generic.List<AphidExpression> _patterns;

        public PatternExpression(AphidExpression value, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> patterns)
        {
            _value = value;
            if ((patterns != null))
            {
                _patterns = patterns;
            }
            else
            {
                _patterns = new System.Collections.Generic.List<AphidExpression>();
            }
        }

        public AphidExpression Value
        {
            get
            {
                return _value;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Patterns
        {
            get
            {
                return _patterns;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.PatternExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Value}.Concat(Patterns).ToArray();
        }
    }

    public partial class PatternMatchingExpression : AphidExpression, IParentNode
    {

        private AphidExpression _testExpression;

        private System.Collections.Generic.List<PatternExpression> _patterns;

        public PatternMatchingExpression(AphidExpression testExpression, System.Collections.Generic.List<PatternExpression> patterns)
        {
            _testExpression = testExpression;
            _patterns = patterns;
        }

        public AphidExpression TestExpression
        {
            get
            {
                return _testExpression;
            }
        }

        public System.Collections.Generic.List<PatternExpression> Patterns
        {
            get
            {
                return _patterns;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.PatternMatchingExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    TestExpression}.Concat(Patterns).ToArray();
        }
    }

    public partial class UnaryOperatorExpression : AphidExpression, IParentNode
    {

        private AphidTokenType _operator;

        private AphidExpression _operand;

        private bool _isPostfix;

        public UnaryOperatorExpression(AphidTokenType @operator, AphidExpression operand, [System.Runtime.InteropServices.OptionalAttribute()] bool isPostfix)
        {
            _operator = @operator;
            _operand = operand;
            _isPostfix = isPostfix;
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public AphidExpression Operand
        {
            get
            {
                return _operand;
            }
        }

        public bool IsPostfix
        {
            get
            {
                return _isPostfix;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.UnaryOperatorExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Operand};
        }
    }

    public partial class StringExpression : AphidExpression
    {

        private string _value;

        public StringExpression(string value)
        {
            _value = value;
        }

        public string Value
        {
            get
            {
                return _value;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.StringExpression;
            }
        }
    }

    public partial class SwitchCase : AphidExpression, IParentNode
    {

        private System.Collections.Generic.List<AphidExpression> _cases;

        private System.Collections.Generic.List<AphidExpression> _body;

        public SwitchCase(System.Collections.Generic.List<AphidExpression> cases, System.Collections.Generic.List<AphidExpression> body)
        {
            _cases = cases;
            _body = body;
        }

        public System.Collections.Generic.List<AphidExpression> Cases
        {
            get
            {
                return _cases;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.SwitchCase;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Cases.Concat(Body).ToArray();
        }
    }

    public partial class SwitchExpression : AphidExpression, IParentNode
    {

        private AphidExpression _expression;

        private System.Collections.Generic.List<SwitchCase> _cases;

        private System.Collections.Generic.List<AphidExpression> _defaultCase;

        public SwitchExpression(AphidExpression expression, System.Collections.Generic.List<SwitchCase> cases, System.Collections.Generic.List<AphidExpression> defaultCase)
        {
            _expression = expression;
            _cases = cases;
            _defaultCase = defaultCase;
        }

        public AphidExpression Expression
        {
            get
            {
                return _expression;
            }
        }

        public System.Collections.Generic.List<SwitchCase> Cases
        {
            get
            {
                return _cases;
            }
        }

        public System.Collections.Generic.List<AphidExpression> DefaultCase
        {
            get
            {
                return _defaultCase;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.SwitchExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Expression}.Concat(Cases).Concat(DefaultCase).ToArray();
        }
    }

    public partial class TernaryOperatorExpression : AphidExpression, IParentNode
    {

        private AphidTokenType _operator;

        private AphidExpression _firstOperand;

        private AphidExpression _secondOperand;

        private AphidExpression _thirdOperand;

        public TernaryOperatorExpression(AphidTokenType @operator, AphidExpression firstOperand, AphidExpression secondOperand, AphidExpression thirdOperand)
        {
            _operator = @operator;
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
            _thirdOperand = thirdOperand;
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public AphidExpression FirstOperand
        {
            get
            {
                return _firstOperand;
            }
        }

        public AphidExpression SecondOperand
        {
            get
            {
                return _secondOperand;
            }
        }

        public AphidExpression ThirdOperand
        {
            get
            {
                return _thirdOperand;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.TernaryOperatorExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    FirstOperand,
                    SecondOperand,
                    ThirdOperand};
        }
    }

    public partial class ThisExpression : AphidExpression
    {

        public ThisExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ThisExpression;
            }
        }
    }

    public partial class TryExpression : AphidExpression, IParentNode
    {

        private System.Collections.Generic.List<AphidExpression> _tryBody;

        private IdentifierExpression _catchArg;

        private System.Collections.Generic.List<AphidExpression> _catchBody;

        private System.Collections.Generic.List<AphidExpression> _finallyBody;

        public TryExpression(System.Collections.Generic.List<AphidExpression> tryBody, IdentifierExpression catchArg, System.Collections.Generic.List<AphidExpression> catchBody, System.Collections.Generic.List<AphidExpression> finallyBody)
        {
            _tryBody = tryBody;
            _catchArg = catchArg;
            _catchBody = catchBody;
            _finallyBody = finallyBody;
        }

        public System.Collections.Generic.List<AphidExpression> TryBody
        {
            get
            {
                return _tryBody;
            }
        }

        public IdentifierExpression CatchArg
        {
            get
            {
                return _catchArg;
            }
        }

        public System.Collections.Generic.List<AphidExpression> CatchBody
        {
            get
            {
                return _catchBody;
            }
        }

        public System.Collections.Generic.List<AphidExpression> FinallyBody
        {
            get
            {
                return _finallyBody;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.TryExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    CatchArg}.Concat(TryBody).Concat(CatchBody).Concat(FinallyBody).ToArray();
        }
    }

    public partial class WhileExpression : AphidExpression, IParentNode
    {

        private AphidExpression _condition;

        private System.Collections.Generic.List<AphidExpression> _body;

        public WhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body)
        {
            _condition = condition;
            _body = body;
        }

        public AphidExpression Condition
        {
            get
            {
                return _condition;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.WhileExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Condition}.Concat(Body).ToArray();
        }
    }

    public partial class AphidParser
    {

        public System.Collections.Generic.List<AphidExpression> Parse()
        {
            var expressionSequence = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            for (
            ; ((_currentToken.TokenType == AphidTokenType.None)
                        == false);
            )
            {
                expressionSequence.Add(ParseStatement());
            }
            return expressionSequence;
        }

        private AphidExpression ParseStatement()
        {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.ifKeyword))
            {
                var index0000 = _currentToken.Index;
                exp = ParseIfExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index0000;
                    exp.Length = (_currentToken.Index - index0000);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.forKeyword))
                {
                    var index0001 = _currentToken.Index;
                    exp = ParseForExpression();
                    if ((exp.Index < 0))
                    {
                        exp.Index = index0001;
                        exp.Length = (_currentToken.Index - index0001);
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.whileKeyword))
                    {
                        var index0002 = _currentToken.Index;
                        exp = ParseWhileExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index0002;
                            exp.Length = (_currentToken.Index - index0002);
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.doKeyword))
                        {
                            var index0003 = _currentToken.Index;
                            exp = ParseDoWhileExpression();
                            if ((exp.Index < 0))
                            {
                                exp.Index = index0003;
                                exp.Length = (_currentToken.Index - index0003);
                            }
                            if (true)
                            {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.extendKeyword))
                            {
                                var index0004 = _currentToken.Index;
                                exp = ParseExtendExpression();
                                if ((exp.Index < 0))
                                {
                                    exp.Index = index0004;
                                    exp.Length = (_currentToken.Index - index0004);
                                }
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.tryKeyword))
                                {
                                    var index0005 = _currentToken.Index;
                                    exp = ParseTryExpression();
                                    if ((exp.Index < 0))
                                    {
                                        exp.Index = index0005;
                                        exp.Length = (_currentToken.Index - index0005);
                                    }
                                }
                                else
                                {
                                    if ((_currentToken.TokenType == AphidTokenType.switchKeyword))
                                    {
                                        var index0006 = _currentToken.Index;
                                        exp = ParseSwitchExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index0006;
                                            exp.Length = (_currentToken.Index - index0006);
                                        }
                                    }
                                    else
                                    {
                                        var index0007 = _currentToken.Index;
                                        exp = ParseExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index0007;
                                            exp.Length = (_currentToken.Index - index0007);
                                        }
                                        if (true)
                                        {
                                            for (
                                            ; (_currentToken.TokenType == AphidTokenType.Comma);
                                            )
                                            {
                                                NextToken();
                                                exp = new BinaryOperatorExpression(exp, AphidTokenType.Comma, ParseExpression());
                                            }
                                        }
                                        if (true)
                                        {
                                            Match(AphidTokenType.EndOfStatement);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParseSingleStatement()
        {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.ifKeyword))
            {
                var index0008 = _currentToken.Index;
                exp = ParseIfExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index0008;
                    exp.Length = (_currentToken.Index - index0008);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.forKeyword))
                {
                    var index0009 = _currentToken.Index;
                    exp = ParseForExpression();
                    if ((exp.Index < 0))
                    {
                        exp.Index = index0009;
                        exp.Length = (_currentToken.Index - index0009);
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.whileKeyword))
                    {
                        var index000A = _currentToken.Index;
                        exp = ParseWhileExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index000A;
                            exp.Length = (_currentToken.Index - index000A);
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.doKeyword))
                        {
                            var index000B = _currentToken.Index;
                            exp = ParseDoWhileExpression();
                            if ((exp.Index < 0))
                            {
                                exp.Index = index000B;
                                exp.Length = (_currentToken.Index - index000B);
                            }
                            if (false)
                            {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.extendKeyword))
                            {
                                var index000C = _currentToken.Index;
                                exp = ParseExtendExpression();
                                if ((exp.Index < 0))
                                {
                                    exp.Index = index000C;
                                    exp.Length = (_currentToken.Index - index000C);
                                }
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.tryKeyword))
                                {
                                    var index000D = _currentToken.Index;
                                    exp = ParseTryExpression();
                                    if ((exp.Index < 0))
                                    {
                                        exp.Index = index000D;
                                        exp.Length = (_currentToken.Index - index000D);
                                    }
                                }
                                else
                                {
                                    if ((_currentToken.TokenType == AphidTokenType.switchKeyword))
                                    {
                                        var index000E = _currentToken.Index;
                                        exp = ParseSwitchExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index000E;
                                            exp.Length = (_currentToken.Index - index000E);
                                        }
                                    }
                                    else
                                    {
                                        var index000F = _currentToken.Index;
                                        exp = ParseExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index000F;
                                            exp.Length = (_currentToken.Index - index000F);
                                        }
                                        if (false)
                                        {
                                            for (
                                            ; (_currentToken.TokenType == AphidTokenType.Comma);
                                            )
                                            {
                                                NextToken();
                                                exp = new BinaryOperatorExpression(exp, AphidTokenType.Comma, ParseExpression());
                                            }
                                        }
                                        if (false)
                                        {
                                            Match(AphidTokenType.EndOfStatement);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParseExpression()
        {
            return ParseAssignmentExpression();
        }

        private AphidExpression ParseAssignmentExpression()
        {
            var index0010 = _currentToken.Index;
            var operand = ParsePipelineExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0010;
                operand.Length = (_currentToken.Index - index0010);
            }
            for (
            ; (((((((((((_currentToken.TokenType == AphidTokenType.AssignmentOperator)
                        || (_currentToken.TokenType == AphidTokenType.PlusEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.MinusEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.MultiplicationEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.DivisionEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.ModulusEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.BinaryAndEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.OrEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.XorEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.ShiftLeftEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.ShiftRightEqualOperator));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePipelineExpression());
            }
            return operand;
        }

        private AphidExpression ParsePipelineExpression()
        {
            var index0011 = _currentToken.Index;
            var operand = ParseQueryExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0011;
                operand.Length = (_currentToken.Index - index0011);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.PipelineOperator);
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseQueryExpression());
            }
            return operand;
        }

        private AphidExpression ParseQueryExpression()
        {
            var index0012 = _currentToken.Index;
            var exp = ParseRangeExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0012;
                exp.Length = (_currentToken.Index - index0012);
            }
            for (
            ; true;
            )
            {
                if ((((((_currentToken.TokenType == AphidTokenType.AggregateOperator)
                            || (_currentToken.TokenType == AphidTokenType.AnyOperator))
                            || (_currentToken.TokenType == AphidTokenType.SelectManyOperator))
                            || (_currentToken.TokenType == AphidTokenType.SelectOperator))
                            || (_currentToken.TokenType == AphidTokenType.WhereOperator)))
                {
                    var t = _currentToken.TokenType;
                    NextToken();
                    exp = new BinaryOperatorExpression(exp, t, ParseRangeExpression());
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.DistinctOperator))
                    {
                        exp = new UnaryOperatorExpression(_currentToken.TokenType, exp);
                        NextToken();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParseRangeExpression()
        {
            var index0013 = _currentToken.Index;
            var operand = ParseConditionalExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0013;
                operand.Length = (_currentToken.Index - index0013);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.RangeOperator);
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseConditionalExpression());
            }
            return operand;
        }

        private AphidExpression ParseConditionalExpression()
        {
            var index0014 = _currentToken.Index;
            var exp = ParseLogicalExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0014;
                exp.Length = (_currentToken.Index - index0014);
            }
            if ((_currentToken.TokenType == AphidTokenType.ConditionalOperator))
            {
                NextToken();
                var index0015 = _currentToken.Index;
                var trueExpression = ParseExpression();
                if ((trueExpression.Index < 0))
                {
                    trueExpression.Index = index0015;
                    trueExpression.Length = (_currentToken.Index - index0015);
                }
                Match(AphidTokenType.ColonOperator);
                var index0016 = _currentToken.Index;
                var falseExpression = ParseExpression();
                if ((falseExpression.Index < 0))
                {
                    falseExpression.Index = index0016;
                    falseExpression.Length = (_currentToken.Index - index0016);
                }
                return new TernaryOperatorExpression(AphidTokenType.ConditionalOperator, exp, trueExpression, falseExpression);
            }
            else
            {
                return exp;
            }
        }

        private AphidExpression ParseLogicalExpression()
        {
            var index0017 = _currentToken.Index;
            var operand = ParseComparisonExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0017;
                operand.Length = (_currentToken.Index - index0017);
            }
            for (
            ; ((_currentToken.TokenType == AphidTokenType.AndOperator)
                        || (_currentToken.TokenType == AphidTokenType.OrOperator));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseComparisonExpression());
            }
            return operand;
        }

        private AphidExpression ParseComparisonExpression()
        {
            var index0018 = _currentToken.Index;
            var operand = ParsePostfixUnaryOperationExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0018;
                operand.Length = (_currentToken.Index - index0018);
            }
            for (
            ; ((((((_currentToken.TokenType == AphidTokenType.EqualityOperator)
                        || (_currentToken.TokenType == AphidTokenType.NotEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.LessThanOperator))
                        || (_currentToken.TokenType == AphidTokenType.LessThanOrEqualOperator))
                        || (_currentToken.TokenType == AphidTokenType.GreaterThanOperator))
                        || (_currentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePostfixUnaryOperationExpression());
            }
            return operand;
        }

        private AphidExpression ParsePostfixUnaryOperationExpression()
        {
            var index0019 = _currentToken.Index;
            var term = ParseBinaryOrExpression();
            if ((term.Index < 0))
            {
                term.Index = index0019;
                term.Length = (_currentToken.Index - index0019);
            }
            if (((_currentToken.TokenType == AphidTokenType.IncrementOperator)
                        || (_currentToken.TokenType == AphidTokenType.DecrementOperator)))
            {
                var op = _currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(op, term, true);
            }
            else
            {
                return term;
            }
        }

        private AphidExpression ParseBinaryOrExpression()
        {
            var index001A = _currentToken.Index;
            var operand = ParseXorExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001A;
                operand.Length = (_currentToken.Index - index001A);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.BinaryOrOperator);
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseXorExpression());
            }
            return operand;
        }

        private AphidExpression ParseXorExpression()
        {
            var index001B = _currentToken.Index;
            var operand = ParseBinaryAndExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001B;
                operand.Length = (_currentToken.Index - index001B);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.XorOperator);
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseBinaryAndExpression());
            }
            return operand;
        }

        private AphidExpression ParseBinaryAndExpression()
        {
            var index001C = _currentToken.Index;
            var operand = ParseShiftExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001C;
                operand.Length = (_currentToken.Index - index001C);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.BinaryAndOperator);
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseShiftExpression());
            }
            return operand;
        }

        private AphidExpression ParseShiftExpression()
        {
            var index001D = _currentToken.Index;
            var operand = ParseAdditionExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001D;
                operand.Length = (_currentToken.Index - index001D);
            }
            for (
            ; ((_currentToken.TokenType == AphidTokenType.ShiftLeft)
                        || (_currentToken.TokenType == AphidTokenType.ShiftRight));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseAdditionExpression());
            }
            return operand;
        }

        private AphidExpression ParseAdditionExpression()
        {
            var index001E = _currentToken.Index;
            var operand = ParseTermExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001E;
                operand.Length = (_currentToken.Index - index001E);
            }
            for (
            ; ((_currentToken.TokenType == AphidTokenType.AdditionOperator)
                        || (_currentToken.TokenType == AphidTokenType.MinusOperator));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseTermExpression());
            }
            return operand;
        }

        private AphidExpression ParseTermExpression()
        {
            var index001F = _currentToken.Index;
            var operand = ParsePrefixUnaryOperatorExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001F;
                operand.Length = (_currentToken.Index - index001F);
            }
            for (
            ; (((_currentToken.TokenType == AphidTokenType.MultiplicationOperator)
                        || (_currentToken.TokenType == AphidTokenType.DivisionOperator))
                        || (_currentToken.TokenType == AphidTokenType.ModulusOperator));
            )
            {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePrefixUnaryOperatorExpression());
            }
            return operand;
        }

        private AphidExpression ParsePrefixUnaryOperatorExpression()
        {
            if ((((((((_currentToken.TokenType == AphidTokenType.AdditionOperator)
                        || (_currentToken.TokenType == AphidTokenType.MinusOperator))
                        || (_currentToken.TokenType == AphidTokenType.NotOperator))
                        || (_currentToken.TokenType == AphidTokenType.IncrementOperator))
                        || (_currentToken.TokenType == AphidTokenType.DecrementOperator))
                        || (_currentToken.TokenType == AphidTokenType.MultiplicationOperator))
                        || (_currentToken.TokenType == AphidTokenType.ComplementOperator)))
            {
                var t = _currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(t, ParseArrayAccessExpression());
            }
            else
            {
                return ParseArrayAccessExpression();
            }
        }

        private AphidExpression ParseArrayAccessExpression()
        {
            var index0020 = _currentToken.Index;
            var exp = ParseCallExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0020;
                exp.Length = (_currentToken.Index - index0020);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftBracket);
            )
            {
                NextToken();
                var index0021 = _currentToken.Index;
                var key = ParseExpression();
                if ((key.Index < 0))
                {
                    key.Index = index0021;
                    key.Length = (_currentToken.Index - index0021);
                }
                Match(AphidTokenType.RightBracket);
                exp = new ArrayAccessExpression(exp, key);
            }
            return exp;
        }

        private AphidExpression ParseCallExpression()
        {
            var index0022 = _currentToken.Index;
            var function = ParseMemberExpression();
            if ((function.Index < 0))
            {
                function.Index = index0022;
                function.Length = (_currentToken.Index - index0022);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis);
            )
            {
                NextToken();
                if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                {
                    NextToken();
                    function = new CallExpression(function);
                }
                else
                {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }

        private AphidExpression ParseMemberExpression()
        {
            var index0023 = _currentToken.Index;
            var factor = ParseFactorCallExpression();
            if ((factor.Index < 0))
            {
                factor.Index = index0023;
                factor.Length = (_currentToken.Index - index0023);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.MemberOperator);
            )
            {
                NextToken();
                AphidExpression exp = default(AphidExpression);
                if ((_currentToken.TokenType == AphidTokenType.Identifier))
                {
                    exp = new IdentifierExpression(_currentToken.Lexeme);
                    NextToken();
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.String))
                    {
                        var index0024 = _currentToken.Index;
                        exp = ParseStringExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index0024;
                            exp.Length = (_currentToken.Index - index0024);
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
                        {
                            NextToken();
                            exp = new DynamicMemberExpression(ParseExpression());
                            Match(AphidTokenType.RightBrace);
                        }
                        else
                        {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                factor = new BinaryOperatorExpression(factor, AphidTokenType.MemberOperator, exp);
                for (
                ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis);
                )
                {
                    NextToken();
                    if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                    {
                        NextToken();
                        factor = new CallExpression(factor);
                    }
                    else
                    {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        factor = new CallExpression(factor, args);
                    }
                }
                if ((_currentToken.TokenType == AphidTokenType.definedKeyword))
                {
                    NextToken();
                    return new UnaryOperatorExpression(AphidTokenType.definedKeyword, factor, true);
                }
            }
            return factor;
        }

        private AphidExpression ParseFactorCallExpression()
        {
            var index0025 = _currentToken.Index;
            var function = ParseFactorExpression();
            if ((function.Index < 0))
            {
                function.Index = index0025;
                function.Length = (_currentToken.Index - index0025);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis);
            )
            {
                NextToken();
                if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                {
                    NextToken();
                    function = new CallExpression(function);
                }
                else
                {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }

        private AphidExpression ParseStringExpression()
        {
            var exp = new StringExpression(_currentToken.Lexeme);
            NextToken();
            return exp;
        }

        private IdentifierExpression ParseIdentifierExpression()
        {
            var exp = new IdentifierExpression(_currentToken.Lexeme);
            NextToken();
            if ((_currentToken.TokenType == AphidTokenType.Identifier))
            {
                var id = exp;
                var attrs = new System.Collections.Generic.List<IdentifierExpression>();
                for (
                ; true;
                )
                {
                    attrs.Add(id);
                    id = new IdentifierExpression(_currentToken.Lexeme);
                    NextToken();
                    if (((_currentToken.TokenType == AphidTokenType.Identifier)
                                == false))
                    {
                        break;
                    }
                }
                exp = new IdentifierExpression(id.Identifier, attrs);
            }
            return exp;
        }

        private AphidExpression ParseUnaryExpression()
        {
            var t = _currentToken.TokenType;
            NextToken();
            return new UnaryOperatorExpression(t, ParseExpression());
        }

        private AphidExpression ParseCondition()
        {
            Match(AphidTokenType.LeftParenthesis);
            var index0026 = _currentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0))
            {
                condition.Index = index0026;
                condition.Length = (_currentToken.Index - index0026);
            }
            Match(AphidTokenType.RightParenthesis);
            return condition;
        }

        private AphidExpression ParseIfExpression()
        {
            NextToken();
            var index0027 = _currentToken.Index;
            var condition = ParseCondition();
            if ((condition.Index < 0))
            {
                condition.Index = index0027;
                condition.Length = (_currentToken.Index - index0027);
            }
            var body = ParseBlock();
            System.Collections.Generic.List<AphidExpression> elseBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((_currentToken.TokenType == AphidTokenType.elseKeyword))
            {
                NextToken();
                elseBody = ParseBlock();
            }
            return new IfExpression(condition, body, elseBody);
        }

        private System.Collections.Generic.List<AphidExpression> ParseBlock()
        {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
            {
                NextToken();
                for (
                ; ((_currentToken.TokenType == AphidTokenType.RightBrace)
                            == false);
                )
                {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else
            {
                statements.Add(ParseStatement());
            }
            return statements;
        }

        private System.Collections.Generic.List<AphidExpression> ParseSingleBlock()
        {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
            {
                NextToken();
                for (
                ; ((_currentToken.TokenType == AphidTokenType.RightBrace)
                            == false);
                )
                {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else
            {
                statements.Add(ParseSingleStatement());
            }
            return statements;
        }

        private AphidExpression ParseExtendExpression()
        {
            NextToken();
            return new ExtendExpression(ParseIdentifierExpression().Identifier, ParseObjectExpression());
        }

        private AphidExpression ParseForExpression()
        {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var index0028 = _currentToken.Index;
            var initOrElement = ParseExpression();
            if ((initOrElement.Index < 0))
            {
                initOrElement.Index = index0028;
                initOrElement.Length = (_currentToken.Index - index0028);
            }
            if ((_currentToken.TokenType == AphidTokenType.inKeyword))
            {
                NextToken();
                var index0029 = _currentToken.Index;
                var collection = ParseExpression();
                if ((collection.Index < 0))
                {
                    collection.Index = index0029;
                    collection.Length = (_currentToken.Index - index0029);
                }
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForEachExpression(collection, initOrElement, body);
            }
            else
            {
                Match(AphidTokenType.EndOfStatement);
                var index002A = _currentToken.Index;
                var condition = ParseExpression();
                if ((condition.Index < 0))
                {
                    condition.Index = index002A;
                    condition.Length = (_currentToken.Index - index002A);
                }
                Match(AphidTokenType.EndOfStatement);
                var index002B = _currentToken.Index;
                var afterthought = ParseExpression();
                if ((afterthought.Index < 0))
                {
                    afterthought.Index = index002B;
                    afterthought.Length = (_currentToken.Index - index002B);
                }
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForExpression(initOrElement, condition, afterthought, body);
            }
        }

        private AphidExpression ParseWhileExpression()
        {
            NextToken();
            return new WhileExpression(ParseCondition(), ParseBlock());
        }

        private AphidExpression ParseDoWhileExpression()
        {
            NextToken();
            var body = ParseBlock();
            Match(AphidTokenType.whileKeyword);
            Match(AphidTokenType.LeftParenthesis);
            var index002C = _currentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0))
            {
                condition.Index = index002C;
                condition.Length = (_currentToken.Index - index002C);
            }
            Match(AphidTokenType.RightParenthesis);
            return new DoWhileExpression(condition, body);
        }

        private System.Collections.Generic.List<AphidExpression> ParseTuple()
        {
            var tuple = new System.Collections.Generic.List<AphidExpression>();
            for (
            ; true;
            )
            {
                tuple.Add(ParseExpression());
                if ((_currentToken.TokenType == AphidTokenType.Comma))
                {
                    NextToken();
                }
                else
                {
                    return tuple;
                }
            }
        }

        private AphidExpression ParseLoadScriptExpression()
        {
            NextToken();
            return new LoadScriptExpression(ParseExpression());
        }

        private AphidExpression ParseLoadLibraryExpression()
        {
            NextToken();
            return new LoadLibraryExpression(ParseExpression());
        }

        private AphidExpression ParseTryExpression()
        {
            NextToken();
            var tryBody = ParseBlock();
            IdentifierExpression catchArg = default(IdentifierExpression);
            System.Collections.Generic.List<AphidExpression> catchBody = default(System.Collections.Generic.List<AphidExpression>);
            System.Collections.Generic.List<AphidExpression> finallyBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((_currentToken.TokenType == AphidTokenType.catchKeyword))
            {
                NextToken();
                Match(AphidTokenType.LeftParenthesis);
                var index002D = _currentToken.Index;
                catchArg = ParseIdentifierExpression();
                if ((catchArg.Index < 0))
                {
                    catchArg.Index = index002D;
                    catchArg.Length = (_currentToken.Index - index002D);
                }
                Match(AphidTokenType.RightParenthesis);
                catchBody = ParseBlock();
                if ((_currentToken.TokenType == AphidTokenType.finallyKeyword))
                {
                    NextToken();
                    finallyBody = ParseBlock();
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.finallyKeyword))
                {
                    NextToken();
                    finallyBody = ParseBlock();
                }
                else
                {
                    throw new AphidParserException(_currentToken);
                }
            }
            return new TryExpression(tryBody, catchArg, catchBody, finallyBody);
        }

        private AphidExpression ParseSwitchExpression()
        {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var index002E = _currentToken.Index;
            var exp = ParseExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index002E;
                exp.Length = (_currentToken.Index - index002E);
            }
            Match(AphidTokenType.RightParenthesis);
            Match(AphidTokenType.LeftBrace);
            var cases = new System.Collections.Generic.List<SwitchCase>();
            System.Collections.Generic.List<AphidExpression> defaultCase = default(System.Collections.Generic.List<AphidExpression>);
            for (
            ; ((_currentToken.TokenType == AphidTokenType.RightBrace)
                        == false);
            )
            {
                if (((_currentToken.TokenType == AphidTokenType.defaultKeyword)
                            == false))
                {
                    var caseTuple = ParseTuple();
                    Match(AphidTokenType.ColonOperator);
                    var block = ParseBlock();
                    cases.Add(new SwitchCase(caseTuple, block));
                }
                else
                {
                    NextToken();
                    Match(AphidTokenType.ColonOperator);
                    defaultCase = ParseBlock();
                }
            }
            NextToken();
            return new SwitchExpression(exp, cases, defaultCase);
        }

        private ObjectExpression ParseObjectExpression()
        {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<BinaryOperatorExpression>();
            for (
            ; inNode;
            )
            {
                if ((_currentToken.TokenType == AphidTokenType.Identifier))
                {
                    childNodes.Add(ParseKeyValuePairExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma))
                    {
                        NextToken();
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.RightBrace))
                        {
                            NextToken();
                            inNode = false;
                        }
                        else
                        {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.RightBrace))
                    {
                        NextToken();
                        inNode = false;
                    }
                    else
                    {
                        throw new AphidParserException(_currentToken);
                    }
                }
            }
            return new ObjectExpression(childNodes);
        }

        private AphidExpression ParseArrayExpression()
        {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<AphidExpression>();
            if (((_currentToken.TokenType == AphidTokenType.RightBracket)
                        == false))
            {
                for (
                ; inNode;
                )
                {
                    childNodes.Add(ParseExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma))
                    {
                        NextToken();
                        if ((_currentToken.TokenType == AphidTokenType.RightBracket))
                        {
                            NextToken();
                            inNode = false;
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.RightBracket))
                        {
                            NextToken();
                            inNode = false;
                        }
                        else
                        {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
            }
            else
            {
                NextToken();
            }
            return new ArrayExpression(childNodes);
        }

        private BinaryOperatorExpression ParseKeyValuePairExpression()
        {
            var index002F = _currentToken.Index;
            var id = ParseIdentifierExpression();
            if ((id.Index < 0))
            {
                id.Index = index002F;
                id.Length = (_currentToken.Index - index002F);
            }
            AphidExpression exp = default(AphidExpression);
            if (((_currentToken.TokenType == AphidTokenType.ColonOperator)
                        || (_currentToken.TokenType == AphidTokenType.AssignmentOperator)))
            {
                NextToken();
                var index0030 = _currentToken.Index;
                exp = ParseExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index0030;
                    exp.Length = (_currentToken.Index - index0030);
                }
            }
            else
            {
                exp = id;
            }
            return new BinaryOperatorExpression(id, AphidTokenType.ColonOperator, exp);
        }

        private AphidExpression ParseNumberExpression()
        {
            var exp = new NumberExpression(decimal.Parse(_currentToken.Lexeme));
            NextToken();
            return exp;
        }

        private AphidExpression ParseFunctionExpression()
        {
            AphidExpression exp = default(AphidExpression);
            var body = new System.Collections.Generic.List<AphidExpression>();
            var args = new System.Collections.Generic.List<AphidExpression>();
            AphidExpression argExp = default(AphidExpression);
            NextToken();
            if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
            {
                NextToken();
                if (((_currentToken.TokenType == AphidTokenType.RightParenthesis)
                            == false))
                {
                    for (
                    ; true;
                    )
                    {
                        if ((_currentToken.TokenType == AphidTokenType.Identifier))
                        {
                            var index0031 = _currentToken.Index;
                            var id = ParseIdentifierExpression();
                            if ((id.Index < 0))
                            {
                                id.Index = index0031;
                                id.Length = (_currentToken.Index - index0031);
                            }
                            argExp = id;
                            if ((_currentToken.TokenType == AphidTokenType.AssignmentOperator))
                            {
                                var op = _currentToken.TokenType;
                                NextToken();
                                argExp = new BinaryOperatorExpression(id, op, ParseExpression());
                            }
                            args.Add(argExp);
                            if ((_currentToken.TokenType == AphidTokenType.Comma))
                            {
                                NextToken();
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                Match(AphidTokenType.RightParenthesis);
                var isSingleLine = (_currentToken.TokenType != AphidTokenType.LeftBrace);
                var block = ParseSingleBlock();
                if ((isSingleLine && UseImplicitReturns))
                {
                    body.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, block[0]));
                }
                else
                {
                    body = block;
                }
                exp = new FunctionExpression(args, body);
            }
            else
            {
                exp = new PartialFunctionExpression(ParseCallExpression());
            }
            return exp;
        }

        private AphidExpression ParsePatternMatchingExpression()
        {
            NextToken();
            var patterns = new System.Collections.Generic.List<PatternExpression>();
            Match(AphidTokenType.LeftParenthesis);
            var index0032 = _currentToken.Index;
            var testExp = ParseExpression();
            if ((testExp.Index < 0))
            {
                testExp.Index = index0032;
                testExp.Length = (_currentToken.Index - index0032);
            }
            Match(AphidTokenType.RightParenthesis);
            for (
            ; true;
            )
            {
                var tuple = new System.Collections.Generic.List<AphidExpression>();
                for (
                ; true;
                )
                {
                    tuple.Add(ParseExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma))
                    {
                        NextToken();
                    }
                    else
                    {
                        break;
                    }
                }
                AphidExpression valueExp = default(AphidExpression);
                if ((_currentToken.TokenType == AphidTokenType.ColonOperator))
                {
                    NextToken();
                    var index0033 = _currentToken.Index;
                    valueExp = ParseExpression();
                    if ((valueExp.Index < 0))
                    {
                        valueExp.Index = index0033;
                        valueExp.Length = (_currentToken.Index - index0033);
                    }
                    patterns.Add(new PatternExpression(valueExp, tuple));
                }
                else
                {
                    if ((tuple.Count != 1))
                    {
                        throw new AphidParserException(_currentToken);
                    }
                    patterns.Add(new PatternExpression(tuple[0]));
                }
                if ((_currentToken.TokenType == AphidTokenType.Comma))
                {
                    NextToken();
                }
                else
                {
                    break;
                }
            }
            return new PatternMatchingExpression(testExp, patterns);
        }

        private AphidExpression ParseFactorExpression()
        {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
            {
                var index0034 = _currentToken.Index;
                exp = ParseObjectExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index0034;
                    exp.Length = (_currentToken.Index - index0034);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.LeftBracket))
                {
                    var index0035 = _currentToken.Index;
                    exp = ParseArrayExpression();
                    if ((exp.Index < 0))
                    {
                        exp.Index = index0035;
                        exp.Length = (_currentToken.Index - index0035);
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
                    {
                        NextToken();
                        var index0036 = _currentToken.Index;
                        exp = ParseExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index0036;
                            exp.Length = (_currentToken.Index - index0036);
                        }
                        Match(AphidTokenType.RightParenthesis);
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.String))
                        {
                            var index0037 = _currentToken.Index;
                            exp = ParseStringExpression();
                            if ((exp.Index < 0))
                            {
                                exp.Index = index0037;
                                exp.Length = (_currentToken.Index - index0037);
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.Number))
                            {
                                var index0038 = _currentToken.Index;
                                exp = ParseNumberExpression();
                                if ((exp.Index < 0))
                                {
                                    exp.Index = index0038;
                                    exp.Length = (_currentToken.Index - index0038);
                                }
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.Identifier))
                                {
                                    var index0039 = _currentToken.Index;
                                    exp = ParseIdentifierExpression();
                                    if ((exp.Index < 0))
                                    {
                                        exp.Index = index0039;
                                        exp.Length = (_currentToken.Index - index0039);
                                    }
                                    if ((_currentToken.TokenType == AphidTokenType.definedKeyword))
                                    {
                                        NextToken();
                                        exp = new UnaryOperatorExpression(AphidTokenType.definedKeyword, exp, true);
                                    }
                                }
                                else
                                {
                                    if ((_currentToken.TokenType == AphidTokenType.functionOperator))
                                    {
                                        var index003A = _currentToken.Index;
                                        exp = ParseFunctionExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index003A;
                                            exp.Length = (_currentToken.Index - index003A);
                                        }
                                    }
                                    else
                                    {
                                        if (((_currentToken.TokenType == AphidTokenType.retKeyword)
                                                    || (_currentToken.TokenType == AphidTokenType.deleteKeyword)))
                                        {
                                            var index003B = _currentToken.Index;
                                            exp = ParseUnaryExpression();
                                            if ((exp.Index < 0))
                                            {
                                                exp.Index = index003B;
                                                exp.Length = (_currentToken.Index - index003B);
                                            }
                                        }
                                        else
                                        {
                                            if ((_currentToken.TokenType == AphidTokenType.trueKeyword))
                                            {
                                                exp = new BooleanExpression(true);
                                                NextToken();
                                            }
                                            else
                                            {
                                                if ((_currentToken.TokenType == AphidTokenType.falseKeyword))
                                                {
                                                    exp = new BooleanExpression(false);
                                                    NextToken();
                                                }
                                                else
                                                {
                                                    if ((_currentToken.TokenType == AphidTokenType.thisKeyword))
                                                    {
                                                        exp = new ThisExpression();
                                                        NextToken();
                                                    }
                                                    else
                                                    {
                                                        if ((_currentToken.TokenType == AphidTokenType.LoadScriptOperator))
                                                        {
                                                            var index003C = _currentToken.Index;
                                                            exp = ParseLoadScriptExpression();
                                                            if ((exp.Index < 0))
                                                            {
                                                                exp.Index = index003C;
                                                                exp.Length = (_currentToken.Index - index003C);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if ((_currentToken.TokenType == AphidTokenType.LoadLibraryOperator))
                                                            {
                                                                var index003D = _currentToken.Index;
                                                                exp = ParseLoadLibraryExpression();
                                                                if ((exp.Index < 0))
                                                                {
                                                                    exp.Index = index003D;
                                                                    exp.Length = (_currentToken.Index - index003D);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if ((_currentToken.TokenType == AphidTokenType.nullKeyword))
                                                                {
                                                                    exp = new NullExpression();
                                                                    NextToken();
                                                                }
                                                                else
                                                                {
                                                                    if ((_currentToken.TokenType == AphidTokenType.breakKeyword))
                                                                    {
                                                                        exp = new BreakExpression();
                                                                        NextToken();
                                                                    }
                                                                    else
                                                                    {
                                                                        if ((_currentToken.TokenType == AphidTokenType.HexNumber))
                                                                        {
                                                                            exp = new NumberExpression(System.Convert.ToInt64(_currentToken.Lexeme.Substring(2), 16));
                                                                            NextToken();
                                                                        }
                                                                        else
                                                                        {
                                                                            if ((_currentToken.TokenType == AphidTokenType.BinaryNumber))
                                                                            {
                                                                                exp = new NumberExpression(BinaryNumber.Parse(_currentToken.Lexeme.Substring(2)));
                                                                                NextToken();
                                                                            }
                                                                            else
                                                                            {
                                                                                if ((_currentToken.TokenType == AphidTokenType.PatternMatchingOperator))
                                                                                {
                                                                                    var index003E = _currentToken.Index;
                                                                                    exp = ParsePatternMatchingExpression();
                                                                                    if ((exp.Index < 0))
                                                                                    {
                                                                                        exp.Index = index003E;
                                                                                        exp.Length = (_currentToken.Index - index003E);
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    throw new AphidParserException(_currentToken);
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return exp;
        }
    }
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by llex.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 0162

namespace Components.Aphid.Lexer
{
    using System;
    using System.Collections.Generic;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public enum AphidTokenType : short
    {
        None,
        AdditionOperator,
        AggregateOperator,
        AndOperator,
        AnyOperator,
        AssignmentOperator,
        BinaryAndEqualOperator,
        BinaryAndOperator,
        BinaryNumber,
        BinaryOrOperator,
        breakKeyword,
        catchKeyword,
        ColonOperator,
        Comma,
        Comment,
        ComplementOperator,
        ConditionalOperator,
        DecrementOperator,
        defaultKeyword,
        definedKeyword,
        deleteKeyword,
        DistinctOperator,
        DivisionEqualOperator,
        DivisionOperator,
        doKeyword,
        elseKeyword,
        EndOfFile,
        EndOfStatement,
        EqualityOperator,
        extendKeyword,
        falseKeyword,
        finallyKeyword,
        forKeyword,
        functionOperator,
        GreaterThanOperator,
        GreaterThanOrEqualOperator,
        HexNumber,
        Identifier,
        ifKeyword,
        IncrementOperator,
        inKeyword,
        LeftBrace,
        LeftBracket,
        LeftParenthesis,
        LessThanOperator,
        LessThanOrEqualOperator,
        LoadLibraryOperator,
        LoadScriptOperator,
        MemberOperator,
        MinusEqualOperator,
        MinusOperator,
        ModulusEqualOperator,
        ModulusOperator,
        MultiplicationEqualOperator,
        MultiplicationOperator,
        NotEqualOperator,
        NotOperator,
        nullKeyword,
        Number,
        OrEqualOperator,
        OrOperator,
        PatternMatchingOperator,
        PipelineOperator,
        PlusEqualOperator,
        RangeOperator,
        retKeyword,
        RightBrace,
        RightBracket,
        RightParenthesis,
        SelectManyOperator,
        SelectOperator,
        ShiftLeft,
        ShiftLeftEqualOperator,
        ShiftRight,
        ShiftRightEqualOperator,
        String,
        switchKeyword,
        thisKeyword,
        trueKeyword,
        tryKeyword,
        Unknown,
        WhereOperator,
        whileKeyword,
        WhiteSpace,
        XorEqualOperator,
        XorOperator
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public struct AphidToken
    {
        public AphidTokenType TokenType;
        public string Lexeme;
        public int Index;

        public AphidToken(AphidTokenType tokenType, string lexeme, int index)
        {
            TokenType = tokenType;
            Lexeme = lexeme;
            Index = index;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}: {2}", Index, TokenType, Lexeme);
        }

        public bool IsKeyword()
        {
            return TokenType == AphidTokenType.trueKeyword ||
                TokenType == AphidTokenType.falseKeyword ||
                TokenType == AphidTokenType.nullKeyword ||
                TokenType == AphidTokenType.ifKeyword ||
                TokenType == AphidTokenType.elseKeyword ||
                TokenType == AphidTokenType.switchKeyword ||
                TokenType == AphidTokenType.defaultKeyword ||
                TokenType == AphidTokenType.whileKeyword ||
                TokenType == AphidTokenType.doKeyword ||
                TokenType == AphidTokenType.forKeyword ||
                TokenType == AphidTokenType.inKeyword ||
                TokenType == AphidTokenType.breakKeyword ||
                TokenType == AphidTokenType.retKeyword ||
                TokenType == AphidTokenType.thisKeyword ||
                TokenType == AphidTokenType.definedKeyword ||
                TokenType == AphidTokenType.deleteKeyword ||
                TokenType == AphidTokenType.extendKeyword ||
                TokenType == AphidTokenType.tryKeyword ||
                TokenType == AphidTokenType.catchKeyword ||
                TokenType == AphidTokenType.finallyKeyword;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("llex", "1")]
    public partial class AphidLexer
    {
        private string text = "";

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                lastIndex = text.Length - 1;
            }
        }

        int lastIndex = -1;

        int charIndex = -1;

        int mode = 0;

        int state = 0;

        char currentChar = (char)0;

        public AphidLexer()
        {
        }

        public AphidLexer(string text)
        {
            Text = text;
        }

        bool NextChar()
        {
            if (charIndex < lastIndex)
            {
                currentChar = text[++charIndex];
                return true;
            }

            return false;
        }

        private AphidTokenType GetToken()
        {

            if (mode == 0)
            {
                if (charIndex < lastIndex)
                {
                    currentChar = text[++charIndex];

                    switch (currentChar)
                    {
                        case '#':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '#':

                                        return AphidTokenType.LoadLibraryOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.LoadScriptOperator;

                        case ',':

                            return AphidTokenType.Comma;

                        case ':':

                            return AphidTokenType.ColonOperator;

                        case '@':

                            return AphidTokenType.functionOperator;

                        case '?':

                            return AphidTokenType.ConditionalOperator;

                        case '.':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '.':

                                        return AphidTokenType.RangeOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.MemberOperator;

                        case '(':

                            return AphidTokenType.LeftParenthesis;

                        case ')':

                            return AphidTokenType.RightParenthesis;

                        case '[':

                            return AphidTokenType.LeftBracket;

                        case ']':

                            return AphidTokenType.RightBracket;

                        case '{':

                            return AphidTokenType.LeftBrace;

                        case '}':

                            return AphidTokenType.RightBrace;

                        case '=':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.EqualityOperator;

                                    case '?':

                                        return AphidTokenType.AnyOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.AssignmentOperator;

                        case '-':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.MinusEqualOperator;

                                    case '-':

                                        return AphidTokenType.DecrementOperator;

                                    case '<':

                                        return AphidTokenType.SelectManyOperator;

                                    case '>':

                                        return AphidTokenType.SelectOperator;

                                    case '?':

                                        return AphidTokenType.WhereOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.MinusOperator;

                        case '+':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.PlusEqualOperator;

                                    case '+':

                                        return AphidTokenType.IncrementOperator;

                                    case '>':

                                        return AphidTokenType.AggregateOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.AdditionOperator;

                        case '*':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.MultiplicationEqualOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.MultiplicationOperator;

                        case '/':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.DivisionEqualOperator;

                                    case '/':


                                        state = 0;
                                        while (NextChar())
                                        {
                                            if (currentChar == '\r' || currentChar == '\n')
                                            {
                                                charIndex--;

                                                return AphidTokenType.Comment;
                                            }
                                            else if (currentChar == '?')
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1 && currentChar == '>')
                                            {
                                                charIndex -= 2;

                                                return AphidTokenType.Comment;
                                            }
                                            else
                                            {
                                                state = 0;
                                            }
                                        }

                                        return AphidTokenType.Comment;

                                        break;

                                    case '*':


                                        state = 0;

                                        while (NextChar())
                                        {
                                            if ((state == 0 || state == 1) && currentChar == '*')
                                                state = 1;
                                            else if (state == 1 && currentChar == '/')
                                                return AphidTokenType.Comment;
                                            else
                                                state = 0;
                                        }

                                        return AphidTokenType.Comment;

                                        break;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.DivisionOperator;

                        case '%':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.ModulusEqualOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.ModulusOperator;

                        case '&':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.BinaryAndEqualOperator;

                                    case '&':

                                        return AphidTokenType.AndOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.BinaryAndOperator;

                        case '|':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.OrEqualOperator;

                                    case '|':

                                        return AphidTokenType.OrOperator;

                                    case '>':

                                        return AphidTokenType.PipelineOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.BinaryOrOperator;

                        case '^':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.XorEqualOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.XorOperator;

                        case '<':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '<':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case '=':

                                                    return AphidTokenType.ShiftLeftEqualOperator;

                                            }

                                            charIndex--;
                                        }
                                        return AphidTokenType.ShiftLeft;

                                    case '>':

                                        return AphidTokenType.NotEqualOperator;

                                    case '=':

                                        return AphidTokenType.LessThanOrEqualOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.LessThanOperator;

                        case '>':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '>':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case '=':

                                                    return AphidTokenType.ShiftRightEqualOperator;

                                            }

                                            charIndex--;
                                        }
                                        return AphidTokenType.ShiftRight;

                                    case '=':

                                        return AphidTokenType.GreaterThanOrEqualOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.GreaterThanOperator;

                        case '~':

                            return AphidTokenType.ComplementOperator;

                        case '!':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '=':

                                        return AphidTokenType.NotEqualOperator;

                                    case '?':

                                        return AphidTokenType.DistinctOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.NotOperator;

                        case '$':

                            return AphidTokenType.PatternMatchingOperator;

                        case ';':

                            return AphidTokenType.EndOfStatement;

                        case '\x0d':

                            return AphidTokenType.WhiteSpace;

                        case '\x0a':

                            return AphidTokenType.WhiteSpace;

                        case '\x09':

                            return AphidTokenType.WhiteSpace;

                        case '\x0b':

                            return AphidTokenType.WhiteSpace;

                        case ' ':

                            return AphidTokenType.WhiteSpace;

                        case '0':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'x':


                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Unknown;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if ((state == 0 || state == 1) &&
                                                ((currentChar > 47 && currentChar < 58) ||
                                                (64 < currentChar && currentChar < 71) ||
                                                (96 < currentChar && currentChar < 103)))
                                                state = 1;
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.HexNumber;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Unknown;
                                            }
                                        }
                                        while (NextChar());

                                        return AphidTokenType.HexNumber;

                                        break;

                                    case 'b':


                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Unknown;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if ((state == 0 || state == 1) && (currentChar == '0' || currentChar == '1'))
                                                state = 1;
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.BinaryNumber;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Unknown;
                                            }
                                        }
                                        while (NextChar());

                                        return AphidTokenType.BinaryNumber;

                                        break;

                                }

                                charIndex--;
                            }

                            NextChar();
                            state = 1;

                            do
                            {
                                if ((state == 0 || state == 1) && currentChar > 47 && currentChar < 58)
                                    state = 1;
                                else if (state == 1 && currentChar == '.')
                                    state = 2;
                                else if ((state == 2 || state == 3) && currentChar > 47 && currentChar < 58)
                                    state = 3;
                                else if ((state == 1 || state == 3) && (currentChar == 'E' || currentChar == 'e'))
                                {
                                    state = 4;
                                }
                                else if (state == 4 && (currentChar == '-' || currentChar == '+'))
                                {
                                    state = 6;
                                }
                                else if (state == 4 && currentChar > 47 && currentChar < 58)
                                {
                                    state = 5;
                                }
                                else if (state == 5 && currentChar > 47 && currentChar < 58)
                                {
                                    continue;
                                }
                                else if (state == 6)
                                {
                                    if (currentChar > 47 && currentChar < 58)
                                    {
                                        state = 5;
                                        continue;
                                    }
                                    else
                                    {
                                        return AphidTokenType.Unknown;
                                    }
                                }
                                else if (state == 1 || state == 3 || state == 5)
                                {
                                    charIndex--;

                                    return AphidTokenType.Number;
                                }
                                else if (state == 2)
                                {
                                    charIndex -= 2;

                                    return AphidTokenType.Number;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            while (NextChar());

                            return AphidTokenType.Number;

                            break;

                        case '"':


                            bool escaped = false;

                            while (NextChar())
                            {
                                if (!escaped && currentChar == '"')
                                    return AphidTokenType.String;

                                escaped = !escaped && currentChar == '\\';
                            }

                            return AphidTokenType.String;

                            break;

                        case '\'':


                            escaped = false;

                            while (NextChar())
                            {
                                if (!escaped && currentChar == '\'')
                                    return AphidTokenType.String;

                                escaped = !escaped && currentChar == '\\';
                            }

                            return AphidTokenType.String;

                            break;

                        case 't':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'r':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'u':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'e':


                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.trueKeyword;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.trueKeyword;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                                case 'y':


                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.tryKeyword;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.tryKeyword;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'h':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'i':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 's':


                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.thisKeyword;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.thisKeyword;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'f':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'a':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'l':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 's':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'e':


                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.falseKeyword;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.falseKeyword;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'o':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'r':


                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.forKeyword;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.forKeyword;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'i':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'n':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'a':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'l':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'l':
                                                                                        if (charIndex < lastIndex)
                                                                                        {
                                                                                            currentChar = text[++charIndex];

                                                                                            switch (currentChar)
                                                                                            {
                                                                                                case 'y':


                                                                                                    if (!NextChar())
                                                                                                    {
                                                                                                        return AphidTokenType.finallyKeyword;
                                                                                                    }

                                                                                                    state = 0;

                                                                                                    do
                                                                                                    {
                                                                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                                                                            currentChar == '_' ||
                                                                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                                        {
                                                                                                            state = 1;
                                                                                                        }
                                                                                                        else if (state == 1)
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.Identifier;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.finallyKeyword;
                                                                                                        }
                                                                                                    }
                                                                                                    while (NextChar());

                                                                                                    if (state == 1)
                                                                                                    {
                                                                                                        return AphidTokenType.Identifier;
                                                                                                    }

                                                                                                    break;

                                                                                            }

                                                                                            charIndex--;
                                                                                        }

                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'n':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'u':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'l':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'l':


                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.nullKeyword;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.nullKeyword;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'i':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'f':


                                        if (!NextChar())
                                        {
                                            return AphidTokenType.ifKeyword;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.ifKeyword;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'n':


                                        if (!NextChar())
                                        {
                                            return AphidTokenType.inKeyword;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.inKeyword;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'e':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'l':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 's':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'e':


                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.elseKeyword;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.elseKeyword;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'x':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 't':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'e':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'n':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'd':


                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.extendKeyword;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.extendKeyword;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 's':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'w':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'i':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 't':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'c':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'h':


                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.switchKeyword;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.switchKeyword;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'd':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'e':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'f':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'a':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'u':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'l':
                                                                                        if (charIndex < lastIndex)
                                                                                        {
                                                                                            currentChar = text[++charIndex];

                                                                                            switch (currentChar)
                                                                                            {
                                                                                                case 't':


                                                                                                    if (!NextChar())
                                                                                                    {
                                                                                                        return AphidTokenType.defaultKeyword;
                                                                                                    }

                                                                                                    state = 0;

                                                                                                    do
                                                                                                    {
                                                                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                                                                            currentChar == '_' ||
                                                                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                                        {
                                                                                                            state = 1;
                                                                                                        }
                                                                                                        else if (state == 1)
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.Identifier;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.defaultKeyword;
                                                                                                        }
                                                                                                    }
                                                                                                    while (NextChar());

                                                                                                    if (state == 1)
                                                                                                    {
                                                                                                        return AphidTokenType.Identifier;
                                                                                                    }

                                                                                                    break;

                                                                                            }

                                                                                            charIndex--;
                                                                                        }

                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                            case 'i':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'n':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'e':
                                                                                        if (charIndex < lastIndex)
                                                                                        {
                                                                                            currentChar = text[++charIndex];

                                                                                            switch (currentChar)
                                                                                            {
                                                                                                case 'd':


                                                                                                    if (!NextChar())
                                                                                                    {
                                                                                                        return AphidTokenType.definedKeyword;
                                                                                                    }

                                                                                                    state = 0;

                                                                                                    do
                                                                                                    {
                                                                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                                                                            currentChar == '_' ||
                                                                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                                        {
                                                                                                            state = 1;
                                                                                                        }
                                                                                                        else if (state == 1)
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.Identifier;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            charIndex--;

                                                                                                            return AphidTokenType.definedKeyword;
                                                                                                        }
                                                                                                    }
                                                                                                    while (NextChar());

                                                                                                    if (state == 1)
                                                                                                    {
                                                                                                        return AphidTokenType.Identifier;
                                                                                                    }

                                                                                                    break;

                                                                                            }

                                                                                            charIndex--;
                                                                                        }

                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                                case 'l':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'e':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 't':
                                                                            if (charIndex < lastIndex)
                                                                            {
                                                                                currentChar = text[++charIndex];

                                                                                switch (currentChar)
                                                                                {
                                                                                    case 'e':


                                                                                        if (!NextChar())
                                                                                        {
                                                                                            return AphidTokenType.deleteKeyword;
                                                                                        }

                                                                                        state = 0;

                                                                                        do
                                                                                        {
                                                                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                                (currentChar >= '0' && currentChar <= '9') ||
                                                                                                currentChar == '_' ||
                                                                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                            {
                                                                                                state = 1;
                                                                                            }
                                                                                            else if (state == 1)
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.Identifier;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                charIndex--;

                                                                                                return AphidTokenType.deleteKeyword;
                                                                                            }
                                                                                        }
                                                                                        while (NextChar());

                                                                                        if (state == 1)
                                                                                        {
                                                                                            return AphidTokenType.Identifier;
                                                                                        }

                                                                                        break;

                                                                                }

                                                                                charIndex--;
                                                                            }

                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                    case 'o':


                                        if (!NextChar())
                                        {
                                            return AphidTokenType.doKeyword;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.doKeyword;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'w':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'h':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'i':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'l':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'e':


                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.whileKeyword;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.whileKeyword;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'b':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'r':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'e':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'a':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'k':


                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.breakKeyword;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.breakKeyword;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'r':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'e':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 't':


                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.retKeyword;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.retKeyword;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        case 'c':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'a':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 't':
                                                    if (charIndex < lastIndex)
                                                    {
                                                        currentChar = text[++charIndex];

                                                        switch (currentChar)
                                                        {
                                                            case 'c':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 'h':


                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.catchKeyword;
                                                                            }

                                                                            state = 0;

                                                                            do
                                                                            {
                                                                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                                    (currentChar >= '0' && currentChar <= '9') ||
                                                                                    currentChar == '_' ||
                                                                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                                {
                                                                                    state = 1;
                                                                                }
                                                                                else if (state == 1)
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.Identifier;
                                                                                }
                                                                                else
                                                                                {
                                                                                    charIndex--;

                                                                                    return AphidTokenType.catchKeyword;
                                                                                }
                                                                            }
                                                                            while (NextChar());

                                                                            if (state == 1)
                                                                            {
                                                                                return AphidTokenType.Identifier;
                                                                            }

                                                                            break;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                state = 0;

                                                                do
                                                                {
                                                                    if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                                        (currentChar >= 'A' && currentChar <= 'Z') ||
                                                                        (currentChar >= '0' && currentChar <= '9') ||
                                                                        currentChar == '_' ||
                                                                        (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                                    {
                                                                        state = 1;
                                                                    }
                                                                    else if (state == 1)
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                    else
                                                                    {
                                                                        charIndex--;

                                                                        return AphidTokenType.Identifier;
                                                                    }
                                                                }
                                                                while (NextChar());

                                                                if (state == 1)
                                                                {
                                                                    return AphidTokenType.Identifier;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    state = 0;

                                                    do
                                                    {
                                                        if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                            (currentChar >= 'A' && currentChar <= 'Z') ||
                                                            (currentChar >= '0' && currentChar <= '9') ||
                                                            currentChar == '_' ||
                                                            (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                                        {
                                                            state = 1;
                                                        }
                                                        else if (state == 1)
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                        else
                                                        {
                                                            charIndex--;

                                                            return AphidTokenType.Identifier;
                                                        }
                                                    }
                                                    while (NextChar());

                                                    if (state == 1)
                                                    {
                                                        return AphidTokenType.Identifier;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        if (!NextChar())
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        state = 0;

                                        do
                                        {
                                            if (((currentChar >= 'a' && currentChar <= 'z') ||
                                                (currentChar >= 'A' && currentChar <= 'Z') ||
                                                (currentChar >= '0' && currentChar <= '9') ||
                                                currentChar == '_' ||
                                                (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                            {
                                                state = 1;
                                            }
                                            else if (state == 1)
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                            else
                                            {
                                                charIndex--;

                                                return AphidTokenType.Identifier;
                                            }
                                        }
                                        while (NextChar());

                                        if (state == 1)
                                        {
                                            return AphidTokenType.Identifier;
                                        }

                                        break;

                                }

                                charIndex--;
                            }

                            if (!NextChar())
                            {
                                return AphidTokenType.Identifier;
                            }

                            state = 0;

                            do
                            {
                                if (((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                {
                                    state = 1;
                                }
                                else if (state == 1)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                            }
                            while (NextChar());

                            if (state == 1)
                            {
                                return AphidTokenType.Identifier;
                            }

                            break;

                        default:

                            state = 0;

                            do
                            {
                                if (state == 0 &&
                                    ((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                    state = 1;
                                else if (state == 1 &&
                                    ((currentChar >= 'a' && currentChar <= 'z') ||
                                    (currentChar >= 'A' && currentChar <= 'Z') ||
                                    (currentChar >= '0' && currentChar <= '9') ||
                                    currentChar == '_' ||
                                    (currentChar >= '\u007f' && currentChar <= '\uffff')))
                                    state = 1;
                                else if (state == 1 || state == 2)
                                {
                                    charIndex--;

                                    return AphidTokenType.Identifier;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            while (NextChar());

                            if (state == 1 || state == 2) // EOF Id
                            {
                                return AphidTokenType.Identifier;
                            }


                            state = 0;

                            do
                            {
                                if ((state == 0 || state == 1) && currentChar > 47 && currentChar < 58)
                                    state = 1;
                                else if (state == 1 && currentChar == '.')
                                    state = 2;
                                else if ((state == 2 || state == 3) && currentChar > 47 && currentChar < 58)
                                    state = 3;
                                else if ((state == 1 || state == 3) && (currentChar == 'E' || currentChar == 'e'))
                                {
                                    state = 4;
                                }
                                else if (state == 4 && (currentChar == '-' || currentChar == '+'))
                                {
                                    state = 6;
                                }
                                else if (state == 4 && currentChar > 47 && currentChar < 58)
                                {
                                    state = 5;
                                }
                                else if (state == 5 && currentChar > 47 && currentChar < 58)
                                {
                                    continue;
                                }
                                else if (state == 6)
                                {
                                    if (currentChar > 47 && currentChar < 58)
                                    {
                                        state = 5;
                                        continue;
                                    }
                                    else
                                    {
                                        return AphidTokenType.Unknown;
                                    }
                                }
                                else if (state == 1 || state == 3 || state == 5)
                                {
                                    charIndex--;

                                    return AphidTokenType.Number;
                                }
                                else if (state == 2)
                                {
                                    charIndex -= 2;

                                    return AphidTokenType.Number;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            while (NextChar());

                            if (state == 1 || state == 3 || state == 5) { return AphidTokenType.Number; }

                            break;

                    }

                    return AphidTokenType.Unknown;
                }
            }


            return AphidTokenType.EndOfFile;
        }

        public List<AphidToken> GetTokens()
        {
            charIndex = -1;

            AphidTokenType tokenType;

            int lastIndex = -1;

            var tokens = new List<AphidToken>();

            while ((tokenType = GetToken()) != AphidTokenType.EndOfFile)
            {
                if (tokenType != AphidTokenType.WhiteSpace && tokenType != AphidTokenType.Comment)
                {
                    var index = lastIndex + 1;
                    var lexeme = text.Substring(index, charIndex - lastIndex);

                    tokens.Add(new AphidToken(tokenType, lexeme, index));

                }

                lastIndex = charIndex;
            }

            return tokens;
        }

        public List<AphidToken> GetAllTokens()
        {
            charIndex = -1;

            AphidTokenType tokenType;

            int lastIndex = -1;

            var tokens = new List<AphidToken>();

            while ((tokenType = GetToken()) != AphidTokenType.EndOfFile)
            {
                var index = lastIndex + 1;
                var lexeme = text.Substring(index, charIndex - lastIndex);

                tokens.Add(new AphidToken(tokenType, lexeme, index));


                lastIndex = charIndex;
            }

            return tokens;
        }
    }
}
#pragma warning restore 0162