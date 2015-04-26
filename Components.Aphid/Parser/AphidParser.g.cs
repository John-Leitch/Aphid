namespace Components.Aphid.Parser {
    using Components.Aphid.Lexer;
    using System.Linq;
    using System.Collections.Generic;
    
    
    public enum AphidExpressionType {
        
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
    
    public partial class ArrayAccessExpression : AphidExpression, IParentNode {
        
        private AphidExpression _arrayExpression;
        
        private AphidExpression _keyExpression;
        
        public ArrayAccessExpression(AphidExpression arrayExpression, AphidExpression keyExpression) {
            _arrayExpression = arrayExpression;
            _keyExpression = keyExpression;
        }
        
        public AphidExpression ArrayExpression {
            get {
                return _arrayExpression;
            }
        }
        
        public AphidExpression KeyExpression {
            get {
                return _keyExpression;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ArrayAccessExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    ArrayExpression,
                    KeyExpression};
        }
    }
    
    public partial class ArrayExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _elements;
        
        public ArrayExpression(System.Collections.Generic.List<AphidExpression> elements) {
            _elements = elements;
        }
        
        public System.Collections.Generic.List<AphidExpression> Elements {
            get {
                return _elements;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ArrayExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Elements.ToArray();
        }
    }
    
    public partial class BinaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidExpression _leftOperand;
        
        private AphidTokenType _operator;
        
        private AphidExpression _rightOperand;
        
        public BinaryOperatorExpression(AphidExpression leftOperand, AphidTokenType @operator, AphidExpression rightOperand) {
            _leftOperand = leftOperand;
            _operator = @operator;
            _rightOperand = rightOperand;
        }
        
        public AphidExpression LeftOperand {
            get {
                return _leftOperand;
            }
        }
        
        public AphidTokenType Operator {
            get {
                return _operator;
            }
        }
        
        public AphidExpression RightOperand {
            get {
                return _rightOperand;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BinaryOperatorExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    LeftOperand,
                    RightOperand};
        }
    }
    
    public partial class BooleanExpression : AphidExpression {
        
        private bool _value;
        
        public BooleanExpression(bool value) {
            _value = value;
        }
        
        public bool Value {
            get {
                return _value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BooleanExpression;
            }
        }
    }
    
    public partial class BreakExpression : AphidExpression {
        
        public BreakExpression() {
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BreakExpression;
            }
        }
    }
    
    public partial class CallExpression : AphidExpression, IParentNode {
        
        private AphidExpression _functionExpression;
        
        private System.Collections.Generic.List<AphidExpression> _args;
        
        public CallExpression(AphidExpression functionExpression, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> args) {
            _functionExpression = functionExpression;
            if ((args != null)) {
                _args = args;
            }
            else {
                _args = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        public AphidExpression FunctionExpression {
            get {
                return _functionExpression;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Args {
            get {
                return _args;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.CallExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    FunctionExpression}.Concat(Args).ToArray();
        }
    }
    
    public partial class DoWhileExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public DoWhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            _condition = condition;
            _body = body;
        }
        
        public AphidExpression Condition {
            get {
                return _condition;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.DoWhileExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(Body).ToArray();
        }
    }
    
    public partial class DynamicMemberExpression : AphidExpression, IParentNode {
        
        private AphidExpression _memberExpression;
        
        public DynamicMemberExpression(AphidExpression memberExpression) {
            _memberExpression = memberExpression;
        }
        
        public AphidExpression MemberExpression {
            get {
                return _memberExpression;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.DynamicMemberExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    MemberExpression};
        }
    }
    
    public partial class ExtendExpression : AphidExpression, IParentNode {
        
        private string _extendType;
        
        private ObjectExpression _object;
        
        public ExtendExpression(string extendType, ObjectExpression @object) {
            _extendType = extendType;
            _object = @object;
        }
        
        public string ExtendType {
            get {
                return _extendType;
            }
        }
        
        public ObjectExpression Object {
            get {
                return _object;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ExtendExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Object};
        }
    }
    
    public partial class ForEachExpression : AphidExpression, IParentNode {
        
        private AphidExpression _collection;
        
        private AphidExpression _element;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public ForEachExpression(AphidExpression collection, AphidExpression element, System.Collections.Generic.List<AphidExpression> body) {
            _collection = collection;
            _element = element;
            _body = body;
        }
        
        public AphidExpression Collection {
            get {
                return _collection;
            }
        }
        
        public AphidExpression Element {
            get {
                return _element;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ForEachExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Collection,
                    Element}.Concat(Body).ToArray();
        }
    }
    
    public partial class ForExpression : AphidExpression, IParentNode {
        
        private AphidExpression _initialization;
        
        private AphidExpression _condition;
        
        private AphidExpression _afterthought;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public ForExpression(AphidExpression initialization, AphidExpression condition, AphidExpression afterthought, System.Collections.Generic.List<AphidExpression> body) {
            _initialization = initialization;
            _condition = condition;
            _afterthought = afterthought;
            _body = body;
        }
        
        public AphidExpression Initialization {
            get {
                return _initialization;
            }
        }
        
        public AphidExpression Condition {
            get {
                return _condition;
            }
        }
        
        public AphidExpression Afterthought {
            get {
                return _afterthought;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ForExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Initialization,
                    Condition,
                    Afterthought}.Concat(Body).ToArray();
        }
    }
    
    public partial class FunctionExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _args;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public FunctionExpression(System.Collections.Generic.List<AphidExpression> args, System.Collections.Generic.List<AphidExpression> body) {
            _args = args;
            _body = body;
        }
        
        public System.Collections.Generic.List<AphidExpression> Args {
            get {
                return _args;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.FunctionExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Args.Concat(Body).ToArray();
        }
    }
    
    public partial class IdentifierExpression : AphidExpression, IParentNode {
        
        private string _identifier;
        
        private System.Collections.Generic.List<IdentifierExpression> _attributes;
        
        public IdentifierExpression(string identifier, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<IdentifierExpression> attributes) {
            _identifier = identifier;
            if ((attributes != null)) {
                _attributes = attributes;
            }
            else {
                _attributes = new System.Collections.Generic.List<IdentifierExpression>();
            }
        }
        
        public string Identifier {
            get {
                return _identifier;
            }
        }
        
        public System.Collections.Generic.List<IdentifierExpression> Attributes {
            get {
                return _attributes;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.IdentifierExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Attributes.ToArray();
        }
    }
    
    public partial class IfExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        private System.Collections.Generic.List<AphidExpression> _elseBody;
        
        public IfExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body, System.Collections.Generic.List<AphidExpression> elseBody) {
            _condition = condition;
            _body = body;
            _elseBody = elseBody;
        }
        
        public AphidExpression Condition {
            get {
                return _condition;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> ElseBody {
            get {
                return _elseBody;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.IfExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(Body).Concat(ElseBody).ToArray();
        }
    }
    
    public partial class LoadLibraryExpression : AphidExpression, IParentNode {
        
        private AphidExpression _libraryExpression;
        
        public LoadLibraryExpression(AphidExpression libraryExpression) {
            _libraryExpression = libraryExpression;
        }
        
        public AphidExpression LibraryExpression {
            get {
                return _libraryExpression;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.LoadLibraryExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    LibraryExpression};
        }
    }
    
    public partial class LoadScriptExpression : AphidExpression, IParentNode {
        
        private AphidExpression _fileExpression;
        
        public LoadScriptExpression(AphidExpression fileExpression) {
            _fileExpression = fileExpression;
        }
        
        public AphidExpression FileExpression {
            get {
                return _fileExpression;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.LoadScriptExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    FileExpression};
        }
    }
    
    public partial class NullExpression : AphidExpression {
        
        public NullExpression() {
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.NullExpression;
            }
        }
    }
    
    public partial class NumberExpression : AphidExpression {
        
        private decimal _value;
        
        public NumberExpression(decimal value) {
            _value = value;
        }
        
        public decimal Value {
            get {
                return _value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.NumberExpression;
            }
        }
    }
    
    public partial class ObjectExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<BinaryOperatorExpression> _pairs;
        
        public ObjectExpression(System.Collections.Generic.List<BinaryOperatorExpression> pairs) {
            _pairs = pairs;
        }
        
        public System.Collections.Generic.List<BinaryOperatorExpression> Pairs {
            get {
                return _pairs;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ObjectExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Pairs.ToArray();
        }
    }
    
    public partial class PartialFunctionExpression : AphidExpression, IParentNode {
        
        private CallExpression _call;
        
        public PartialFunctionExpression(CallExpression call) {
            _call = call;
        }
        
        public CallExpression Call {
            get {
                return _call;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PartialFunctionExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Call};
        }
    }
    
    public partial class PatternExpression : AphidExpression, IParentNode {
        
        private AphidExpression _value;
        
        private System.Collections.Generic.List<AphidExpression> _patterns;
        
        public PatternExpression(AphidExpression value, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> patterns) {
            _value = value;
            if ((patterns != null)) {
                _patterns = patterns;
            }
            else {
                _patterns = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        public AphidExpression Value {
            get {
                return _value;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Patterns {
            get {
                return _patterns;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PatternExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Value}.Concat(Patterns).ToArray();
        }
    }
    
    public partial class PatternMatchingExpression : AphidExpression, IParentNode {
        
        private AphidExpression _testExpression;
        
        private System.Collections.Generic.List<PatternExpression> _patterns;
        
        public PatternMatchingExpression(AphidExpression testExpression, System.Collections.Generic.List<PatternExpression> patterns) {
            _testExpression = testExpression;
            _patterns = patterns;
        }
        
        public AphidExpression TestExpression {
            get {
                return _testExpression;
            }
        }
        
        public System.Collections.Generic.List<PatternExpression> Patterns {
            get {
                return _patterns;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PatternMatchingExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    TestExpression}.Concat(Patterns).ToArray();
        }
    }
    
    public partial class UnaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private AphidExpression _operand;
        
        private bool _isPostfix;
        
        public UnaryOperatorExpression(AphidTokenType @operator, AphidExpression operand, [System.Runtime.InteropServices.OptionalAttribute()] bool isPostfix) {
            _operator = @operator;
            _operand = operand;
            _isPostfix = isPostfix;
        }
        
        public AphidTokenType Operator {
            get {
                return _operator;
            }
        }
        
        public AphidExpression Operand {
            get {
                return _operand;
            }
        }
        
        public bool IsPostfix {
            get {
                return _isPostfix;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.UnaryOperatorExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Operand};
        }
    }
    
    public partial class StringExpression : AphidExpression {
        
        private string _value;
        
        public StringExpression(string value) {
            _value = value;
        }
        
        public string Value {
            get {
                return _value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.StringExpression;
            }
        }
    }
    
    public partial class SwitchCase : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _cases;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public SwitchCase(System.Collections.Generic.List<AphidExpression> cases, System.Collections.Generic.List<AphidExpression> body) {
            _cases = cases;
            _body = body;
        }
        
        public System.Collections.Generic.List<AphidExpression> Cases {
            get {
                return _cases;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.SwitchCase;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Cases.Concat(Body).ToArray();
        }
    }
    
    public partial class SwitchExpression : AphidExpression, IParentNode {
        
        private AphidExpression _expression;
        
        private System.Collections.Generic.List<SwitchCase> _cases;
        
        private System.Collections.Generic.List<AphidExpression> _defaultCase;
        
        public SwitchExpression(AphidExpression expression, System.Collections.Generic.List<SwitchCase> cases, System.Collections.Generic.List<AphidExpression> defaultCase) {
            _expression = expression;
            _cases = cases;
            _defaultCase = defaultCase;
        }
        
        public AphidExpression Expression {
            get {
                return _expression;
            }
        }
        
        public System.Collections.Generic.List<SwitchCase> Cases {
            get {
                return _cases;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> DefaultCase {
            get {
                return _defaultCase;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.SwitchExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Expression}.Concat(Cases).Concat(DefaultCase).ToArray();
        }
    }
    
    public partial class TernaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private AphidExpression _firstOperand;
        
        private AphidExpression _secondOperand;
        
        private AphidExpression _thirdOperand;
        
        public TernaryOperatorExpression(AphidTokenType @operator, AphidExpression firstOperand, AphidExpression secondOperand, AphidExpression thirdOperand) {
            _operator = @operator;
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
            _thirdOperand = thirdOperand;
        }
        
        public AphidTokenType Operator {
            get {
                return _operator;
            }
        }
        
        public AphidExpression FirstOperand {
            get {
                return _firstOperand;
            }
        }
        
        public AphidExpression SecondOperand {
            get {
                return _secondOperand;
            }
        }
        
        public AphidExpression ThirdOperand {
            get {
                return _thirdOperand;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.TernaryOperatorExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    FirstOperand,
                    SecondOperand,
                    ThirdOperand};
        }
    }
    
    public partial class ThisExpression : AphidExpression {
        
        public ThisExpression() {
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ThisExpression;
            }
        }
    }
    
    public partial class TryExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _tryBody;
        
        private IdentifierExpression _catchArg;
        
        private System.Collections.Generic.List<AphidExpression> _catchBody;
        
        private System.Collections.Generic.List<AphidExpression> _finallyBody;
        
        public TryExpression(System.Collections.Generic.List<AphidExpression> tryBody, IdentifierExpression catchArg, System.Collections.Generic.List<AphidExpression> catchBody, System.Collections.Generic.List<AphidExpression> finallyBody) {
            _tryBody = tryBody;
            _catchArg = catchArg;
            _catchBody = catchBody;
            _finallyBody = finallyBody;
        }
        
        public System.Collections.Generic.List<AphidExpression> TryBody {
            get {
                return _tryBody;
            }
        }
        
        public IdentifierExpression CatchArg {
            get {
                return _catchArg;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> CatchBody {
            get {
                return _catchBody;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> FinallyBody {
            get {
                return _finallyBody;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.TryExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    CatchArg}.Concat(TryBody).Concat(CatchBody).Concat(FinallyBody).ToArray();
        }
    }
    
    public partial class WhileExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public WhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            _condition = condition;
            _body = body;
        }
        
        public AphidExpression Condition {
            get {
                return _condition;
            }
        }
        
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.WhileExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(Body).ToArray();
        }
    }
    
    public partial class AphidParser {
        
        public System.Collections.Generic.List<AphidExpression> Parse() {
            var expressionSequence = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            for (
            ; ((_currentToken.TokenType == AphidTokenType.None) 
                        == false); 
            ) {
                expressionSequence.Add(ParseStatement());
            }
            return expressionSequence;
        }
        
        private AphidExpression ParseStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.ifKeyword)) {
                exp = ParseIfExpression();
            }
            else {
                if ((_currentToken.TokenType == AphidTokenType.forKeyword)) {
                    exp = ParseForExpression();
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.whileKeyword)) {
                        exp = ParseWhileExpression();
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.doKeyword)) {
                            exp = ParseDoWhileExpression();
                            if (true) {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else {
                            if ((_currentToken.TokenType == AphidTokenType.extendKeyword)) {
                                exp = ParseExtendExpression();
                            }
                            else {
                                if ((_currentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    exp = ParseTryExpression();
                                }
                                else {
                                    if ((_currentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        exp = ParseSwitchExpression();
                                    }
                                    else {
                                        exp = ParseExpression();
                                        if (true) {
                                            for (
                                            ; (_currentToken.TokenType == AphidTokenType.Comma); 
                                            ) {
                                                NextToken();
                                                exp = new BinaryOperatorExpression(exp, AphidTokenType.Comma, ParseExpression());
                                            }
                                        }
                                        if (true) {
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
        
        private AphidExpression ParseSingleStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.ifKeyword)) {
                exp = ParseIfExpression();
            }
            else {
                if ((_currentToken.TokenType == AphidTokenType.forKeyword)) {
                    exp = ParseForExpression();
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.whileKeyword)) {
                        exp = ParseWhileExpression();
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.doKeyword)) {
                            exp = ParseDoWhileExpression();
                            if (false) {
                                Match(AphidTokenType.EndOfStatement);
                            }
                        }
                        else {
                            if ((_currentToken.TokenType == AphidTokenType.extendKeyword)) {
                                exp = ParseExtendExpression();
                            }
                            else {
                                if ((_currentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    exp = ParseTryExpression();
                                }
                                else {
                                    if ((_currentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        exp = ParseSwitchExpression();
                                    }
                                    else {
                                        exp = ParseExpression();
                                        if (false) {
                                            for (
                                            ; (_currentToken.TokenType == AphidTokenType.Comma); 
                                            ) {
                                                NextToken();
                                                exp = new BinaryOperatorExpression(exp, AphidTokenType.Comma, ParseExpression());
                                            }
                                        }
                                        if (false) {
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
        
        private AphidExpression ParseExpression() {
            return ParseAssignmentExpression();
        }
        
        private AphidExpression ParseAssignmentExpression() {
            var operand = ParsePipelineExpression();
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
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePipelineExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePipelineExpression() {
            var operand = ParseQueryExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.PipelineOperator); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseQueryExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseQueryExpression() {
            var exp = ParseRangeExpression();
            for (
            ; true; 
            ) {
                if ((((((_currentToken.TokenType == AphidTokenType.AggregateOperator) 
                            || (_currentToken.TokenType == AphidTokenType.AnyOperator)) 
                            || (_currentToken.TokenType == AphidTokenType.SelectManyOperator)) 
                            || (_currentToken.TokenType == AphidTokenType.SelectOperator)) 
                            || (_currentToken.TokenType == AphidTokenType.WhereOperator))) {
                    var t = _currentToken.TokenType;
                    NextToken();
                    exp = new BinaryOperatorExpression(exp, t, ParseRangeExpression());
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.DistinctOperator)) {
                        exp = new UnaryOperatorExpression(_currentToken.TokenType, exp);
                        NextToken();
                    }
                    else {
break;
                    }
                }
            }
            return exp;
        }
        
        private AphidExpression ParseRangeExpression() {
            var operand = ParseConditionalExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.RangeOperator); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseConditionalExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseConditionalExpression() {
            var exp = ParseLogicalExpression();
            if ((_currentToken.TokenType == AphidTokenType.ConditionalOperator)) {
                NextToken();
                var trueExpression = ParseExpression();
                Match(AphidTokenType.ColonOperator);
                var falseExpression = ParseExpression();
                return new TernaryOperatorExpression(AphidTokenType.ConditionalOperator, exp, trueExpression, falseExpression);
            }
            else {
                return exp;
            }
        }
        
        private AphidExpression ParseLogicalExpression() {
            var operand = ParseComparisonExpression();
            for (
            ; ((_currentToken.TokenType == AphidTokenType.AndOperator) 
                        || (_currentToken.TokenType == AphidTokenType.OrOperator)); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseComparisonExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseComparisonExpression() {
            var operand = ParsePostfixUnaryOperationExpression();
            for (
            ; ((((((_currentToken.TokenType == AphidTokenType.EqualityOperator) 
                        || (_currentToken.TokenType == AphidTokenType.NotEqualOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.LessThanOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.LessThanOrEqualOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.GreaterThanOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator)); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePostfixUnaryOperationExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePostfixUnaryOperationExpression() {
            var term = ParseBinaryOrExpression();
            if (((_currentToken.TokenType == AphidTokenType.IncrementOperator) 
                        || (_currentToken.TokenType == AphidTokenType.DecrementOperator))) {
                var op = _currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(op, term, true);
            }
            else {
                return term;
            }
        }
        
        private AphidExpression ParseBinaryOrExpression() {
            var operand = ParseXorExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.BinaryOrOperator); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseXorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseXorExpression() {
            var operand = ParseBinaryAndExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.XorOperator); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseBinaryAndExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseBinaryAndExpression() {
            var operand = ParseShiftExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.BinaryAndOperator); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseShiftExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseShiftExpression() {
            var operand = ParseAdditionExpression();
            for (
            ; ((_currentToken.TokenType == AphidTokenType.ShiftLeft) 
                        || (_currentToken.TokenType == AphidTokenType.ShiftRight)); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseAdditionExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseAdditionExpression() {
            var operand = ParseTermExpression();
            for (
            ; ((_currentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (_currentToken.TokenType == AphidTokenType.MinusOperator)); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParseTermExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseTermExpression() {
            var operand = ParsePrefixUnaryOperatorExpression();
            for (
            ; (((_currentToken.TokenType == AphidTokenType.MultiplicationOperator) 
                        || (_currentToken.TokenType == AphidTokenType.DivisionOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.ModulusOperator)); 
            ) {
                var op = _currentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(operand, op, ParsePrefixUnaryOperatorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePrefixUnaryOperatorExpression() {
            if ((((((((_currentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (_currentToken.TokenType == AphidTokenType.MinusOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.NotOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.IncrementOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.DecrementOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.MultiplicationOperator)) 
                        || (_currentToken.TokenType == AphidTokenType.ComplementOperator))) {
                var t = _currentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(t, ParseArrayAccessExpression());
            }
            else {
                return ParseArrayAccessExpression();
            }
        }
        
        private AphidExpression ParseArrayAccessExpression() {
            var exp = ParseCallExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftBracket); 
            ) {
                NextToken();
                var key = ParseExpression();
                Match(AphidTokenType.RightBracket);
                exp = new ArrayAccessExpression(exp, key);
            }
            return exp;
        }
        
        private AphidExpression ParseCallExpression() {
            var function = ParseMemberExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((_currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseMemberExpression() {
            var factor = ParseFactorCallExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.MemberOperator); 
            ) {
                NextToken();
                AphidExpression exp = default(AphidExpression);
                if ((_currentToken.TokenType == AphidTokenType.Identifier)) {
                    exp = new IdentifierExpression(_currentToken.Lexeme);
                    NextToken();
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.String)) {
                        exp = ParseStringExpression();
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.LeftBrace)) {
                            NextToken();
                            exp = new DynamicMemberExpression(ParseExpression());
                            Match(AphidTokenType.RightBrace);
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                factor = new BinaryOperatorExpression(factor, AphidTokenType.MemberOperator, exp);
                for (
                ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis); 
                ) {
                    NextToken();
                    if ((_currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                        NextToken();
                        factor = new CallExpression(factor);
                    }
                    else {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        factor = new CallExpression(factor, args);
                    }
                }
                if ((_currentToken.TokenType == AphidTokenType.definedKeyword)) {
                    NextToken();
                    return new UnaryOperatorExpression(AphidTokenType.definedKeyword, factor, true);
                }
            }
            return factor;
        }
        
        private AphidExpression ParseFactorCallExpression() {
            var function = ParseFactorExpression();
            for (
            ; (_currentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((_currentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseStringExpression() {
            var exp = new StringExpression(_currentToken.Lexeme);
            NextToken();
            return exp;
        }
        
        private IdentifierExpression ParseIdentifierExpression() {
            var exp = new IdentifierExpression(_currentToken.Lexeme);
            NextToken();
            if ((_currentToken.TokenType == AphidTokenType.Identifier)) {
                var id = exp;
                var attrs = new System.Collections.Generic.List<IdentifierExpression>();
                for (
                ; true; 
                ) {
                    attrs.Add(id);
                    id = new IdentifierExpression(_currentToken.Lexeme);
                    NextToken();
                    if (((_currentToken.TokenType == AphidTokenType.Identifier) 
                                == false)) {
break;
                    }
                }
                exp = new IdentifierExpression(id.Identifier, attrs);
            }
            return exp;
        }
        
        private AphidExpression ParseUnaryExpression() {
            var t = _currentToken.TokenType;
            NextToken();
            return new UnaryOperatorExpression(t, ParseExpression());
        }
        
        private AphidExpression ParseCondition() {
            Match(AphidTokenType.LeftParenthesis);
            var condition = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            return condition;
        }
        
        private AphidExpression ParseIfExpression() {
            NextToken();
            var condition = ParseCondition();
            var body = ParseBlock();
            System.Collections.Generic.List<AphidExpression> elseBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((_currentToken.TokenType == AphidTokenType.elseKeyword)) {
                NextToken();
                elseBody = ParseBlock();
            }
            return new IfExpression(condition, body, elseBody);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseBlock() {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((_currentToken.TokenType == AphidTokenType.RightBrace) 
                            == false); 
                ) {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else {
                statements.Add(ParseStatement());
            }
            return statements;
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseSingleBlock() {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((_currentToken.TokenType == AphidTokenType.RightBrace) 
                            == false); 
                ) {
                    statements.Add(ParseStatement());
                }
                NextToken();
            }
            else {
                statements.Add(ParseSingleStatement());
            }
            return statements;
        }
        
        private AphidExpression ParseExtendExpression() {
            NextToken();
            return new ExtendExpression(ParseIdentifierExpression().Identifier, ParseObjectExpression());
        }
        
        private AphidExpression ParseForExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var initOrElement = ParseExpression();
            if ((_currentToken.TokenType == AphidTokenType.inKeyword)) {
                NextToken();
                var collection = ParseExpression();
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForEachExpression(collection, initOrElement, body);
            }
            else {
                Match(AphidTokenType.EndOfStatement);
                var condition = ParseExpression();
                Match(AphidTokenType.EndOfStatement);
                var afterthought = ParseExpression();
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForExpression(initOrElement, condition, afterthought, body);
            }
        }
        
        private AphidExpression ParseWhileExpression() {
            NextToken();
            return new WhileExpression(ParseCondition(), ParseBlock());
        }
        
        private AphidExpression ParseDoWhileExpression() {
            NextToken();
            var body = ParseBlock();
            Match(AphidTokenType.whileKeyword);
            Match(AphidTokenType.LeftParenthesis);
            var condition = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            return new DoWhileExpression(condition, body);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseTuple() {
            var tuple = new System.Collections.Generic.List<AphidExpression>();
            for (
            ; true; 
            ) {
                tuple.Add(ParseExpression());
                if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
                    return tuple;
                }
            }
        }
        
        private AphidExpression ParseLoadScriptExpression() {
            NextToken();
            return new LoadScriptExpression(ParseExpression());
        }
        
        private AphidExpression ParseLoadLibraryExpression() {
            NextToken();
            return new LoadLibraryExpression(ParseExpression());
        }
        
        private AphidExpression ParseTryExpression() {
            NextToken();
            var tryBody = ParseBlock();
            IdentifierExpression catchArg = default(IdentifierExpression);
            System.Collections.Generic.List<AphidExpression> catchBody = default(System.Collections.Generic.List<AphidExpression>);
            System.Collections.Generic.List<AphidExpression> finallyBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((_currentToken.TokenType == AphidTokenType.catchKeyword)) {
                NextToken();
                Match(AphidTokenType.LeftParenthesis);
                catchArg = ParseIdentifierExpression();
                Match(AphidTokenType.RightParenthesis);
                catchBody = ParseBlock();
                if ((_currentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
            }
            else {
                if ((_currentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
                else {
                    throw new AphidParserException(_currentToken);
                }
            }
            return new TryExpression(tryBody, catchArg, catchBody, finallyBody);
        }
        
        private AphidExpression ParseSwitchExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var exp = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            Match(AphidTokenType.LeftBrace);
            var cases = new System.Collections.Generic.List<SwitchCase>();
            System.Collections.Generic.List<AphidExpression> defaultCase = default(System.Collections.Generic.List<AphidExpression>);
            for (
            ; ((_currentToken.TokenType == AphidTokenType.RightBrace) 
                        == false); 
            ) {
                if (((_currentToken.TokenType == AphidTokenType.defaultKeyword) 
                            == false)) {
                    var caseTuple = ParseTuple();
                    Match(AphidTokenType.ColonOperator);
                    var block = ParseBlock();
                    cases.Add(new SwitchCase(caseTuple, block));
                }
                else {
                    NextToken();
                    Match(AphidTokenType.ColonOperator);
                    defaultCase = ParseBlock();
                }
            }
            NextToken();
            return new SwitchExpression(exp, cases, defaultCase);
        }
        
        private ObjectExpression ParseObjectExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<BinaryOperatorExpression>();
            for (
            ; inNode; 
            ) {
                if ((_currentToken.TokenType == AphidTokenType.Identifier)) {
                    childNodes.Add(ParseKeyValuePairExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.RightBrace)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.RightBrace)) {
                        NextToken();
                        inNode = false;
                    }
                    else {
                        throw new AphidParserException(_currentToken);
                    }
                }
            }
            return new ObjectExpression(childNodes);
        }
        
        private AphidExpression ParseArrayExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<AphidExpression>();
            if (((_currentToken.TokenType == AphidTokenType.RightBracket) 
                        == false)) {
                for (
                ; inNode; 
                ) {
                    childNodes.Add(ParseExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                        if ((_currentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
            }
            else {
                NextToken();
            }
            return new ArrayExpression(childNodes);
        }
        
        private BinaryOperatorExpression ParseKeyValuePairExpression() {
            var id = ParseIdentifierExpression();
            AphidExpression exp = default(AphidExpression);
            if (((_currentToken.TokenType == AphidTokenType.ColonOperator) 
                        || (_currentToken.TokenType == AphidTokenType.AssignmentOperator))) {
                NextToken();
                exp = ParseExpression();
            }
            else {
                exp = id;
            }
            return new BinaryOperatorExpression(id, AphidTokenType.ColonOperator, exp);
        }
        
        private AphidExpression ParseNumberExpression() {
            var exp = new NumberExpression(decimal.Parse(_currentToken.Lexeme));
            NextToken();
            return exp;
        }
        
        private AphidExpression ParseFunctionExpression() {
            AphidExpression exp = default(AphidExpression);
            var body = new System.Collections.Generic.List<AphidExpression>();
            var args = new System.Collections.Generic.List<AphidExpression>();
            AphidExpression argExp = default(AphidExpression);
            NextToken();
            if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                NextToken();
                if (((_currentToken.TokenType == AphidTokenType.RightParenthesis) 
                            == false)) {
                    for (
                    ; true; 
                    ) {
                        if ((_currentToken.TokenType == AphidTokenType.Identifier)) {
                            var id = ParseIdentifierExpression();
                            argExp = id;
                            if ((_currentToken.TokenType == AphidTokenType.AssignmentOperator)) {
                                var op = _currentToken.TokenType;
                                NextToken();
                                argExp = new BinaryOperatorExpression(id, op, ParseExpression());
                            }
                            args.Add(argExp);
                            if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                                NextToken();
                            }
                            else {
break;
                            }
                        }
                        else {
                            throw new AphidParserException(_currentToken);
                        }
                    }
                }
                Match(AphidTokenType.RightParenthesis);
                var isSingleLine = (_currentToken.TokenType != AphidTokenType.LeftBrace);
                var block = ParseSingleBlock();
                if ((isSingleLine && UseImplicitReturns)) {
                    body.Add(new UnaryOperatorExpression(AphidTokenType.retKeyword, block[0]));
                }
                else {
                    body = block;
                }
                exp = new FunctionExpression(args, body);
            }
            else {
                exp = new PartialFunctionExpression(ParseCallExpression());
            }
            return exp;
        }
        
        private AphidExpression ParsePatternMatchingExpression() {
            NextToken();
            var patterns = new System.Collections.Generic.List<PatternExpression>();
            Match(AphidTokenType.LeftParenthesis);
            var testExp = ParseExpression();
            Match(AphidTokenType.RightParenthesis);
            for (
            ; true; 
            ) {
                var tuple = new System.Collections.Generic.List<AphidExpression>();
                for (
                ; true; 
                ) {
                    tuple.Add(ParseExpression());
                    if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
break;
                    }
                }
                AphidExpression valueExp = default(AphidExpression);
                if ((_currentToken.TokenType == AphidTokenType.ColonOperator)) {
                    NextToken();
                    valueExp = ParseExpression();
                    patterns.Add(new PatternExpression(valueExp, tuple));
                }
                else {
                    if ((tuple.Count != 1)) {
                        throw new AphidParserException(_currentToken);
                    }
                    patterns.Add(new PatternExpression(tuple[0]));
                }
                if ((_currentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
break;
                }
            }
            return new PatternMatchingExpression(testExp, patterns);
        }
        
        private AphidExpression ParseFactorExpression() {
            AphidExpression exp = default(AphidExpression);
            if ((_currentToken.TokenType == AphidTokenType.LeftBrace)) {
                exp = ParseObjectExpression();
            }
            else {
                if ((_currentToken.TokenType == AphidTokenType.LeftBracket)) {
                    exp = ParseArrayExpression();
                }
                else {
                    if ((_currentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                        NextToken();
                        exp = ParseExpression();
                        Match(AphidTokenType.RightParenthesis);
                    }
                    else {
                        if ((_currentToken.TokenType == AphidTokenType.String)) {
                            exp = ParseStringExpression();
                        }
                        else {
                            if ((_currentToken.TokenType == AphidTokenType.Number)) {
                                exp = ParseNumberExpression();
                            }
                            else {
                                if ((_currentToken.TokenType == AphidTokenType.Identifier)) {
                                    exp = ParseIdentifierExpression();
                                    if ((_currentToken.TokenType == AphidTokenType.definedKeyword)) {
                                        NextToken();
                                        exp = new UnaryOperatorExpression(AphidTokenType.definedKeyword, exp, true);
                                    }
                                }
                                else {
                                    if ((_currentToken.TokenType == AphidTokenType.functionOperator)) {
                                        exp = ParseFunctionExpression();
                                    }
                                    else {
                                        if (((_currentToken.TokenType == AphidTokenType.retKeyword) 
                                                    || (_currentToken.TokenType == AphidTokenType.deleteKeyword))) {
                                            exp = ParseUnaryExpression();
                                        }
                                        else {
                                            if ((_currentToken.TokenType == AphidTokenType.trueKeyword)) {
                                                exp = new BooleanExpression(true);
                                                NextToken();
                                            }
                                            else {
                                                if ((_currentToken.TokenType == AphidTokenType.falseKeyword)) {
                                                    exp = new BooleanExpression(false);
                                                    NextToken();
                                                }
                                                else {
                                                    if ((_currentToken.TokenType == AphidTokenType.thisKeyword)) {
                                                        exp = new ThisExpression();
                                                        NextToken();
                                                    }
                                                    else {
                                                        if ((_currentToken.TokenType == AphidTokenType.LoadScriptOperator)) {
                                                            exp = ParseLoadScriptExpression();
                                                        }
                                                        else {
                                                            if ((_currentToken.TokenType == AphidTokenType.LoadLibraryOperator)) {
                                                                exp = ParseLoadLibraryExpression();
                                                            }
                                                            else {
                                                                if ((_currentToken.TokenType == AphidTokenType.nullKeyword)) {
                                                                    exp = new NullExpression();
                                                                    NextToken();
                                                                }
                                                                else {
                                                                    if ((_currentToken.TokenType == AphidTokenType.breakKeyword)) {
                                                                        exp = new BreakExpression();
                                                                        NextToken();
                                                                    }
                                                                    else {
                                                                        if ((_currentToken.TokenType == AphidTokenType.HexNumber)) {
                                                                            exp = new NumberExpression(System.Convert.ToInt64(_currentToken.Lexeme.Substring(2), 16));
                                                                            NextToken();
                                                                        }
                                                                        else {
                                                                            if ((_currentToken.TokenType == AphidTokenType.BinaryNumber)) {
                                                                                exp = new NumberExpression(BinaryNumber.Parse(_currentToken.Lexeme.Substring(2)));
                                                                                NextToken();
                                                                            }
                                                                            else {
                                                                                if ((_currentToken.TokenType == AphidTokenType.PatternMatchingOperator)) {
                                                                                    exp = ParsePatternMatchingExpression();
                                                                                }
                                                                                else {
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
