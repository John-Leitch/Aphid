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

        BinaryOperatorBodyExpression,

        BooleanExpression,

        BreakExpression,

        CallExpression,

        ContinueExpression,

        DoWhileExpression,

        DynamicMemberExpression,

        ExtendExpression,

        ForEachExpression,

        ForExpression,

        FunctionExpression,

        GatorOpenExpression,

        GatorCloseExpression,

        GatorEmitExpression,

        IdentifierExpression,

        IfExpression,

        ImplicitArgumentExpression,

        ImplicitArgumentsExpression,

        LoadLibraryExpression,

        LoadScriptExpression,

        NullExpression,

        NumberExpression,

        ObjectExpression,

        PartialFunctionExpression,

        PartialOperatorExpression,

        PatternExpression,

        PatternMatchingExpression,

        UnaryOperatorExpression,

        StringExpression,

        SwitchCase,

        SwitchExpression,

        TernaryOperatorExpression,

        TextExpression,

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

    public partial class BinaryOperatorBodyExpression : AphidExpression, IParentNode
    {

        private AphidTokenType _operator;

        private FunctionExpression _function;

        public BinaryOperatorBodyExpression(AphidTokenType @operator, FunctionExpression function)
        {
            _operator = @operator;
            _function = function;
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public FunctionExpression Function
        {
            get
            {
                return _function;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.BinaryOperatorBodyExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Function};
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
                    FunctionExpression}.Concat(AphidExpressionHelper.GetCollection(Args)).ToArray();
        }
    }

    public partial class ContinueExpression : AphidExpression
    {

        public ContinueExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ContinueExpression;
            }
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
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
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

        private IdentifierExpression _extendType;

        private ObjectExpression _object;

        public ExtendExpression(IdentifierExpression extendType, ObjectExpression @object)
        {
            _extendType = extendType;
            _object = @object;
        }

        public IdentifierExpression ExtendType
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
                    ExtendType,
                    Object};
        }
    }

    public partial class ForEachExpression : AphidExpression, IParentNode
    {

        private AphidExpression _collection;

        private System.Collections.Generic.List<AphidExpression> _body;

        private AphidExpression _element;

        public ForEachExpression(AphidExpression collection, System.Collections.Generic.List<AphidExpression> body, [System.Runtime.InteropServices.OptionalAttribute()] AphidExpression element)
        {
            _collection = collection;
            _body = body;
            _element = element;
        }

        public AphidExpression Collection
        {
            get
            {
                return _collection;
            }
        }

        public System.Collections.Generic.List<AphidExpression> Body
        {
            get
            {
                return _body;
            }
        }

        public AphidExpression Element
        {
            get
            {
                return _element;
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
                    Element}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
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
                    Afterthought}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
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
            return Args.OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }

    public partial class GatorOpenExpression : AphidExpression
    {

        public GatorOpenExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.GatorOpenExpression;
            }
        }
    }

    public partial class GatorCloseExpression : AphidExpression
    {

        public GatorCloseExpression()
        {
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.GatorCloseExpression;
            }
        }
    }

    public partial class GatorEmitExpression : AphidExpression, IParentNode
    {

        private AphidExpression _expression;

        public GatorEmitExpression(AphidExpression expression)
        {
            _expression = expression;
        }

        public AphidExpression Expression
        {
            get
            {
                return _expression;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.GatorEmitExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Expression};
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
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(ElseBody)).ToArray();
        }
    }

    public partial class ImplicitArgumentExpression : AphidExpression
    {

        private AphidTokenType _operator;

        public ImplicitArgumentExpression(AphidTokenType @operator)
        {
            _operator = @operator;
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ImplicitArgumentExpression;
            }
        }
    }

    public partial class ImplicitArgumentsExpression : AphidExpression
    {

        private AphidTokenType _operator;

        public ImplicitArgumentsExpression(AphidTokenType @operator)
        {
            _operator = @operator;
        }

        public AphidTokenType Operator
        {
            get
            {
                return _operator;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.ImplicitArgumentsExpression;
            }
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

        private IdentifierExpression _identifier;

        public ObjectExpression(System.Collections.Generic.List<BinaryOperatorExpression> pairs, [System.Runtime.InteropServices.OptionalAttribute()] IdentifierExpression identifier)
        {
            _pairs = pairs;
            _identifier = identifier;
        }

        public System.Collections.Generic.List<BinaryOperatorExpression> Pairs
        {
            get
            {
                return _pairs;
            }
        }

        public IdentifierExpression Identifier
        {
            get
            {
                return _identifier;
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
            return new AphidExpression[] {
                    Identifier}.Concat(AphidExpressionHelper.GetCollection(Pairs)).ToArray();
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

    public partial class PartialOperatorExpression : AphidExpression, IParentNode
    {

        private AphidTokenType _operator;

        private AphidExpression _operand;

        public PartialOperatorExpression(AphidTokenType @operator, AphidExpression operand)
        {
            _operator = @operator;
            _operand = operand;
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

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.PartialOperatorExpression;
            }
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new AphidExpression[] {
                    Operand};
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
                    Value}.Concat(AphidExpressionHelper.GetCollection(Patterns)).ToArray();
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
                    TestExpression}.Concat(AphidExpressionHelper.GetCollection(Patterns)).ToArray();
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
            return Cases.OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
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
                    Expression}.Concat(AphidExpressionHelper.GetCollection(Cases)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(DefaultCase)).ToArray();
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

    public partial class TextExpression : AphidExpression
    {

        private string _text;

        public TextExpression(string text)
        {
            _text = text;
        }

        public string Text
        {
            get
            {
                return _text;
            }
        }

        public override AphidExpressionType Type
        {
            get
            {
                return AphidExpressionType.TextExpression;
            }
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
                    CatchArg}.Concat(AphidExpressionHelper.GetCollection(TryBody)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(CatchBody)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(FinallyBody)).ToArray();
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
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }

    public class AphidExpressionHelper
    {

        public static System.Collections.Generic.IEnumerable<AphidExpression> GetCollection(System.Collections.Generic.IEnumerable<AphidExpression> collection)
        {
            if ((collection == null))
            {
                return new AphidExpression[0];
            }
            else
            {
                return collection;
            }
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
                                if ((_currentToken.TokenType == AphidTokenType.EndOfStatement))
                                {
                                    NextToken();
                                }
                                else
                                {
                                    if ((((_currentToken.TokenType == AphidTokenType.RightBrace)
                                                == false)
                                                && ((_currentToken.TokenType == AphidTokenType.None)
                                                == false)))
                                    {
                                        throw new AphidParserException(_currentToken);
                                    }
                                }
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
                                        if ((_currentToken.TokenType == AphidTokenType.Text))
                                        {
                                            var index0007 = _currentToken.Index;
                                            exp = ParseTextExpression();
                                            if ((exp.Index < 0))
                                            {
                                                exp.Index = index0007;
                                                exp.Length = (_currentToken.Index - index0007);
                                            }
                                        }
                                        else
                                        {
                                            if ((_currentToken.TokenType == AphidTokenType.GatorOpenOperator))
                                            {
                                                exp = new GatorOpenExpression();
                                                NextToken();
                                            }
                                            else
                                            {
                                                if ((_currentToken.TokenType == AphidTokenType.GatorCloseOperator))
                                                {
                                                    exp = new GatorCloseExpression();
                                                    NextToken();
                                                }
                                                else
                                                {
                                                    if ((_currentToken.TokenType == AphidTokenType.GatorEmitOperator))
                                                    {
                                                        var index0008 = _currentToken.Index;
                                                        exp = ParseGatorEmitExpression();
                                                        if ((exp.Index < 0))
                                                        {
                                                            exp.Index = index0008;
                                                            exp.Length = (_currentToken.Index - index0008);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var index0009 = _currentToken.Index;
                                                        exp = ParseExpression();
                                                        if ((exp.Index < 0))
                                                        {
                                                            exp.Index = index0009;
                                                            exp.Length = (_currentToken.Index - index0009);
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
                                                        if ((_currentToken.TokenType == AphidTokenType.forKeyword))
                                                        {
                                                            NextToken();
                                                            IdentifierExpression id = default(IdentifierExpression);
                                                            if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
                                                            {
                                                                NextToken();
                                                                var index000A = _currentToken.Index;
                                                                id = ParseIdentifierExpression();
                                                                if ((id.Index < 0))
                                                                {
                                                                    id.Index = index000A;
                                                                    id.Length = (_currentToken.Index - index000A);
                                                                }
                                                                Match(AphidTokenType.RightParenthesis);
                                                            }
                                                            exp = new ForEachExpression(exp, ParseSingleBlock(), id);
                                                        }
                                                        if (true)
                                                        {
                                                            if ((_currentToken.TokenType == AphidTokenType.EndOfStatement))
                                                            {
                                                                NextToken();
                                                            }
                                                            else
                                                            {
                                                                if ((((_currentToken.TokenType == AphidTokenType.RightBrace)
                                                                            == false)
                                                                            && ((_currentToken.TokenType == AphidTokenType.None)
                                                                            == false)))
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
            return exp;
        }

        private AphidExpression ParseSingleStatement()
        {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.ifKeyword))
            {
                var index000B = _currentToken.Index;
                exp = ParseIfExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index000B;
                    exp.Length = (_currentToken.Index - index000B);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.forKeyword))
                {
                    var index000C = _currentToken.Index;
                    exp = ParseForExpression();
                    if ((exp.Index < 0))
                    {
                        exp.Index = index000C;
                        exp.Length = (_currentToken.Index - index000C);
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.whileKeyword))
                    {
                        var index000D = _currentToken.Index;
                        exp = ParseWhileExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index000D;
                            exp.Length = (_currentToken.Index - index000D);
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.doKeyword))
                        {
                            var index000E = _currentToken.Index;
                            exp = ParseDoWhileExpression();
                            if ((exp.Index < 0))
                            {
                                exp.Index = index000E;
                                exp.Length = (_currentToken.Index - index000E);
                            }
                            if (false)
                            {
                                if ((_currentToken.TokenType == AphidTokenType.EndOfStatement))
                                {
                                    NextToken();
                                }
                                else
                                {
                                    if ((((_currentToken.TokenType == AphidTokenType.RightBrace)
                                                == false)
                                                && ((_currentToken.TokenType == AphidTokenType.None)
                                                == false)))
                                    {
                                        throw new AphidParserException(_currentToken);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.extendKeyword))
                            {
                                var index000F = _currentToken.Index;
                                exp = ParseExtendExpression();
                                if ((exp.Index < 0))
                                {
                                    exp.Index = index000F;
                                    exp.Length = (_currentToken.Index - index000F);
                                }
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.tryKeyword))
                                {
                                    var index0010 = _currentToken.Index;
                                    exp = ParseTryExpression();
                                    if ((exp.Index < 0))
                                    {
                                        exp.Index = index0010;
                                        exp.Length = (_currentToken.Index - index0010);
                                    }
                                }
                                else
                                {
                                    if ((_currentToken.TokenType == AphidTokenType.switchKeyword))
                                    {
                                        var index0011 = _currentToken.Index;
                                        exp = ParseSwitchExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index0011;
                                            exp.Length = (_currentToken.Index - index0011);
                                        }
                                    }
                                    else
                                    {
                                        if ((_currentToken.TokenType == AphidTokenType.Text))
                                        {
                                            var index0012 = _currentToken.Index;
                                            exp = ParseTextExpression();
                                            if ((exp.Index < 0))
                                            {
                                                exp.Index = index0012;
                                                exp.Length = (_currentToken.Index - index0012);
                                            }
                                        }
                                        else
                                        {
                                            if ((_currentToken.TokenType == AphidTokenType.GatorOpenOperator))
                                            {
                                                exp = new GatorOpenExpression();
                                                NextToken();
                                            }
                                            else
                                            {
                                                if ((_currentToken.TokenType == AphidTokenType.GatorCloseOperator))
                                                {
                                                    exp = new GatorCloseExpression();
                                                    NextToken();
                                                }
                                                else
                                                {
                                                    if ((_currentToken.TokenType == AphidTokenType.GatorEmitOperator))
                                                    {
                                                        var index0013 = _currentToken.Index;
                                                        exp = ParseGatorEmitExpression();
                                                        if ((exp.Index < 0))
                                                        {
                                                            exp.Index = index0013;
                                                            exp.Length = (_currentToken.Index - index0013);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var index0014 = _currentToken.Index;
                                                        exp = ParseExpression();
                                                        if ((exp.Index < 0))
                                                        {
                                                            exp.Index = index0014;
                                                            exp.Length = (_currentToken.Index - index0014);
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
                                                        if ((_currentToken.TokenType == AphidTokenType.forKeyword))
                                                        {
                                                            NextToken();
                                                            IdentifierExpression id = default(IdentifierExpression);
                                                            if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
                                                            {
                                                                NextToken();
                                                                var index0015 = _currentToken.Index;
                                                                id = ParseIdentifierExpression();
                                                                if ((id.Index < 0))
                                                                {
                                                                    id.Index = index0015;
                                                                    id.Length = (_currentToken.Index - index0015);
                                                                }
                                                                Match(AphidTokenType.RightParenthesis);
                                                            }
                                                            exp = new ForEachExpression(exp, ParseSingleBlock(), id);
                                                        }
                                                        if (false)
                                                        {
                                                            if ((_currentToken.TokenType == AphidTokenType.EndOfStatement))
                                                            {
                                                                NextToken();
                                                            }
                                                            else
                                                            {
                                                                if ((((_currentToken.TokenType == AphidTokenType.RightBrace)
                                                                            == false)
                                                                            && ((_currentToken.TokenType == AphidTokenType.None)
                                                                            == false)))
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
            return exp;
        }

        public AphidExpression ParseExpression()
        {
            return ParseAssignmentExpression();
        }

        private AphidExpression ParseAssignmentExpression()
        {
            var index0016 = _currentToken.Index;
            var operand = ParsePipelineExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0016;
                operand.Length = (_currentToken.Index - index0016);
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
            var index0017 = _currentToken.Index;
            var operand = ParseRangeExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0017;
                operand.Length = (_currentToken.Index - index0017);
            }
            var inPipeline = false;
            for (
            ; true;
            )
            {
                if ((_currentToken.TokenType == AphidTokenType.PipelineOperator))
                {
                    inPipeline = true;
                    var op = _currentToken.TokenType;
                    NextToken();
                    operand = new BinaryOperatorExpression(operand, AphidTokenType.PipelineOperator, ParseRangeExpression());
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.InteropOperator))
                    {
                        inPipeline = true;
                        operand = new BinaryOperatorExpression(operand, AphidTokenType.PipelineOperator, ParsePrefixUnaryOperatorExpression());
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.FunctionOperator))
                        {
                            inPipeline = true;
                            operand = new BinaryOperatorExpression(operand, AphidTokenType.PipelineOperator, ParseFunctionExpression());
                        }
                        else
                        {
                            if ((((((_currentToken.TokenType == AphidTokenType.AggregateOperator)
                                        || (_currentToken.TokenType == AphidTokenType.AnyOperator))
                                        || (_currentToken.TokenType == AphidTokenType.SelectManyOperator))
                                        || (_currentToken.TokenType == AphidTokenType.SelectOperator))
                                        || (_currentToken.TokenType == AphidTokenType.WhereOperator)))
                            {
                                inPipeline = true;
                                var t = _currentToken.TokenType;
                                NextToken();
                                operand = new BinaryOperatorExpression(operand, t, ParseRangeExpression());
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.DistinctOperator))
                                {
                                    inPipeline = true;
                                    operand = new UnaryOperatorExpression(_currentToken.TokenType, operand);
                                    NextToken();
                                }
                                else
                                {
                                    if ((inPipeline
                                                && (_currentToken.TokenType == AphidTokenType.Identifier)))
                                    {
                                        operand = new BinaryOperatorExpression(operand, AphidTokenType.PipelineOperator, ParseExpression());
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return operand;
        }

        private AphidExpression ParseRangeExpression()
        {
            var index0018 = _currentToken.Index;
            var operand = ParseConditionalExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0018;
                operand.Length = (_currentToken.Index - index0018);
            }
            for (
            ; (((_currentToken.TokenType == AphidTokenType.RangeOperator)
                        || (_currentToken.TokenType == AphidTokenType.CompositionOperator))
                        || (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((_currentToken.TokenType == AphidTokenType.CustomOperator000)
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator001))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator002))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator003))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator004))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator005))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator006))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator007))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator008))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator009))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator010))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator011))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator012))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator013))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator014))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator015))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator016))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator017))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator018))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator019))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator020))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator021))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator022))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator023))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator024))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator025))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator026))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator027))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator028))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator029))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator030))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator031))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator032))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator033))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator034))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator035))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator036))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator037))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator038))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator039))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator040))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator041))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator042))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator043))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator044))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator045))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator046))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator047))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator048))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator049))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator050))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator051))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator052))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator053))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator054))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator055))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator056))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator057))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator058))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator059))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator060))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator061))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator062))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator063))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator064))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator065))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator066))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator067))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator068))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator069))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator070))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator071))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator072))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator073))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator074))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator075))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator076))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator077))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator078))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator079))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator080))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator081))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator082))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator083))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator084))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator085))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator086))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator087))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator088))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator089))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator090))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator091))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator092))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator093))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator094))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator095))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator096))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator097))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator098))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator099))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator100))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator101))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator102))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator103))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator104))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator105))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator106))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator107))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator108))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator109))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator110))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator111))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator112))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator113))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator114))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator115))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator116))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator117))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator118))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator119))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator120))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator121))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator122))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator123))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator124))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator125))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator126))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator127))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator128))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator129))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator130))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator131))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator132))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator133))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator134))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator135))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator136))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator137))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator138))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator139))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator140))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator141))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator142))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator143))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator144))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator145))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator146))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator147))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator148))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator149))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator150))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator151))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator152))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator153))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator154))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator155))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator156))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator157))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator158))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator159))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator160))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator161))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator162))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator163))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator164))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator165))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator166))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator167))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator168))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator169))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator170))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator171))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator172))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator173))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator174))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator175))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator176))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator177))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator178))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator179))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator180))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator181))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator182))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator183))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator184))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator185))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator186))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator187))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator188))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator189))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator190))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator191))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator192))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator193))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator194))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator195))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator196))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator197))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator198))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator199))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator200))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator201))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator202))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator203))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator204))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator205))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator206))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator207))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator208))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator209))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator210))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator211))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator212))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator213))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator214))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator215))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator216))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator217))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator218))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator219))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator220))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator221))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator222))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator223))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator224))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator225))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator226))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator227))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator228))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator229))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator230))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator231))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator232))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator233))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator234))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator235))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator236))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator237))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator238))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator239))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator240))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator241))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator242))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator243))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator244))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator245))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator246))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator247))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator248))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator249))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator250))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator251))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator252))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator253))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator254))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator255))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator256))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator257))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator258))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator259))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator260))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator261))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator262))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator263))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator264))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator265))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator266))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator267))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator268))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator269))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator270))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator271))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator272))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator273))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator274))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator275))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator276))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator277))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator278))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator279))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator280))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator281))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator282))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator283))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator284))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator285))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator286))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator287))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator288))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator289))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator290))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator291))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator292))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator293))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator294))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator295))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator296))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator297))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator298))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator299))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator300))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator301))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator302))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator303))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator304))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator305))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator306))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator307))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator308))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator309))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator310))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator311))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator312))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator313))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator314))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator315))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator316))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator317))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator318))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator319))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator320))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator321))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator322))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator323))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator324))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator325))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator326))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator327))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator328))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator329))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator330)));
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
            var index0019 = _currentToken.Index;
            var exp = ParseLogicalExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0019;
                exp.Length = (_currentToken.Index - index0019);
            }
            if ((_currentToken.TokenType == AphidTokenType.ConditionalOperator))
            {
                NextToken();
                var index001A = _currentToken.Index;
                var trueExpression = ParseExpression();
                if ((trueExpression.Index < 0))
                {
                    trueExpression.Index = index001A;
                    trueExpression.Length = (_currentToken.Index - index001A);
                }
                Match(AphidTokenType.ColonOperator);
                var index001B = _currentToken.Index;
                var falseExpression = ParseExpression();
                if ((falseExpression.Index < 0))
                {
                    falseExpression.Index = index001B;
                    falseExpression.Length = (_currentToken.Index - index001B);
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
            var index001C = _currentToken.Index;
            var operand = ParseComparisonExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001C;
                operand.Length = (_currentToken.Index - index001C);
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
            var index001D = _currentToken.Index;
            var operand = ParsePostfixUnaryOperationExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001D;
                operand.Length = (_currentToken.Index - index001D);
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
            var index001E = _currentToken.Index;
            var term = ParseBinaryOrExpression();
            if ((term.Index < 0))
            {
                term.Index = index001E;
                term.Length = (_currentToken.Index - index001E);
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
            var index001F = _currentToken.Index;
            var operand = ParseXorExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index001F;
                operand.Length = (_currentToken.Index - index001F);
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
            var index0020 = _currentToken.Index;
            var operand = ParseBinaryAndExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0020;
                operand.Length = (_currentToken.Index - index0020);
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
            var index0021 = _currentToken.Index;
            var operand = ParseShiftExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0021;
                operand.Length = (_currentToken.Index - index0021);
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
            var index0022 = _currentToken.Index;
            var operand = ParseAdditionExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0022;
                operand.Length = (_currentToken.Index - index0022);
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
            var index0023 = _currentToken.Index;
            var operand = ParseTermExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0023;
                operand.Length = (_currentToken.Index - index0023);
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
            var index0024 = _currentToken.Index;
            var operand = ParsePrefixUnaryOperatorExpression();
            if ((operand.Index < 0))
            {
                operand.Index = index0024;
                operand.Length = (_currentToken.Index - index0024);
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
            if (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((_currentToken.TokenType == AphidTokenType.AdditionOperator)
                        || (_currentToken.TokenType == AphidTokenType.MinusOperator))
                        || (_currentToken.TokenType == AphidTokenType.NotOperator))
                        || (_currentToken.TokenType == AphidTokenType.IncrementOperator))
                        || (_currentToken.TokenType == AphidTokenType.DecrementOperator))
                        || (_currentToken.TokenType == AphidTokenType.MultiplicationOperator))
                        || (_currentToken.TokenType == AphidTokenType.ComplementOperator))
                        || (_currentToken.TokenType == AphidTokenType.InteropOperator))
                        || (_currentToken.TokenType == AphidTokenType.usingKeyword))
                        || (_currentToken.TokenType == AphidTokenType.newKeyword))
                        || (_currentToken.TokenType == AphidTokenType.loadKeyword))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator000))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator001))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator002))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator003))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator004))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator005))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator006))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator007))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator008))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator009))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator010))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator011))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator012))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator013))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator014))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator015))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator016))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator017))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator018))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator019))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator020))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator021))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator022))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator023))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator024))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator025))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator026))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator027))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator028))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator029))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator030))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator031))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator032))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator033))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator034))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator035))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator036))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator037))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator038))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator039))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator040))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator041))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator042))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator043))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator044))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator045))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator046))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator047))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator048))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator049))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator050))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator051))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator052))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator053))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator054))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator055))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator056))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator057))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator058))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator059))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator060))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator061))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator062))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator063))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator064))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator065))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator066))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator067))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator068))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator069))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator070))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator071))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator072))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator073))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator074))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator075))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator076))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator077))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator078))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator079))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator080))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator081))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator082))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator083))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator084))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator085))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator086))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator087))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator088))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator089))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator090))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator091))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator092))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator093))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator094))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator095))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator096))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator097))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator098))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator099))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator100))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator101))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator102))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator103))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator104))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator105))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator106))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator107))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator108))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator109))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator110))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator111))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator112))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator113))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator114))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator115))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator116))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator117))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator118))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator119))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator120))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator121))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator122))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator123))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator124))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator125))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator126))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator127))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator128))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator129))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator130))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator131))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator132))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator133))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator134))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator135))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator136))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator137))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator138))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator139))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator140))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator141))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator142))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator143))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator144))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator145))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator146))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator147))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator148))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator149))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator150))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator151))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator152))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator153))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator154))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator155))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator156))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator157))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator158))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator159))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator160))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator161))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator162))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator163))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator164))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator165))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator166))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator167))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator168))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator169))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator170))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator171))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator172))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator173))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator174))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator175))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator176))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator177))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator178))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator179))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator180))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator181))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator182))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator183))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator184))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator185))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator186))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator187))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator188))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator189))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator190))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator191))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator192))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator193))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator194))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator195))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator196))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator197))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator198))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator199))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator200))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator201))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator202))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator203))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator204))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator205))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator206))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator207))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator208))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator209))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator210))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator211))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator212))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator213))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator214))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator215))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator216))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator217))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator218))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator219))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator220))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator221))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator222))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator223))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator224))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator225))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator226))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator227))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator228))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator229))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator230))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator231))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator232))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator233))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator234))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator235))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator236))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator237))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator238))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator239))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator240))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator241))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator242))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator243))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator244))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator245))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator246))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator247))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator248))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator249))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator250))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator251))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator252))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator253))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator254))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator255))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator256))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator257))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator258))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator259))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator260))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator261))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator262))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator263))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator264))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator265))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator266))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator267))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator268))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator269))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator270))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator271))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator272))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator273))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator274))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator275))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator276))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator277))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator278))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator279))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator280))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator281))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator282))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator283))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator284))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator285))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator286))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator287))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator288))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator289))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator290))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator291))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator292))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator293))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator294))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator295))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator296))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator297))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator298))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator299))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator300))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator301))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator302))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator303))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator304))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator305))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator306))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator307))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator308))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator309))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator310))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator311))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator312))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator313))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator314))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator315))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator316))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator317))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator318))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator319))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator320))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator321))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator322))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator323))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator324))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator325))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator326))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator327))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator328))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator329))
                        || (_currentToken.TokenType == AphidTokenType.CustomOperator330)))
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
            var index0025 = _currentToken.Index;
            var exp = ParseCallExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0025;
                exp.Length = (_currentToken.Index - index0025);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftBracket);
            )
            {
                NextToken();
                var index0026 = _currentToken.Index;
                var key = ParseExpression();
                if ((key.Index < 0))
                {
                    key.Index = index0026;
                    key.Length = (_currentToken.Index - index0026);
                }
                Match(AphidTokenType.RightBracket);
                exp = new ArrayAccessExpression(exp, key);
                for (
                ; (_currentToken.TokenType == AphidTokenType.MemberOperator);
                )
                {
                    NextToken();
                    AphidExpression memberExp = default(AphidExpression);
                    if ((_currentToken.TokenType == AphidTokenType.Identifier))
                    {
                        memberExp = new IdentifierExpression(_currentToken.Lexeme);
                        NextToken();
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.String))
                        {
                            var index0027 = _currentToken.Index;
                            memberExp = ParseStringExpression();
                            if ((memberExp.Index < 0))
                            {
                                memberExp.Index = index0027;
                                memberExp.Length = (_currentToken.Index - index0027);
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
                            {
                                NextToken();
                                memberExp = new DynamicMemberExpression(ParseExpression());
                                Match(AphidTokenType.RightBrace);
                            }
                            else
                            {
                                throw new AphidParserException(_currentToken);
                            }
                        }
                    }
                    exp = new BinaryOperatorExpression(exp, AphidTokenType.MemberOperator, memberExp);
                    for (
                    ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis);
                    )
                    {
                        NextToken();
                        if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                        {
                            NextToken();
                            exp = new CallExpression(exp);
                        }
                        else
                        {
                            var args = ParseTuple();
                            Match(AphidTokenType.RightParenthesis);
                            exp = new CallExpression(exp, args);
                        }
                    }
                    if ((_currentToken.TokenType == AphidTokenType.definedKeyword))
                    {
                        NextToken();
                        return new UnaryOperatorExpression(AphidTokenType.definedKeyword, exp, true);
                    }
                }
                for (
                ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis);
                )
                {
                    NextToken();
                    if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                    {
                        NextToken();
                        exp = new CallExpression(exp);
                    }
                    else
                    {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        exp = new CallExpression(exp, args);
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParseCallExpression()
        {
            var index0028 = _currentToken.Index;
            var function = ParseMemberExpression();
            if ((function.Index < 0))
            {
                function.Index = index0028;
                function.Length = (_currentToken.Index - index0028);
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
            var index0029 = _currentToken.Index;
            var factor = ParseFactorCallExpression();
            if ((factor.Index < 0))
            {
                factor.Index = index0029;
                factor.Length = (_currentToken.Index - index0029);
            }
            for (
            ; (_currentToken.TokenType == AphidTokenType.MemberOperator);
            )
            {
                NextToken();
                AphidExpression memberExp = default(AphidExpression);
                if ((_currentToken.TokenType == AphidTokenType.Identifier))
                {
                    memberExp = new IdentifierExpression(_currentToken.Lexeme);
                    NextToken();
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.String))
                    {
                        var index002A = _currentToken.Index;
                        memberExp = ParseStringExpression();
                        if ((memberExp.Index < 0))
                        {
                            memberExp.Index = index002A;
                            memberExp.Length = (_currentToken.Index - index002A);
                        }
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
                        {
                            NextToken();
                            memberExp = new DynamicMemberExpression(ParseExpression());
                            Match(AphidTokenType.RightBrace);
                        }
                        else
                        {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                factor = new BinaryOperatorExpression(factor, AphidTokenType.MemberOperator, memberExp);
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
            var index002B = _currentToken.Index;
            var function = ParseFactorExpression();
            if ((function.Index < 0))
            {
                function.Index = index002B;
                function.Length = (_currentToken.Index - index002B);
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
            var index002C = _currentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0))
            {
                condition.Index = index002C;
                condition.Length = (_currentToken.Index - index002C);
            }
            Match(AphidTokenType.RightParenthesis);
            return condition;
        }

        private AphidExpression ParseIfExpression()
        {
            NextToken();
            var index002D = _currentToken.Index;
            var condition = ParseCondition();
            if ((condition.Index < 0))
            {
                condition.Index = index002D;
                condition.Length = (_currentToken.Index - index002D);
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
            return new ExtendExpression(ParseIdentifierExpression(), ParseObjectExpression());
        }

        private AphidExpression ParseForExpression()
        {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var index002E = _currentToken.Index;
            var initOrElement = ParseExpression();
            if ((initOrElement.Index < 0))
            {
                initOrElement.Index = index002E;
                initOrElement.Length = (_currentToken.Index - index002E);
            }
            if ((_currentToken.TokenType == AphidTokenType.inKeyword))
            {
                NextToken();
                var index002F = _currentToken.Index;
                var collection = ParseExpression();
                if ((collection.Index < 0))
                {
                    collection.Index = index002F;
                    collection.Length = (_currentToken.Index - index002F);
                }
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForEachExpression(collection, body, initOrElement);
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.RightParenthesis))
                {
                    Match(AphidTokenType.RightParenthesis);
                    var body = ParseBlock();
                    return new ForEachExpression(initOrElement, body, null);
                }
                else
                {
                    Match(AphidTokenType.EndOfStatement);
                    var index0030 = _currentToken.Index;
                    var condition = ParseExpression();
                    if ((condition.Index < 0))
                    {
                        condition.Index = index0030;
                        condition.Length = (_currentToken.Index - index0030);
                    }
                    Match(AphidTokenType.EndOfStatement);
                    var index0031 = _currentToken.Index;
                    var afterthought = ParseExpression();
                    if ((afterthought.Index < 0))
                    {
                        afterthought.Index = index0031;
                        afterthought.Length = (_currentToken.Index - index0031);
                    }
                    Match(AphidTokenType.RightParenthesis);
                    var body = ParseBlock();
                    return new ForExpression(initOrElement, condition, afterthought, body);
                }
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
            var index0032 = _currentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0))
            {
                condition.Index = index0032;
                condition.Length = (_currentToken.Index - index0032);
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
                if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
                {
                    Match(AphidTokenType.LeftParenthesis);
                    var index0033 = _currentToken.Index;
                    catchArg = ParseIdentifierExpression();
                    if ((catchArg.Index < 0))
                    {
                        catchArg.Index = index0033;
                        catchArg.Length = (_currentToken.Index - index0033);
                    }
                    Match(AphidTokenType.RightParenthesis);
                }
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
            var index0034 = _currentToken.Index;
            var exp = ParseExpression();
            if ((exp.Index < 0))
            {
                exp.Index = index0034;
                exp.Length = (_currentToken.Index - index0034);
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
                if (((_currentToken.TokenType == AphidTokenType.Identifier)
                            || (_currentToken.TokenType == AphidTokenType.String)))
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

        private BinaryOperatorExpression ParseKeyValuePairExpression()
        {
            AphidExpression exp = default(AphidExpression);
            AphidExpression id = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.Identifier))
            {
                var index0035 = _currentToken.Index;
                id = ParseIdentifierExpression();
                if ((id.Index < 0))
                {
                    id.Index = index0035;
                    id.Length = (_currentToken.Index - index0035);
                }
            }
            else
            {
                var index0036 = _currentToken.Index;
                id = ParseStringExpression();
                if ((id.Index < 0))
                {
                    id.Index = index0036;
                    id.Length = (_currentToken.Index - index0036);
                }
            }
            if (((_currentToken.TokenType == AphidTokenType.ColonOperator)
                        || (_currentToken.TokenType == AphidTokenType.AssignmentOperator)))
            {
                NextToken();
                var index0037 = _currentToken.Index;
                exp = ParseExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index0037;
                    exp.Length = (_currentToken.Index - index0037);
                }
            }
            else
            {
                exp = id;
            }
            return new BinaryOperatorExpression(id, AphidTokenType.ColonOperator, exp);
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

        private AphidExpression ParseNumberExpression()
        {
            var exp = new NumberExpression(decimal.Parse(_currentToken.Lexeme));
            NextToken();
            return exp;
        }

        private FunctionExpression ParseFunctionDeclaration()
        {
            AphidExpression argExp = default(AphidExpression);
            var args = new System.Collections.Generic.List<AphidExpression>();
            var body = new System.Collections.Generic.List<AphidExpression>();
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
                        var index0038 = _currentToken.Index;
                        var id = ParseIdentifierExpression();
                        if ((id.Index < 0))
                        {
                            id.Index = index0038;
                            id.Length = (_currentToken.Index - index0038);
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
            return new FunctionExpression(args, body);
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
                var index0039 = _currentToken.Index;
                exp = ParseFunctionDeclaration();
                if ((exp.Index < 0))
                {
                    exp.Index = index0039;
                    exp.Length = (_currentToken.Index - index0039);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
                {
                    exp = new FunctionExpression(args, ParseBlock());
                }
                else
                {
                    if ((((((((((((((((((((((_currentToken.TokenType == AphidTokenType.MinusOperator)
                                || (_currentToken.TokenType == AphidTokenType.AdditionOperator))
                                || (_currentToken.TokenType == AphidTokenType.MultiplicationOperator))
                                || (_currentToken.TokenType == AphidTokenType.DivisionOperator))
                                || (_currentToken.TokenType == AphidTokenType.ModulusOperator))
                                || (_currentToken.TokenType == AphidTokenType.BinaryAndOperator))
                                || (_currentToken.TokenType == AphidTokenType.BinaryOrOperator))
                                || (_currentToken.TokenType == AphidTokenType.XorOperator))
                                || (_currentToken.TokenType == AphidTokenType.ShiftLeft))
                                || (_currentToken.TokenType == AphidTokenType.ShiftRight))
                                || (_currentToken.TokenType == AphidTokenType.AndOperator))
                                || (_currentToken.TokenType == AphidTokenType.OrOperator))
                                || (_currentToken.TokenType == AphidTokenType.EqualityOperator))
                                || (_currentToken.TokenType == AphidTokenType.NotEqualOperator))
                                || (_currentToken.TokenType == AphidTokenType.NotEqualOperator))
                                || (_currentToken.TokenType == AphidTokenType.LessThanOperator))
                                || (_currentToken.TokenType == AphidTokenType.GreaterThanOperator))
                                || (_currentToken.TokenType == AphidTokenType.LessThanOrEqualOperator))
                                || (_currentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator))
                                || (_currentToken.TokenType == AphidTokenType.PipelineOperator))
                                || (_currentToken.TokenType == AphidTokenType.MemberOperator)))
                    {
                        var op = _currentToken.TokenType;
                        NextToken();
                        exp = new PartialOperatorExpression(op, ParseRangeExpression());
                    }
                    else
                    {
                        if ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((_currentToken.TokenType == AphidTokenType.CustomOperator000)
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator001))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator002))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator003))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator004))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator005))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator006))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator007))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator008))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator009))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator010))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator011))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator012))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator013))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator014))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator015))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator016))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator017))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator018))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator019))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator020))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator021))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator022))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator023))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator024))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator025))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator026))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator027))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator028))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator029))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator030))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator031))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator032))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator033))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator034))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator035))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator036))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator037))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator038))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator039))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator040))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator041))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator042))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator043))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator044))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator045))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator046))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator047))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator048))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator049))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator050))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator051))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator052))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator053))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator054))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator055))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator056))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator057))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator058))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator059))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator060))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator061))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator062))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator063))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator064))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator065))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator066))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator067))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator068))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator069))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator070))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator071))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator072))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator073))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator074))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator075))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator076))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator077))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator078))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator079))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator080))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator081))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator082))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator083))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator084))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator085))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator086))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator087))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator088))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator089))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator090))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator091))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator092))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator093))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator094))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator095))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator096))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator097))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator098))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator099))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator100))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator101))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator102))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator103))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator104))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator105))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator106))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator107))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator108))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator109))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator110))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator111))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator112))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator113))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator114))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator115))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator116))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator117))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator118))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator119))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator120))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator121))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator122))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator123))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator124))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator125))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator126))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator127))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator128))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator129))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator130))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator131))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator132))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator133))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator134))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator135))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator136))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator137))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator138))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator139))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator140))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator141))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator142))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator143))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator144))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator145))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator146))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator147))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator148))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator149))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator150))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator151))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator152))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator153))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator154))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator155))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator156))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator157))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator158))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator159))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator160))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator161))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator162))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator163))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator164))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator165))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator166))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator167))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator168))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator169))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator170))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator171))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator172))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator173))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator174))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator175))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator176))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator177))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator178))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator179))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator180))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator181))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator182))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator183))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator184))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator185))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator186))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator187))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator188))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator189))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator190))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator191))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator192))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator193))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator194))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator195))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator196))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator197))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator198))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator199))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator200))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator201))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator202))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator203))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator204))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator205))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator206))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator207))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator208))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator209))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator210))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator211))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator212))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator213))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator214))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator215))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator216))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator217))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator218))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator219))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator220))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator221))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator222))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator223))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator224))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator225))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator226))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator227))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator228))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator229))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator230))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator231))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator232))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator233))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator234))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator235))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator236))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator237))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator238))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator239))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator240))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator241))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator242))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator243))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator244))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator245))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator246))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator247))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator248))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator249))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator250))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator251))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator252))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator253))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator254))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator255))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator256))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator257))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator258))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator259))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator260))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator261))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator262))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator263))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator264))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator265))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator266))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator267))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator268))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator269))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator270))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator271))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator272))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator273))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator274))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator275))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator276))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator277))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator278))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator279))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator280))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator281))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator282))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator283))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator284))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator285))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator286))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator287))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator288))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator289))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator290))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator291))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator292))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator293))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator294))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator295))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator296))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator297))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator298))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator299))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator300))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator301))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator302))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator303))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator304))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator305))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator306))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator307))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator308))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator309))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator310))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator311))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator312))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator313))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator314))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator315))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator316))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator317))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator318))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator319))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator320))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator321))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator322))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator323))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator324))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator325))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator326))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator327))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator328))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator329))
                                    || (_currentToken.TokenType == AphidTokenType.CustomOperator330)))
                        {
                            var op = _currentToken.TokenType;
                            NextToken();
                            exp = new BinaryOperatorBodyExpression(op, ParseFunctionDeclaration());
                        }
                        else
                        {
                            exp = new PartialFunctionExpression(ParseCallExpression());
                        }
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParsePatternMatchingExpression()
        {
            NextToken();
            var patterns = new System.Collections.Generic.List<PatternExpression>();
            Match(AphidTokenType.LeftParenthesis);
            var index003A = _currentToken.Index;
            var testExp = ParseExpression();
            if ((testExp.Index < 0))
            {
                testExp.Index = index003A;
                testExp.Length = (_currentToken.Index - index003A);
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
                    var index003B = _currentToken.Index;
                    valueExp = ParseExpression();
                    if ((valueExp.Index < 0))
                    {
                        valueExp.Index = index003B;
                        valueExp.Length = (_currentToken.Index - index003B);
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
                var index003C = _currentToken.Index;
                exp = ParseObjectExpression();
                if ((exp.Index < 0))
                {
                    exp.Index = index003C;
                    exp.Length = (_currentToken.Index - index003C);
                }
            }
            else
            {
                if ((_currentToken.TokenType == AphidTokenType.LeftBracket))
                {
                    var index003D = _currentToken.Index;
                    exp = ParseArrayExpression();
                    if ((exp.Index < 0))
                    {
                        exp.Index = index003D;
                        exp.Length = (_currentToken.Index - index003D);
                    }
                }
                else
                {
                    if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis))
                    {
                        NextToken();
                        var index003E = _currentToken.Index;
                        exp = ParseExpression();
                        if ((exp.Index < 0))
                        {
                            exp.Index = index003E;
                            exp.Length = (_currentToken.Index - index003E);
                        }
                        Match(AphidTokenType.RightParenthesis);
                    }
                    else
                    {
                        if ((_currentToken.TokenType == AphidTokenType.String))
                        {
                            var index003F = _currentToken.Index;
                            exp = ParseStringExpression();
                            if ((exp.Index < 0))
                            {
                                exp.Index = index003F;
                                exp.Length = (_currentToken.Index - index003F);
                            }
                        }
                        else
                        {
                            if ((_currentToken.TokenType == AphidTokenType.Number))
                            {
                                var index0040 = _currentToken.Index;
                                exp = ParseNumberExpression();
                                if ((exp.Index < 0))
                                {
                                    exp.Index = index0040;
                                    exp.Length = (_currentToken.Index - index0040);
                                }
                            }
                            else
                            {
                                if ((_currentToken.TokenType == AphidTokenType.Identifier))
                                {
                                    var index0041 = _currentToken.Index;
                                    var id = ParseIdentifierExpression();
                                    if ((id.Index < 0))
                                    {
                                        id.Index = index0041;
                                        id.Length = (_currentToken.Index - index0041);
                                    }
                                    if ((_currentToken.TokenType == AphidTokenType.definedKeyword))
                                    {
                                        NextToken();
                                        exp = new UnaryOperatorExpression(AphidTokenType.definedKeyword, id, true);
                                    }
                                    else
                                    {
                                        if ((_currentToken.TokenType == AphidTokenType.LeftBrace))
                                        {
                                            var index0042 = _currentToken.Index;
                                            var obj = ParseObjectExpression();
                                            if ((obj.Index < 0))
                                            {
                                                obj.Index = index0042;
                                                obj.Length = (_currentToken.Index - index0042);
                                            }
                                            exp = new ObjectExpression(obj.Pairs, id);
                                        }
                                        else
                                        {
                                            exp = id;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((_currentToken.TokenType == AphidTokenType.FunctionOperator))
                                    {
                                        var index0043 = _currentToken.Index;
                                        exp = ParseFunctionExpression();
                                        if ((exp.Index < 0))
                                        {
                                            exp.Index = index0043;
                                            exp.Length = (_currentToken.Index - index0043);
                                        }
                                    }
                                    else
                                    {
                                        if ((_currentToken.TokenType == AphidTokenType.ImplicitArgumentOperator))
                                        {
                                            var op = _currentToken.TokenType;
                                            NextToken();
                                            exp = new ImplicitArgumentExpression(op);
                                        }
                                        else
                                        {
                                            if ((_currentToken.TokenType == AphidTokenType.ImplicitArgumentsOperator))
                                            {
                                                var op = _currentToken.TokenType;
                                                NextToken();
                                                exp = new ImplicitArgumentsExpression(op);
                                            }
                                            else
                                            {
                                                if (((_currentToken.TokenType == AphidTokenType.retKeyword)
                                                            || (_currentToken.TokenType == AphidTokenType.deleteKeyword)))
                                                {
                                                    var index0044 = _currentToken.Index;
                                                    exp = ParseUnaryExpression();
                                                    if ((exp.Index < 0))
                                                    {
                                                        exp.Index = index0044;
                                                        exp.Length = (_currentToken.Index - index0044);
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
                                                                    var index0045 = _currentToken.Index;
                                                                    exp = ParseLoadScriptExpression();
                                                                    if ((exp.Index < 0))
                                                                    {
                                                                        exp.Index = index0045;
                                                                        exp.Length = (_currentToken.Index - index0045);
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if ((_currentToken.TokenType == AphidTokenType.LoadLibraryOperator))
                                                                    {
                                                                        var index0046 = _currentToken.Index;
                                                                        exp = ParseLoadLibraryExpression();
                                                                        if ((exp.Index < 0))
                                                                        {
                                                                            exp.Index = index0046;
                                                                            exp.Length = (_currentToken.Index - index0046);
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
                                                                            if ((_currentToken.TokenType == AphidTokenType.continueKeyword))
                                                                            {
                                                                                exp = new ContinueExpression();
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
                                                                                        exp = new NumberExpression(System.Convert.ToUInt64(_currentToken.Lexeme.Substring(2), 16));
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
                                                                                                var index0047 = _currentToken.Index;
                                                                                                exp = ParsePatternMatchingExpression();
                                                                                                if ((exp.Index < 0))
                                                                                                {
                                                                                                    exp.Index = index0047;
                                                                                                    exp.Length = (_currentToken.Index - index0047);
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
                    }
                }
            }
            return exp;
        }

        private AphidExpression ParseTextExpression()
        {
            AphidExpression t = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.Text))
            {
                t = new TextExpression(_currentToken.Lexeme);
                NextToken();
            }
            else
            {
                t = new TextExpression("");
            }
            return t;
        }

        private AphidExpression ParseGatorEmitExpression()
        {
            NextToken();
            var t = new GatorEmitExpression(ParseExpression());
            Match(AphidTokenType.GatorCloseOperator);
            return t;
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
        CompositionOperator,
        ConditionalOperator,
        continueKeyword,
        CustomOperator000,
        CustomOperator001,
        CustomOperator002,
        CustomOperator003,
        CustomOperator004,
        CustomOperator005,
        CustomOperator006,
        CustomOperator007,
        CustomOperator008,
        CustomOperator009,
        CustomOperator010,
        CustomOperator011,
        CustomOperator012,
        CustomOperator013,
        CustomOperator014,
        CustomOperator015,
        CustomOperator016,
        CustomOperator017,
        CustomOperator018,
        CustomOperator019,
        CustomOperator020,
        CustomOperator021,
        CustomOperator022,
        CustomOperator023,
        CustomOperator024,
        CustomOperator025,
        CustomOperator026,
        CustomOperator027,
        CustomOperator028,
        CustomOperator029,
        CustomOperator030,
        CustomOperator031,
        CustomOperator032,
        CustomOperator033,
        CustomOperator034,
        CustomOperator035,
        CustomOperator036,
        CustomOperator037,
        CustomOperator038,
        CustomOperator039,
        CustomOperator040,
        CustomOperator041,
        CustomOperator042,
        CustomOperator043,
        CustomOperator044,
        CustomOperator045,
        CustomOperator046,
        CustomOperator047,
        CustomOperator048,
        CustomOperator049,
        CustomOperator050,
        CustomOperator051,
        CustomOperator052,
        CustomOperator053,
        CustomOperator054,
        CustomOperator055,
        CustomOperator056,
        CustomOperator057,
        CustomOperator058,
        CustomOperator059,
        CustomOperator060,
        CustomOperator061,
        CustomOperator062,
        CustomOperator063,
        CustomOperator064,
        CustomOperator065,
        CustomOperator066,
        CustomOperator067,
        CustomOperator068,
        CustomOperator069,
        CustomOperator070,
        CustomOperator071,
        CustomOperator072,
        CustomOperator073,
        CustomOperator074,
        CustomOperator075,
        CustomOperator076,
        CustomOperator077,
        CustomOperator078,
        CustomOperator079,
        CustomOperator080,
        CustomOperator081,
        CustomOperator082,
        CustomOperator083,
        CustomOperator084,
        CustomOperator085,
        CustomOperator086,
        CustomOperator087,
        CustomOperator088,
        CustomOperator089,
        CustomOperator090,
        CustomOperator091,
        CustomOperator092,
        CustomOperator093,
        CustomOperator094,
        CustomOperator095,
        CustomOperator096,
        CustomOperator097,
        CustomOperator098,
        CustomOperator099,
        CustomOperator100,
        CustomOperator101,
        CustomOperator102,
        CustomOperator103,
        CustomOperator104,
        CustomOperator105,
        CustomOperator106,
        CustomOperator107,
        CustomOperator108,
        CustomOperator109,
        CustomOperator110,
        CustomOperator111,
        CustomOperator112,
        CustomOperator113,
        CustomOperator114,
        CustomOperator115,
        CustomOperator116,
        CustomOperator117,
        CustomOperator118,
        CustomOperator119,
        CustomOperator120,
        CustomOperator121,
        CustomOperator122,
        CustomOperator123,
        CustomOperator124,
        CustomOperator125,
        CustomOperator126,
        CustomOperator127,
        CustomOperator128,
        CustomOperator129,
        CustomOperator130,
        CustomOperator131,
        CustomOperator132,
        CustomOperator133,
        CustomOperator134,
        CustomOperator135,
        CustomOperator136,
        CustomOperator137,
        CustomOperator138,
        CustomOperator139,
        CustomOperator140,
        CustomOperator141,
        CustomOperator142,
        CustomOperator143,
        CustomOperator144,
        CustomOperator145,
        CustomOperator146,
        CustomOperator147,
        CustomOperator148,
        CustomOperator149,
        CustomOperator150,
        CustomOperator151,
        CustomOperator152,
        CustomOperator153,
        CustomOperator154,
        CustomOperator155,
        CustomOperator156,
        CustomOperator157,
        CustomOperator158,
        CustomOperator159,
        CustomOperator160,
        CustomOperator161,
        CustomOperator162,
        CustomOperator163,
        CustomOperator164,
        CustomOperator165,
        CustomOperator166,
        CustomOperator167,
        CustomOperator168,
        CustomOperator169,
        CustomOperator170,
        CustomOperator171,
        CustomOperator172,
        CustomOperator173,
        CustomOperator174,
        CustomOperator175,
        CustomOperator176,
        CustomOperator177,
        CustomOperator178,
        CustomOperator179,
        CustomOperator180,
        CustomOperator181,
        CustomOperator182,
        CustomOperator183,
        CustomOperator184,
        CustomOperator185,
        CustomOperator186,
        CustomOperator187,
        CustomOperator188,
        CustomOperator189,
        CustomOperator190,
        CustomOperator191,
        CustomOperator192,
        CustomOperator193,
        CustomOperator194,
        CustomOperator195,
        CustomOperator196,
        CustomOperator197,
        CustomOperator198,
        CustomOperator199,
        CustomOperator200,
        CustomOperator201,
        CustomOperator202,
        CustomOperator203,
        CustomOperator204,
        CustomOperator205,
        CustomOperator206,
        CustomOperator207,
        CustomOperator208,
        CustomOperator209,
        CustomOperator210,
        CustomOperator211,
        CustomOperator212,
        CustomOperator213,
        CustomOperator214,
        CustomOperator215,
        CustomOperator216,
        CustomOperator217,
        CustomOperator218,
        CustomOperator219,
        CustomOperator220,
        CustomOperator221,
        CustomOperator222,
        CustomOperator223,
        CustomOperator224,
        CustomOperator225,
        CustomOperator226,
        CustomOperator227,
        CustomOperator228,
        CustomOperator229,
        CustomOperator230,
        CustomOperator231,
        CustomOperator232,
        CustomOperator233,
        CustomOperator234,
        CustomOperator235,
        CustomOperator236,
        CustomOperator237,
        CustomOperator238,
        CustomOperator239,
        CustomOperator240,
        CustomOperator241,
        CustomOperator242,
        CustomOperator243,
        CustomOperator244,
        CustomOperator245,
        CustomOperator246,
        CustomOperator247,
        CustomOperator248,
        CustomOperator249,
        CustomOperator250,
        CustomOperator251,
        CustomOperator252,
        CustomOperator253,
        CustomOperator254,
        CustomOperator255,
        CustomOperator256,
        CustomOperator257,
        CustomOperator258,
        CustomOperator259,
        CustomOperator260,
        CustomOperator261,
        CustomOperator262,
        CustomOperator263,
        CustomOperator264,
        CustomOperator265,
        CustomOperator266,
        CustomOperator267,
        CustomOperator268,
        CustomOperator269,
        CustomOperator270,
        CustomOperator271,
        CustomOperator272,
        CustomOperator273,
        CustomOperator274,
        CustomOperator275,
        CustomOperator276,
        CustomOperator277,
        CustomOperator278,
        CustomOperator279,
        CustomOperator280,
        CustomOperator281,
        CustomOperator282,
        CustomOperator283,
        CustomOperator284,
        CustomOperator285,
        CustomOperator286,
        CustomOperator287,
        CustomOperator288,
        CustomOperator289,
        CustomOperator290,
        CustomOperator291,
        CustomOperator292,
        CustomOperator293,
        CustomOperator294,
        CustomOperator295,
        CustomOperator296,
        CustomOperator297,
        CustomOperator298,
        CustomOperator299,
        CustomOperator300,
        CustomOperator301,
        CustomOperator302,
        CustomOperator303,
        CustomOperator304,
        CustomOperator305,
        CustomOperator306,
        CustomOperator307,
        CustomOperator308,
        CustomOperator309,
        CustomOperator310,
        CustomOperator311,
        CustomOperator312,
        CustomOperator313,
        CustomOperator314,
        CustomOperator315,
        CustomOperator316,
        CustomOperator317,
        CustomOperator318,
        CustomOperator319,
        CustomOperator320,
        CustomOperator321,
        CustomOperator322,
        CustomOperator323,
        CustomOperator324,
        CustomOperator325,
        CustomOperator326,
        CustomOperator327,
        CustomOperator328,
        CustomOperator329,
        CustomOperator330,
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
        FunctionOperator,
        GatorCloseOperator,
        GatorEmitOperator,
        GatorOpenOperator,
        GreaterThanOperator,
        GreaterThanOrEqualOperator,
        HexNumber,
        Identifier,
        ifKeyword,
        ImplicitArgumentOperator,
        ImplicitArgumentsOperator,
        IncrementOperator,
        inKeyword,
        InteropOperator,
        LeftBrace,
        LeftBracket,
        LeftParenthesis,
        LessThanOperator,
        LessThanOrEqualOperator,
        loadKeyword,
        LoadLibraryOperator,
        LoadScriptOperator,
        MemberOperator,
        MinusEqualOperator,
        MinusOperator,
        ModulusEqualOperator,
        ModulusOperator,
        MultiplicationEqualOperator,
        MultiplicationOperator,
        newKeyword,
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
        Text,
        thisKeyword,
        trueKeyword,
        tryKeyword,
        Unknown,
        usingKeyword,
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
                TokenType == AphidTokenType.continueKeyword ||
                TokenType == AphidTokenType.breakKeyword ||
                TokenType == AphidTokenType.retKeyword ||
                TokenType == AphidTokenType.thisKeyword ||
                TokenType == AphidTokenType.newKeyword ||
                TokenType == AphidTokenType.usingKeyword ||
                TokenType == AphidTokenType.loadKeyword ||
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
                        case '%':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '>':

                                        mode = 1;
                                        return AphidTokenType.GatorCloseOperator;

                                    case '=':

                                        return AphidTokenType.ModulusEqualOperator;

                                    case '%':

                                        return AphidTokenType.InteropOperator;

                                    case '`':

                                        return AphidTokenType.CustomOperator074;

                                    case '~':

                                        return AphidTokenType.CustomOperator075;

                                    case '!':

                                        return AphidTokenType.CustomOperator076;

                                    case '#':

                                        return AphidTokenType.CustomOperator077;

                                    case '^':

                                        return AphidTokenType.CustomOperator078;

                                    case '&':

                                        return AphidTokenType.CustomOperator079;

                                    case '*':

                                        return AphidTokenType.CustomOperator080;

                                    case '-':

                                        return AphidTokenType.CustomOperator081;

                                    case '\\':

                                        return AphidTokenType.CustomOperator082;

                                    case '+':

                                        return AphidTokenType.CustomOperator083;

                                    case ':':

                                        return AphidTokenType.CustomOperator084;

                                    case '<':

                                        return AphidTokenType.CustomOperator085;

                                    case '.':

                                        return AphidTokenType.CustomOperator086;

                                    case '|':

                                        return AphidTokenType.CustomOperator087;

                                    case '/':

                                        return AphidTokenType.CustomOperator088;

                                    case '?':

                                        return AphidTokenType.CustomOperator089;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.ModulusOperator;

                        case '#':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '#':

                                        return AphidTokenType.LoadLibraryOperator;

                                    case '`':

                                        return AphidTokenType.CustomOperator056;

                                    case '~':

                                        return AphidTokenType.CustomOperator057;

                                    case '!':

                                        return AphidTokenType.CustomOperator058;

                                    case '%':

                                        return AphidTokenType.CustomOperator059;

                                    case '^':

                                        return AphidTokenType.CustomOperator060;

                                    case '&':

                                        return AphidTokenType.CustomOperator061;

                                    case '*':

                                        return AphidTokenType.CustomOperator062;

                                    case '-':

                                        return AphidTokenType.CustomOperator063;

                                    case '=':

                                        return AphidTokenType.CustomOperator064;

                                    case '\\':

                                        return AphidTokenType.CustomOperator065;

                                    case '+':

                                        return AphidTokenType.CustomOperator066;

                                    case ':':

                                        return AphidTokenType.CustomOperator067;

                                    case '<':

                                        return AphidTokenType.CustomOperator068;

                                    case '>':

                                        return AphidTokenType.CustomOperator069;

                                    case '.':

                                        return AphidTokenType.CustomOperator070;

                                    case '|':

                                        return AphidTokenType.CustomOperator071;

                                    case '/':

                                        return AphidTokenType.CustomOperator072;

                                    case '?':

                                        return AphidTokenType.CustomOperator073;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.LoadScriptOperator;

                        case ',':

                            return AphidTokenType.Comma;

                        case ':':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '`':

                                        return AphidTokenType.CustomOperator210;

                                    case '~':

                                        return AphidTokenType.CustomOperator211;

                                    case '!':

                                        return AphidTokenType.CustomOperator212;

                                    case '#':

                                        return AphidTokenType.CustomOperator213;

                                    case '%':

                                        return AphidTokenType.CustomOperator214;

                                    case '^':

                                        return AphidTokenType.CustomOperator215;

                                    case '&':

                                        return AphidTokenType.CustomOperator216;

                                    case '*':

                                        return AphidTokenType.CustomOperator217;

                                    case '-':

                                        return AphidTokenType.CustomOperator218;

                                    case '=':

                                        return AphidTokenType.CustomOperator219;

                                    case '\\':

                                        return AphidTokenType.CustomOperator220;

                                    case '+':

                                        return AphidTokenType.CustomOperator221;

                                    case ':':

                                        return AphidTokenType.CustomOperator222;

                                    case '<':

                                        return AphidTokenType.CustomOperator223;

                                    case '>':

                                        return AphidTokenType.CustomOperator224;

                                    case '.':

                                        return AphidTokenType.CustomOperator225;

                                    case '|':

                                        return AphidTokenType.CustomOperator226;

                                    case '/':

                                        return AphidTokenType.CustomOperator227;

                                    case '?':

                                        return AphidTokenType.CustomOperator228;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.ColonOperator;

                        case '@':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '>':

                                        return AphidTokenType.CompositionOperator;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.FunctionOperator;

                        case '?':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '`':

                                        return AphidTokenType.CustomOperator312;

                                    case '~':

                                        return AphidTokenType.CustomOperator313;

                                    case '!':

                                        return AphidTokenType.CustomOperator314;

                                    case '#':

                                        return AphidTokenType.CustomOperator315;

                                    case '%':

                                        return AphidTokenType.CustomOperator316;

                                    case '^':

                                        return AphidTokenType.CustomOperator317;

                                    case '&':

                                        return AphidTokenType.CustomOperator318;

                                    case '*':

                                        return AphidTokenType.CustomOperator319;

                                    case '-':

                                        return AphidTokenType.CustomOperator320;

                                    case '=':

                                        return AphidTokenType.CustomOperator321;

                                    case '\\':

                                        return AphidTokenType.CustomOperator322;

                                    case '+':

                                        return AphidTokenType.CustomOperator323;

                                    case ':':

                                        return AphidTokenType.CustomOperator324;

                                    case '<':

                                        return AphidTokenType.CustomOperator325;

                                    case '>':

                                        return AphidTokenType.CustomOperator326;

                                    case '.':

                                        return AphidTokenType.CustomOperator327;

                                    case '|':

                                        return AphidTokenType.CustomOperator328;

                                    case '/':

                                        return AphidTokenType.CustomOperator329;

                                    case '?':

                                        return AphidTokenType.CustomOperator330;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.ConditionalOperator;

                        case '.':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '.':

                                        return AphidTokenType.RangeOperator;

                                    case '`':

                                        return AphidTokenType.CustomOperator262;

                                    case '~':

                                        return AphidTokenType.CustomOperator263;

                                    case '!':

                                        return AphidTokenType.CustomOperator264;

                                    case '#':

                                        return AphidTokenType.CustomOperator265;

                                    case '%':

                                        return AphidTokenType.CustomOperator266;

                                    case '^':

                                        return AphidTokenType.CustomOperator267;

                                    case '&':

                                        return AphidTokenType.CustomOperator268;

                                    case '*':

                                        return AphidTokenType.CustomOperator269;

                                    case '-':

                                        return AphidTokenType.CustomOperator270;

                                    case '=':

                                        return AphidTokenType.CustomOperator271;

                                    case '\\':

                                        return AphidTokenType.CustomOperator272;

                                    case '+':

                                        return AphidTokenType.CustomOperator273;

                                    case ':':

                                        return AphidTokenType.CustomOperator274;

                                    case '<':

                                        return AphidTokenType.CustomOperator275;

                                    case '>':

                                        return AphidTokenType.CustomOperator276;

                                    case '|':

                                        return AphidTokenType.CustomOperator277;

                                    case '/':

                                        return AphidTokenType.CustomOperator278;

                                    case '?':

                                        return AphidTokenType.CustomOperator279;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator157;

                                    case '~':

                                        return AphidTokenType.CustomOperator158;

                                    case '!':

                                        return AphidTokenType.CustomOperator159;

                                    case '#':

                                        return AphidTokenType.CustomOperator160;

                                    case '%':

                                        return AphidTokenType.CustomOperator161;

                                    case '^':

                                        return AphidTokenType.CustomOperator162;

                                    case '&':

                                        return AphidTokenType.CustomOperator163;

                                    case '*':

                                        return AphidTokenType.CustomOperator164;

                                    case '-':

                                        return AphidTokenType.CustomOperator165;

                                    case '\\':

                                        return AphidTokenType.CustomOperator166;

                                    case '+':

                                        return AphidTokenType.CustomOperator167;

                                    case ':':

                                        return AphidTokenType.CustomOperator168;

                                    case '<':

                                        return AphidTokenType.CustomOperator169;

                                    case '>':

                                        return AphidTokenType.CustomOperator170;

                                    case '.':

                                        return AphidTokenType.CustomOperator171;

                                    case '|':

                                        return AphidTokenType.CustomOperator172;

                                    case '/':

                                        return AphidTokenType.CustomOperator173;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator143;

                                    case '~':

                                        return AphidTokenType.CustomOperator144;

                                    case '!':

                                        return AphidTokenType.CustomOperator145;

                                    case '#':

                                        return AphidTokenType.CustomOperator146;

                                    case '%':

                                        return AphidTokenType.CustomOperator147;

                                    case '^':

                                        return AphidTokenType.CustomOperator148;

                                    case '&':

                                        return AphidTokenType.CustomOperator149;

                                    case '*':

                                        return AphidTokenType.CustomOperator150;

                                    case '\\':

                                        return AphidTokenType.CustomOperator151;

                                    case '+':

                                        return AphidTokenType.CustomOperator152;

                                    case ':':

                                        return AphidTokenType.CustomOperator153;

                                    case '.':

                                        return AphidTokenType.CustomOperator154;

                                    case '|':

                                        return AphidTokenType.CustomOperator155;

                                    case '/':

                                        return AphidTokenType.CustomOperator156;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator194;

                                    case '~':

                                        return AphidTokenType.CustomOperator195;

                                    case '!':

                                        return AphidTokenType.CustomOperator196;

                                    case '#':

                                        return AphidTokenType.CustomOperator197;

                                    case '%':

                                        return AphidTokenType.CustomOperator198;

                                    case '^':

                                        return AphidTokenType.CustomOperator199;

                                    case '&':

                                        return AphidTokenType.CustomOperator200;

                                    case '*':

                                        return AphidTokenType.CustomOperator201;

                                    case '-':

                                        return AphidTokenType.CustomOperator202;

                                    case '\\':

                                        return AphidTokenType.CustomOperator203;

                                    case ':':

                                        return AphidTokenType.CustomOperator204;

                                    case '<':

                                        return AphidTokenType.CustomOperator205;

                                    case '.':

                                        return AphidTokenType.CustomOperator206;

                                    case '|':

                                        return AphidTokenType.CustomOperator207;

                                    case '/':

                                        return AphidTokenType.CustomOperator208;

                                    case '?':

                                        return AphidTokenType.CustomOperator209;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator125;

                                    case '~':

                                        return AphidTokenType.CustomOperator126;

                                    case '!':

                                        return AphidTokenType.CustomOperator127;

                                    case '#':

                                        return AphidTokenType.CustomOperator128;

                                    case '%':

                                        return AphidTokenType.CustomOperator129;

                                    case '^':

                                        return AphidTokenType.CustomOperator130;

                                    case '&':

                                        return AphidTokenType.CustomOperator131;

                                    case '*':

                                        return AphidTokenType.CustomOperator132;

                                    case '-':

                                        return AphidTokenType.CustomOperator133;

                                    case '\\':

                                        return AphidTokenType.CustomOperator134;

                                    case '+':

                                        return AphidTokenType.CustomOperator135;

                                    case ':':

                                        return AphidTokenType.CustomOperator136;

                                    case '<':

                                        return AphidTokenType.CustomOperator137;

                                    case '>':

                                        return AphidTokenType.CustomOperator138;

                                    case '.':

                                        return AphidTokenType.CustomOperator139;

                                    case '|':

                                        return AphidTokenType.CustomOperator140;

                                    case '/':

                                        return AphidTokenType.CustomOperator141;

                                    case '?':

                                        return AphidTokenType.CustomOperator142;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator296;

                                    case '~':

                                        return AphidTokenType.CustomOperator297;

                                    case '!':

                                        return AphidTokenType.CustomOperator298;

                                    case '#':

                                        return AphidTokenType.CustomOperator299;

                                    case '%':

                                        return AphidTokenType.CustomOperator300;

                                    case '^':

                                        return AphidTokenType.CustomOperator301;

                                    case '&':

                                        return AphidTokenType.CustomOperator302;

                                    case '-':

                                        return AphidTokenType.CustomOperator303;

                                    case '\\':

                                        return AphidTokenType.CustomOperator304;

                                    case '+':

                                        return AphidTokenType.CustomOperator305;

                                    case ':':

                                        return AphidTokenType.CustomOperator306;

                                    case '<':

                                        return AphidTokenType.CustomOperator307;

                                    case '>':

                                        return AphidTokenType.CustomOperator308;

                                    case '.':

                                        return AphidTokenType.CustomOperator309;

                                    case '|':

                                        return AphidTokenType.CustomOperator310;

                                    case '?':

                                        return AphidTokenType.CustomOperator311;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.DivisionOperator;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator108;

                                    case '~':

                                        return AphidTokenType.CustomOperator109;

                                    case '!':

                                        return AphidTokenType.CustomOperator110;

                                    case '#':

                                        return AphidTokenType.CustomOperator111;

                                    case '%':

                                        return AphidTokenType.CustomOperator112;

                                    case '^':

                                        return AphidTokenType.CustomOperator113;

                                    case '*':

                                        return AphidTokenType.CustomOperator114;

                                    case '-':

                                        return AphidTokenType.CustomOperator115;

                                    case '\\':

                                        return AphidTokenType.CustomOperator116;

                                    case '+':

                                        return AphidTokenType.CustomOperator117;

                                    case ':':

                                        return AphidTokenType.CustomOperator118;

                                    case '<':

                                        return AphidTokenType.CustomOperator119;

                                    case '>':

                                        return AphidTokenType.CustomOperator120;

                                    case '.':

                                        return AphidTokenType.CustomOperator121;

                                    case '|':

                                        return AphidTokenType.CustomOperator122;

                                    case '/':

                                        return AphidTokenType.CustomOperator123;

                                    case '?':

                                        return AphidTokenType.CustomOperator124;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator280;

                                    case '~':

                                        return AphidTokenType.CustomOperator281;

                                    case '!':

                                        return AphidTokenType.CustomOperator282;

                                    case '#':

                                        return AphidTokenType.CustomOperator283;

                                    case '%':

                                        return AphidTokenType.CustomOperator284;

                                    case '^':

                                        return AphidTokenType.CustomOperator285;

                                    case '&':

                                        return AphidTokenType.CustomOperator286;

                                    case '*':

                                        return AphidTokenType.CustomOperator287;

                                    case '-':

                                        return AphidTokenType.CustomOperator288;

                                    case '\\':

                                        return AphidTokenType.CustomOperator289;

                                    case '+':

                                        return AphidTokenType.CustomOperator290;

                                    case ':':

                                        return AphidTokenType.CustomOperator291;

                                    case '<':

                                        return AphidTokenType.CustomOperator292;

                                    case '.':

                                        return AphidTokenType.CustomOperator293;

                                    case '/':

                                        return AphidTokenType.CustomOperator294;

                                    case '?':

                                        return AphidTokenType.CustomOperator295;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator090;

                                    case '~':

                                        return AphidTokenType.CustomOperator091;

                                    case '!':

                                        return AphidTokenType.CustomOperator092;

                                    case '#':

                                        return AphidTokenType.CustomOperator093;

                                    case '%':

                                        return AphidTokenType.CustomOperator094;

                                    case '^':

                                        return AphidTokenType.CustomOperator095;

                                    case '&':

                                        return AphidTokenType.CustomOperator096;

                                    case '*':

                                        return AphidTokenType.CustomOperator097;

                                    case '-':

                                        return AphidTokenType.CustomOperator098;

                                    case '\\':

                                        return AphidTokenType.CustomOperator099;

                                    case '+':

                                        return AphidTokenType.CustomOperator100;

                                    case ':':

                                        return AphidTokenType.CustomOperator101;

                                    case '<':

                                        return AphidTokenType.CustomOperator102;

                                    case '>':

                                        return AphidTokenType.CustomOperator103;

                                    case '.':

                                        return AphidTokenType.CustomOperator104;

                                    case '|':

                                        return AphidTokenType.CustomOperator105;

                                    case '/':

                                        return AphidTokenType.CustomOperator106;

                                    case '?':

                                        return AphidTokenType.CustomOperator107;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator229;

                                    case '~':

                                        return AphidTokenType.CustomOperator230;

                                    case '!':

                                        return AphidTokenType.CustomOperator231;

                                    case '#':

                                        return AphidTokenType.CustomOperator232;

                                    case '%':

                                        return AphidTokenType.CustomOperator233;

                                    case '^':

                                        return AphidTokenType.CustomOperator234;

                                    case '&':

                                        return AphidTokenType.CustomOperator235;

                                    case '*':

                                        return AphidTokenType.CustomOperator236;

                                    case '-':

                                        return AphidTokenType.CustomOperator237;

                                    case '\\':

                                        return AphidTokenType.CustomOperator238;

                                    case '+':

                                        return AphidTokenType.CustomOperator239;

                                    case ':':

                                        return AphidTokenType.CustomOperator240;

                                    case '.':

                                        return AphidTokenType.CustomOperator241;

                                    case '|':

                                        return AphidTokenType.CustomOperator242;

                                    case '/':

                                        return AphidTokenType.CustomOperator243;

                                    case '?':

                                        return AphidTokenType.CustomOperator244;

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

                                    case '`':

                                        return AphidTokenType.CustomOperator245;

                                    case '~':

                                        return AphidTokenType.CustomOperator246;

                                    case '!':

                                        return AphidTokenType.CustomOperator247;

                                    case '#':

                                        return AphidTokenType.CustomOperator248;

                                    case '%':

                                        return AphidTokenType.CustomOperator249;

                                    case '^':

                                        return AphidTokenType.CustomOperator250;

                                    case '&':

                                        return AphidTokenType.CustomOperator251;

                                    case '*':

                                        return AphidTokenType.CustomOperator252;

                                    case '-':

                                        return AphidTokenType.CustomOperator253;

                                    case '\\':

                                        return AphidTokenType.CustomOperator254;

                                    case '+':

                                        return AphidTokenType.CustomOperator255;

                                    case ':':

                                        return AphidTokenType.CustomOperator256;

                                    case '<':

                                        return AphidTokenType.CustomOperator257;

                                    case '.':

                                        return AphidTokenType.CustomOperator258;

                                    case '|':

                                        return AphidTokenType.CustomOperator259;

                                    case '/':

                                        return AphidTokenType.CustomOperator260;

                                    case '?':

                                        return AphidTokenType.CustomOperator261;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.GreaterThanOperator;

                        case '~':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '`':

                                        return AphidTokenType.CustomOperator020;

                                    case '~':

                                        return AphidTokenType.CustomOperator021;

                                    case '!':

                                        return AphidTokenType.CustomOperator022;

                                    case '#':

                                        return AphidTokenType.CustomOperator023;

                                    case '%':

                                        return AphidTokenType.CustomOperator024;

                                    case '^':

                                        return AphidTokenType.CustomOperator025;

                                    case '&':

                                        return AphidTokenType.CustomOperator026;

                                    case '*':

                                        return AphidTokenType.CustomOperator027;

                                    case '-':

                                        return AphidTokenType.CustomOperator028;

                                    case '=':

                                        return AphidTokenType.CustomOperator029;

                                    case '\\':

                                        return AphidTokenType.CustomOperator030;

                                    case '+':

                                        return AphidTokenType.CustomOperator031;

                                    case ':':

                                        return AphidTokenType.CustomOperator032;

                                    case '<':

                                        return AphidTokenType.CustomOperator033;

                                    case '>':

                                        return AphidTokenType.CustomOperator034;

                                    case '.':

                                        return AphidTokenType.CustomOperator035;

                                    case '|':

                                        return AphidTokenType.CustomOperator036;

                                    case '/':

                                        return AphidTokenType.CustomOperator037;

                                    case '?':

                                        return AphidTokenType.CustomOperator038;

                                }

                                charIndex--;
                            }
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

                                    case '`':

                                        return AphidTokenType.CustomOperator039;

                                    case '~':

                                        return AphidTokenType.CustomOperator040;

                                    case '!':

                                        return AphidTokenType.CustomOperator041;

                                    case '#':

                                        return AphidTokenType.CustomOperator042;

                                    case '%':

                                        return AphidTokenType.CustomOperator043;

                                    case '^':

                                        return AphidTokenType.CustomOperator044;

                                    case '&':

                                        return AphidTokenType.CustomOperator045;

                                    case '*':

                                        return AphidTokenType.CustomOperator046;

                                    case '-':

                                        return AphidTokenType.CustomOperator047;

                                    case '\\':

                                        return AphidTokenType.CustomOperator048;

                                    case '+':

                                        return AphidTokenType.CustomOperator049;

                                    case ':':

                                        return AphidTokenType.CustomOperator050;

                                    case '<':

                                        return AphidTokenType.CustomOperator051;

                                    case '>':

                                        return AphidTokenType.CustomOperator052;

                                    case '.':

                                        return AphidTokenType.CustomOperator053;

                                    case '|':

                                        return AphidTokenType.CustomOperator054;

                                    case '/':

                                        return AphidTokenType.CustomOperator055;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.NotOperator;

                        case '$':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '_':

                                        return AphidTokenType.ImplicitArgumentOperator;

                                    case 'a':
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
                                                            case 'g':
                                                                if (charIndex < lastIndex)
                                                                {
                                                                    currentChar = text[++charIndex];

                                                                    switch (currentChar)
                                                                    {
                                                                        case 's':

                                                                            return AphidTokenType.ImplicitArgumentsOperator;

                                                                    }

                                                                    charIndex--;
                                                                }

                                                                break;

                                                        }

                                                        charIndex--;
                                                    }

                                                    break;

                                            }

                                            charIndex--;
                                        }

                                        break;

                                }

                                charIndex--;
                            }
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

                        case '`':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '`':

                                        return AphidTokenType.CustomOperator000;

                                    case '~':

                                        return AphidTokenType.CustomOperator001;

                                    case '!':

                                        return AphidTokenType.CustomOperator002;

                                    case '#':

                                        return AphidTokenType.CustomOperator003;

                                    case '%':

                                        return AphidTokenType.CustomOperator004;

                                    case '^':

                                        return AphidTokenType.CustomOperator005;

                                    case '&':

                                        return AphidTokenType.CustomOperator006;

                                    case '*':

                                        return AphidTokenType.CustomOperator007;

                                    case '-':

                                        return AphidTokenType.CustomOperator008;

                                    case '=':

                                        return AphidTokenType.CustomOperator009;

                                    case '\\':

                                        return AphidTokenType.CustomOperator010;

                                    case '+':

                                        return AphidTokenType.CustomOperator011;

                                    case ':':

                                        return AphidTokenType.CustomOperator012;

                                    case '<':

                                        return AphidTokenType.CustomOperator013;

                                    case '>':

                                        return AphidTokenType.CustomOperator014;

                                    case '.':

                                        return AphidTokenType.CustomOperator015;

                                    case '|':

                                        return AphidTokenType.CustomOperator016;

                                    case '/':

                                        return AphidTokenType.CustomOperator017;

                                    case '?':

                                        return AphidTokenType.CustomOperator018;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.CustomOperator019;

                        case '\\':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case '`':

                                        return AphidTokenType.CustomOperator174;

                                    case '~':

                                        return AphidTokenType.CustomOperator175;

                                    case '!':

                                        return AphidTokenType.CustomOperator176;

                                    case '#':

                                        return AphidTokenType.CustomOperator177;

                                    case '%':

                                        return AphidTokenType.CustomOperator178;

                                    case '^':

                                        return AphidTokenType.CustomOperator179;

                                    case '&':

                                        return AphidTokenType.CustomOperator180;

                                    case '*':

                                        return AphidTokenType.CustomOperator181;

                                    case '-':

                                        return AphidTokenType.CustomOperator182;

                                    case '=':

                                        return AphidTokenType.CustomOperator183;

                                    case '\\':

                                        return AphidTokenType.CustomOperator184;

                                    case '+':

                                        return AphidTokenType.CustomOperator185;

                                    case ':':

                                        return AphidTokenType.CustomOperator186;

                                    case '<':

                                        return AphidTokenType.CustomOperator187;

                                    case '>':

                                        return AphidTokenType.CustomOperator188;

                                    case '.':

                                        return AphidTokenType.CustomOperator189;

                                    case '|':

                                        return AphidTokenType.CustomOperator190;

                                    case '/':

                                        return AphidTokenType.CustomOperator191;

                                    case '?':

                                        return AphidTokenType.CustomOperator192;

                                }

                                charIndex--;
                            }
                            return AphidTokenType.CustomOperator193;

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

                                    case 'e':
                                        if (charIndex < lastIndex)
                                        {
                                            currentChar = text[++charIndex];

                                            switch (currentChar)
                                            {
                                                case 'w':


                                                    if (!NextChar())
                                                    {
                                                        return AphidTokenType.newKeyword;
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

                                                            return AphidTokenType.newKeyword;
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

                        case 'c':
                            if (charIndex < lastIndex)
                            {
                                currentChar = text[++charIndex];

                                switch (currentChar)
                                {
                                    case 'o':
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
                                                            case 't':
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
                                                                                                            case 'e':


                                                                                                                if (!NextChar())
                                                                                                                {
                                                                                                                    return AphidTokenType.continueKeyword;
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

                                                                                                                        return AphidTokenType.continueKeyword;
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

                        case 'u':
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
                                                                        case 'g':


                                                                            if (!NextChar())
                                                                            {
                                                                                return AphidTokenType.usingKeyword;
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

                                                                                    return AphidTokenType.usingKeyword;
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
                                    case 'o':
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
                                                            case 'd':


                                                                if (!NextChar())
                                                                {
                                                                    return AphidTokenType.loadKeyword;
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

                                                                        return AphidTokenType.loadKeyword;
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
            else
                if (mode == 1)
                {
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
                                        case '%':
                                            if (charIndex < lastIndex)
                                            {
                                                currentChar = text[++charIndex];

                                                switch (currentChar)
                                                {
                                                    case '=':

                                                        mode = 0;
                                                        return AphidTokenType.GatorEmitOperator;

                                                }

                                                charIndex--;
                                            }
                                            mode = 0;
                                            return AphidTokenType.GatorOpenOperator;

                                    }

                                    charIndex--;
                                }

                                while (NextChar())
                                {
                                    if (currentChar == '<')
                                    {
                                        charIndex--;

                                        return AphidTokenType.Text;
                                    }
                                }

                                return AphidTokenType.Text;

                                break;

                            default:

                                while (NextChar())
                                {
                                    if (currentChar == '<')
                                    {
                                        charIndex--;

                                        return AphidTokenType.Text;
                                    }
                                }

                                return AphidTokenType.Text;

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