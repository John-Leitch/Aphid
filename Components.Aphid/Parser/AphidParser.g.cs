namespace Components.Aphid.Parser {
    using Components.Aphid.Lexer;
    using System.Linq;
    using System.Collections.Generic;
    
    
    [System.Runtime.Serialization.DataContractAttribute(Name="AphidExpressionType")]
    public enum AphidExpressionType {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ArrayAccessExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ArrayExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BinaryOperatorExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BinaryOperatorBodyExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BooleanExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BreakExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CallExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ContinueExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DoWhileExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DynamicMemberExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ExtendExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ForEachExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ForExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FunctionExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GatorOpenExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GatorCloseExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GatorEmitExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IdentifierExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IfExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ImplicitArgumentExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ImplicitArgumentsExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LoadLibraryExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LoadScriptExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LockExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NullExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NumberExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ObjectExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartialFunctionExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartialOperatorExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PatternExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PatternMatchingExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnaryOperatorExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UsingExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        StringExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SwitchCase,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SwitchExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TernaryOperatorExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TextExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ThisExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TryExpression,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WhileExpression,
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ArrayAccessExpression : AphidExpression, IParentNode {
        
        private AphidExpression _arrayExpression;
        
        private System.Collections.Generic.List<AphidExpression> _keyExpressions;
        
        public ArrayAccessExpression(AphidExpression arrayExpression, System.Collections.Generic.List<AphidExpression> keyExpressions) {
            Context = new AphidExpressionContext();
            _arrayExpression = arrayExpression;
            _keyExpressions = keyExpressions;
        }
        
        internal ArrayAccessExpression(AphidExpressionContext context, AphidExpression arrayExpression, System.Collections.Generic.List<AphidExpression> keyExpressions) {
            Context = context;
            _arrayExpression = arrayExpression;
            _keyExpressions = keyExpressions;
        }
        
        private ArrayAccessExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression ArrayExpression {
            get {
                return _arrayExpression;
            }
            set {
                _arrayExpression = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> KeyExpressions {
            get {
                return _keyExpressions;
            }
            set {
                _keyExpressions = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ArrayAccessExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    ArrayExpression}.Concat(AphidExpressionHelper.GetCollection(KeyExpressions)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ArrayExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _elements;
        
        public ArrayExpression(System.Collections.Generic.List<AphidExpression> elements) {
            Context = new AphidExpressionContext();
            _elements = elements;
        }
        
        internal ArrayExpression(AphidExpressionContext context, System.Collections.Generic.List<AphidExpression> elements) {
            Context = context;
            _elements = elements;
        }
        
        private ArrayExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Elements {
            get {
                return _elements;
            }
            set {
                _elements = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class BinaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidExpression _leftOperand;
        
        private AphidTokenType _operator;
        
        private AphidExpression _rightOperand;
        
        public BinaryOperatorExpression(AphidExpression leftOperand, AphidTokenType @operator, AphidExpression rightOperand) {
            Context = new AphidExpressionContext();
            _leftOperand = leftOperand;
            _operator = @operator;
            _rightOperand = rightOperand;
        }
        
        internal BinaryOperatorExpression(AphidExpressionContext context, AphidExpression leftOperand, AphidTokenType @operator, AphidExpression rightOperand) {
            Context = context;
            _leftOperand = leftOperand;
            _operator = @operator;
            _rightOperand = rightOperand;
        }
        
        private BinaryOperatorExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression LeftOperand {
            get {
                return _leftOperand;
            }
            set {
                _leftOperand = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression RightOperand {
            get {
                return _rightOperand;
            }
            set {
                _rightOperand = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class BinaryOperatorBodyExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private FunctionExpression _function;
        
        public BinaryOperatorBodyExpression(AphidTokenType @operator, FunctionExpression function) {
            Context = new AphidExpressionContext();
            _operator = @operator;
            _function = function;
        }
        
        internal BinaryOperatorBodyExpression(AphidExpressionContext context, AphidTokenType @operator, FunctionExpression function) {
            Context = context;
            _operator = @operator;
            _function = function;
        }
        
        private BinaryOperatorBodyExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FunctionExpression Function {
            get {
                return _function;
            }
            set {
                _function = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BinaryOperatorBodyExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Function};
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class BooleanExpression : AphidExpression {
        
        private bool _value;
        
        public BooleanExpression(bool value) {
            Context = new AphidExpressionContext();
            _value = value;
        }
        
        internal BooleanExpression(AphidExpressionContext context, bool value) {
            Context = context;
            _value = value;
        }
        
        private BooleanExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BooleanExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class BreakExpression : AphidExpression {
        
        public BreakExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal BreakExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.BreakExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class CallExpression : AphidExpression, IParentNode {
        
        private AphidExpression _functionExpression;
        
        private System.Collections.Generic.List<AphidExpression> _args;
        
        public CallExpression(AphidExpression functionExpression, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> args) {
            Context = new AphidExpressionContext();
            _functionExpression = functionExpression;
            if ((args != null)) {
                _args = args;
            }
            else {
                _args = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        internal CallExpression(AphidExpressionContext context, AphidExpression functionExpression, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> args) {
            Context = context;
            _functionExpression = functionExpression;
            if ((args != null)) {
                _args = args;
            }
            else {
                _args = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        private CallExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression FunctionExpression {
            get {
                return _functionExpression;
            }
            set {
                _functionExpression = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Args {
            get {
                return _args;
            }
            set {
                _args = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.CallExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    FunctionExpression}.Concat(AphidExpressionHelper.GetCollection(Args)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ContinueExpression : AphidExpression {
        
        public ContinueExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal ContinueExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ContinueExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class DoWhileExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public DoWhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _condition = condition;
            _body = body;
        }
        
        internal DoWhileExpression(AphidExpressionContext context, AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _condition = condition;
            _body = body;
        }
        
        private DoWhileExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Condition {
            get {
                return _condition;
            }
            set {
                _condition = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.DoWhileExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class DynamicMemberExpression : AphidExpression, IParentNode {
        
        private AphidExpression _memberExpression;
        
        public DynamicMemberExpression(AphidExpression memberExpression) {
            Context = new AphidExpressionContext();
            _memberExpression = memberExpression;
        }
        
        internal DynamicMemberExpression(AphidExpressionContext context, AphidExpression memberExpression) {
            Context = context;
            _memberExpression = memberExpression;
        }
        
        private DynamicMemberExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression MemberExpression {
            get {
                return _memberExpression;
            }
            set {
                _memberExpression = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ExtendExpression : AphidExpression, IParentNode {
        
        private IdentifierExpression _extendType;
        
        private ObjectExpression _object;
        
        public ExtendExpression(IdentifierExpression extendType, ObjectExpression @object) {
            Context = new AphidExpressionContext();
            _extendType = extendType;
            _object = @object;
        }
        
        internal ExtendExpression(AphidExpressionContext context, IdentifierExpression extendType, ObjectExpression @object) {
            Context = context;
            _extendType = extendType;
            _object = @object;
        }
        
        private ExtendExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IdentifierExpression ExtendType {
            get {
                return _extendType;
            }
            set {
                _extendType = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ObjectExpression Object {
            get {
                return _object;
            }
            set {
                _object = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ExtendExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    ExtendType,
                    Object};
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ForEachExpression : AphidExpression, IParentNode {
        
        private AphidExpression _collection;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        private AphidExpression _element;
        
        public ForEachExpression(AphidExpression collection, System.Collections.Generic.List<AphidExpression> body, [System.Runtime.InteropServices.OptionalAttribute()] AphidExpression element) {
            Context = new AphidExpressionContext();
            _collection = collection;
            _body = body;
            _element = element;
        }
        
        internal ForEachExpression(AphidExpressionContext context, AphidExpression collection, System.Collections.Generic.List<AphidExpression> body, [System.Runtime.InteropServices.OptionalAttribute()] AphidExpression element) {
            Context = context;
            _collection = collection;
            _body = body;
            _element = element;
        }
        
        private ForEachExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Collection {
            get {
                return _collection;
            }
            set {
                _collection = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Element {
            get {
                return _element;
            }
            set {
                _element = value;
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
                    Element}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ForExpression : AphidExpression, IParentNode {
        
        private AphidExpression _initialization;
        
        private AphidExpression _condition;
        
        private AphidExpression _afterthought;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public ForExpression(AphidExpression initialization, AphidExpression condition, AphidExpression afterthought, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _initialization = initialization;
            _condition = condition;
            _afterthought = afterthought;
            _body = body;
        }
        
        internal ForExpression(AphidExpressionContext context, AphidExpression initialization, AphidExpression condition, AphidExpression afterthought, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _initialization = initialization;
            _condition = condition;
            _afterthought = afterthought;
            _body = body;
        }
        
        private ForExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Initialization {
            get {
                return _initialization;
            }
            set {
                _initialization = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Condition {
            get {
                return _condition;
            }
            set {
                _condition = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Afterthought {
            get {
                return _afterthought;
            }
            set {
                _afterthought = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
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
                    Afterthought}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class FunctionExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _args;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public FunctionExpression(System.Collections.Generic.List<AphidExpression> args, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _args = args;
            _body = body;
        }
        
        internal FunctionExpression(AphidExpressionContext context, System.Collections.Generic.List<AphidExpression> args, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _args = args;
            _body = body;
        }
        
        private FunctionExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Args {
            get {
                return _args;
            }
            set {
                _args = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.FunctionExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Args.OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class GatorOpenExpression : AphidExpression {
        
        public GatorOpenExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal GatorOpenExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.GatorOpenExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class GatorCloseExpression : AphidExpression {
        
        public GatorCloseExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal GatorCloseExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.GatorCloseExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class GatorEmitExpression : AphidExpression, IParentNode {
        
        private AphidExpression _expression;
        
        public GatorEmitExpression(AphidExpression expression) {
            Context = new AphidExpressionContext();
            _expression = expression;
        }
        
        internal GatorEmitExpression(AphidExpressionContext context, AphidExpression expression) {
            Context = context;
            _expression = expression;
        }
        
        private GatorEmitExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Expression {
            get {
                return _expression;
            }
            set {
                _expression = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.GatorEmitExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Expression};
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class IdentifierExpression : AphidExpression, IParentNode {
        
        private string _identifier;
        
        private System.Collections.Generic.List<IdentifierExpression> _attributes;
        
        public IdentifierExpression(string identifier, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<IdentifierExpression> attributes) {
            Context = new AphidExpressionContext();
            _identifier = identifier;
            if ((attributes != null)) {
                _attributes = attributes;
            }
            else {
                _attributes = new System.Collections.Generic.List<IdentifierExpression>();
            }
        }
        
        internal IdentifierExpression(AphidExpressionContext context, string identifier, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<IdentifierExpression> attributes) {
            Context = context;
            _identifier = identifier;
            if ((attributes != null)) {
                _attributes = attributes;
            }
            else {
                _attributes = new System.Collections.Generic.List<IdentifierExpression>();
            }
        }
        
        private IdentifierExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identifier {
            get {
                return _identifier;
            }
            set {
                _identifier = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<IdentifierExpression> Attributes {
            get {
                return _attributes;
            }
            set {
                _attributes = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class IfExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        private System.Collections.Generic.List<AphidExpression> _elseBody;
        
        public IfExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body, System.Collections.Generic.List<AphidExpression> elseBody) {
            Context = new AphidExpressionContext();
            _condition = condition;
            _body = body;
            _elseBody = elseBody;
        }
        
        internal IfExpression(AphidExpressionContext context, AphidExpression condition, System.Collections.Generic.List<AphidExpression> body, System.Collections.Generic.List<AphidExpression> elseBody) {
            Context = context;
            _condition = condition;
            _body = body;
            _elseBody = elseBody;
        }
        
        private IfExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Condition {
            get {
                return _condition;
            }
            set {
                _condition = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> ElseBody {
            get {
                return _elseBody;
            }
            set {
                _elseBody = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.IfExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(ElseBody)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ImplicitArgumentExpression : AphidExpression {
        
        private AphidTokenType _operator;
        
        public ImplicitArgumentExpression(AphidTokenType @operator) {
            Context = new AphidExpressionContext();
            _operator = @operator;
        }
        
        internal ImplicitArgumentExpression(AphidExpressionContext context, AphidTokenType @operator) {
            Context = context;
            _operator = @operator;
        }
        
        private ImplicitArgumentExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ImplicitArgumentExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ImplicitArgumentsExpression : AphidExpression {
        
        private AphidTokenType _operator;
        
        public ImplicitArgumentsExpression(AphidTokenType @operator) {
            Context = new AphidExpressionContext();
            _operator = @operator;
        }
        
        internal ImplicitArgumentsExpression(AphidExpressionContext context, AphidTokenType @operator) {
            Context = context;
            _operator = @operator;
        }
        
        private ImplicitArgumentsExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ImplicitArgumentsExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class LoadLibraryExpression : AphidExpression, IParentNode {
        
        private AphidExpression _libraryExpression;
        
        public LoadLibraryExpression(AphidExpression libraryExpression) {
            Context = new AphidExpressionContext();
            _libraryExpression = libraryExpression;
        }
        
        internal LoadLibraryExpression(AphidExpressionContext context, AphidExpression libraryExpression) {
            Context = context;
            _libraryExpression = libraryExpression;
        }
        
        private LoadLibraryExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression LibraryExpression {
            get {
                return _libraryExpression;
            }
            set {
                _libraryExpression = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class LoadScriptExpression : AphidExpression, IParentNode {
        
        private AphidExpression _fileExpression;
        
        public LoadScriptExpression(AphidExpression fileExpression) {
            Context = new AphidExpressionContext();
            _fileExpression = fileExpression;
        }
        
        internal LoadScriptExpression(AphidExpressionContext context, AphidExpression fileExpression) {
            Context = context;
            _fileExpression = fileExpression;
        }
        
        private LoadScriptExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression FileExpression {
            get {
                return _fileExpression;
            }
            set {
                _fileExpression = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class LockExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _expressions;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public LockExpression(System.Collections.Generic.List<AphidExpression> expressions, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _expressions = expressions;
            _body = body;
        }
        
        internal LockExpression(AphidExpressionContext context, System.Collections.Generic.List<AphidExpression> expressions, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _expressions = expressions;
            _body = body;
        }
        
        private LockExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Expressions {
            get {
                return _expressions;
            }
            set {
                _expressions = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.LockExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Expressions.OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class NullExpression : AphidExpression {
        
        public NullExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal NullExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.NullExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class NumberExpression : AphidExpression {
        
        private decimal _value;
        
        public NumberExpression(decimal value) {
            Context = new AphidExpressionContext();
            _value = value;
        }
        
        internal NumberExpression(AphidExpressionContext context, decimal value) {
            Context = context;
            _value = value;
        }
        
        private NumberExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.NumberExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ObjectExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<BinaryOperatorExpression> _pairs;
        
        private IdentifierExpression _identifier;
        
        public ObjectExpression(System.Collections.Generic.List<BinaryOperatorExpression> pairs, [System.Runtime.InteropServices.OptionalAttribute()] IdentifierExpression identifier) {
            Context = new AphidExpressionContext();
            _pairs = pairs;
            _identifier = identifier;
        }
        
        internal ObjectExpression(AphidExpressionContext context, System.Collections.Generic.List<BinaryOperatorExpression> pairs, [System.Runtime.InteropServices.OptionalAttribute()] IdentifierExpression identifier) {
            Context = context;
            _pairs = pairs;
            _identifier = identifier;
        }
        
        private ObjectExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BinaryOperatorExpression> Pairs {
            get {
                return _pairs;
            }
            set {
                _pairs = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IdentifierExpression Identifier {
            get {
                return _identifier;
            }
            set {
                _identifier = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ObjectExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Identifier}.Concat(AphidExpressionHelper.GetCollection(Pairs)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class PartialFunctionExpression : AphidExpression, IParentNode {
        
        private CallExpression _call;
        
        public PartialFunctionExpression(CallExpression call) {
            Context = new AphidExpressionContext();
            _call = call;
        }
        
        internal PartialFunctionExpression(AphidExpressionContext context, CallExpression call) {
            Context = context;
            _call = call;
        }
        
        private PartialFunctionExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CallExpression Call {
            get {
                return _call;
            }
            set {
                _call = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class PartialOperatorExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private AphidExpression _operand;
        
        public PartialOperatorExpression(AphidTokenType @operator, AphidExpression operand) {
            Context = new AphidExpressionContext();
            _operator = @operator;
            _operand = operand;
        }
        
        internal PartialOperatorExpression(AphidExpressionContext context, AphidTokenType @operator, AphidExpression operand) {
            Context = context;
            _operator = @operator;
            _operand = operand;
        }
        
        private PartialOperatorExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Operand {
            get {
                return _operand;
            }
            set {
                _operand = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PartialOperatorExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Operand};
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class PatternExpression : AphidExpression, IParentNode {
        
        private AphidExpression _value;
        
        private System.Collections.Generic.List<AphidExpression> _patterns;
        
        public PatternExpression(AphidExpression value, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> patterns) {
            Context = new AphidExpressionContext();
            _value = value;
            if ((patterns != null)) {
                _patterns = patterns;
            }
            else {
                _patterns = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        internal PatternExpression(AphidExpressionContext context, AphidExpression value, [System.Runtime.InteropServices.OptionalAttribute()] System.Collections.Generic.List<AphidExpression> patterns) {
            Context = context;
            _value = value;
            if ((patterns != null)) {
                _patterns = patterns;
            }
            else {
                _patterns = new System.Collections.Generic.List<AphidExpression>();
            }
        }
        
        private PatternExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Patterns {
            get {
                return _patterns;
            }
            set {
                _patterns = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PatternExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Value}.Concat(AphidExpressionHelper.GetCollection(Patterns)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class PatternMatchingExpression : AphidExpression, IParentNode {
        
        private AphidExpression _testExpression;
        
        private System.Collections.Generic.List<PatternExpression> _patterns;
        
        public PatternMatchingExpression(AphidExpression testExpression, System.Collections.Generic.List<PatternExpression> patterns) {
            Context = new AphidExpressionContext();
            _testExpression = testExpression;
            _patterns = patterns;
        }
        
        internal PatternMatchingExpression(AphidExpressionContext context, AphidExpression testExpression, System.Collections.Generic.List<PatternExpression> patterns) {
            Context = context;
            _testExpression = testExpression;
            _patterns = patterns;
        }
        
        private PatternMatchingExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression TestExpression {
            get {
                return _testExpression;
            }
            set {
                _testExpression = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<PatternExpression> Patterns {
            get {
                return _patterns;
            }
            set {
                _patterns = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.PatternMatchingExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    TestExpression}.Concat(AphidExpressionHelper.GetCollection(Patterns)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class UnaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private AphidExpression _operand;
        
        private bool _isPostfix;
        
        public UnaryOperatorExpression(AphidTokenType @operator, AphidExpression operand, [System.Runtime.InteropServices.OptionalAttribute()] bool isPostfix) {
            Context = new AphidExpressionContext();
            _operator = @operator;
            _operand = operand;
            _isPostfix = isPostfix;
        }
        
        internal UnaryOperatorExpression(AphidExpressionContext context, AphidTokenType @operator, AphidExpression operand, [System.Runtime.InteropServices.OptionalAttribute()] bool isPostfix) {
            Context = context;
            _operator = @operator;
            _operand = operand;
            _isPostfix = isPostfix;
        }
        
        private UnaryOperatorExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Operand {
            get {
                return _operand;
            }
            set {
                _operand = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPostfix {
            get {
                return _isPostfix;
            }
            set {
                _isPostfix = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class UsingExpression : AphidExpression, IParentNode {
        
        private AphidExpression _disposable;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public UsingExpression(AphidExpression disposable, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _disposable = disposable;
            _body = body;
        }
        
        internal UsingExpression(AphidExpressionContext context, AphidExpression disposable, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _disposable = disposable;
            _body = body;
        }
        
        private UsingExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Disposable {
            get {
                return _disposable;
            }
            set {
                _disposable = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.UsingExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Disposable}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class StringExpression : AphidExpression {
        
        private string _value;
        
        public StringExpression(string value) {
            Context = new AphidExpressionContext();
            _value = value;
        }
        
        internal StringExpression(AphidExpressionContext context, string value) {
            Context = context;
            _value = value;
        }
        
        private StringExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.StringExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class SwitchCase : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _cases;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public SwitchCase(System.Collections.Generic.List<AphidExpression> cases, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _cases = cases;
            _body = body;
        }
        
        internal SwitchCase(AphidExpressionContext context, System.Collections.Generic.List<AphidExpression> cases, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _cases = cases;
            _body = body;
        }
        
        private SwitchCase() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Cases {
            get {
                return _cases;
            }
            set {
                _cases = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.SwitchCase;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return Cases.OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class SwitchExpression : AphidExpression, IParentNode {
        
        private AphidExpression _expression;
        
        private System.Collections.Generic.List<SwitchCase> _cases;
        
        private System.Collections.Generic.List<AphidExpression> _defaultCase;
        
        public SwitchExpression(AphidExpression expression, System.Collections.Generic.List<SwitchCase> cases, System.Collections.Generic.List<AphidExpression> defaultCase) {
            Context = new AphidExpressionContext();
            _expression = expression;
            _cases = cases;
            _defaultCase = defaultCase;
        }
        
        internal SwitchExpression(AphidExpressionContext context, AphidExpression expression, System.Collections.Generic.List<SwitchCase> cases, System.Collections.Generic.List<AphidExpression> defaultCase) {
            Context = context;
            _expression = expression;
            _cases = cases;
            _defaultCase = defaultCase;
        }
        
        private SwitchExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Expression {
            get {
                return _expression;
            }
            set {
                _expression = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SwitchCase> Cases {
            get {
                return _cases;
            }
            set {
                _cases = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> DefaultCase {
            get {
                return _defaultCase;
            }
            set {
                _defaultCase = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.SwitchExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Expression}.Concat(AphidExpressionHelper.GetCollection(Cases)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(DefaultCase)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class TernaryOperatorExpression : AphidExpression, IParentNode {
        
        private AphidTokenType _operator;
        
        private AphidExpression _firstOperand;
        
        private AphidExpression _secondOperand;
        
        private AphidExpression _thirdOperand;
        
        public TernaryOperatorExpression(AphidTokenType @operator, AphidExpression firstOperand, AphidExpression secondOperand, AphidExpression thirdOperand) {
            Context = new AphidExpressionContext();
            _operator = @operator;
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
            _thirdOperand = thirdOperand;
        }
        
        internal TernaryOperatorExpression(AphidExpressionContext context, AphidTokenType @operator, AphidExpression firstOperand, AphidExpression secondOperand, AphidExpression thirdOperand) {
            Context = context;
            _operator = @operator;
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
            _thirdOperand = thirdOperand;
        }
        
        private TernaryOperatorExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidTokenType Operator {
            get {
                return _operator;
            }
            set {
                _operator = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression FirstOperand {
            get {
                return _firstOperand;
            }
            set {
                _firstOperand = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression SecondOperand {
            get {
                return _secondOperand;
            }
            set {
                _secondOperand = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression ThirdOperand {
            get {
                return _thirdOperand;
            }
            set {
                _thirdOperand = value;
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
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class TextExpression : AphidExpression {
        
        private string _text;
        
        public TextExpression(string text) {
            Context = new AphidExpressionContext();
            _text = text;
        }
        
        internal TextExpression(AphidExpressionContext context, string text) {
            Context = context;
            _text = text;
        }
        
        private TextExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return _text;
            }
            set {
                _text = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.TextExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class ThisExpression : AphidExpression {
        
        public ThisExpression() {
            Context = new AphidExpressionContext();
        }
        
        internal ThisExpression(AphidExpressionContext context) {
            Context = context;
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.ThisExpression;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class TryExpression : AphidExpression, IParentNode {
        
        private System.Collections.Generic.List<AphidExpression> _tryBody;
        
        private IdentifierExpression _catchArg;
        
        private System.Collections.Generic.List<AphidExpression> _catchBody;
        
        private System.Collections.Generic.List<AphidExpression> _finallyBody;
        
        public TryExpression(System.Collections.Generic.List<AphidExpression> tryBody, IdentifierExpression catchArg, System.Collections.Generic.List<AphidExpression> catchBody, System.Collections.Generic.List<AphidExpression> finallyBody) {
            Context = new AphidExpressionContext();
            _tryBody = tryBody;
            _catchArg = catchArg;
            _catchBody = catchBody;
            _finallyBody = finallyBody;
        }
        
        internal TryExpression(AphidExpressionContext context, System.Collections.Generic.List<AphidExpression> tryBody, IdentifierExpression catchArg, System.Collections.Generic.List<AphidExpression> catchBody, System.Collections.Generic.List<AphidExpression> finallyBody) {
            Context = context;
            _tryBody = tryBody;
            _catchArg = catchArg;
            _catchBody = catchBody;
            _finallyBody = finallyBody;
        }
        
        private TryExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> TryBody {
            get {
                return _tryBody;
            }
            set {
                _tryBody = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IdentifierExpression CatchArg {
            get {
                return _catchArg;
            }
            set {
                _catchArg = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> CatchBody {
            get {
                return _catchBody;
            }
            set {
                _catchBody = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> FinallyBody {
            get {
                return _finallyBody;
            }
            set {
                _finallyBody = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.TryExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    CatchArg}.Concat(AphidExpressionHelper.GetCollection(TryBody)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(CatchBody)).OfType<AphidExpression>().Concat(AphidExpressionHelper.GetCollection(FinallyBody)).ToArray();
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class WhileExpression : AphidExpression, IParentNode {
        
        private AphidExpression _condition;
        
        private System.Collections.Generic.List<AphidExpression> _body;
        
        public WhileExpression(AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            Context = new AphidExpressionContext();
            _condition = condition;
            _body = body;
        }
        
        internal WhileExpression(AphidExpressionContext context, AphidExpression condition, System.Collections.Generic.List<AphidExpression> body) {
            Context = context;
            _condition = condition;
            _body = body;
        }
        
        private WhileExpression() {
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AphidExpression Condition {
            get {
                return _condition;
            }
            set {
                _condition = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<AphidExpression> Body {
            get {
                return _body;
            }
            set {
                _body = value;
            }
        }
        
        public override AphidExpressionType Type {
            get {
                return AphidExpressionType.WhileExpression;
            }
        }
        
        public IEnumerable<AphidExpression> GetChildren() {
            return new AphidExpression[] {
                    Condition}.Concat(AphidExpressionHelper.GetCollection(Body)).ToArray();
        }
    }
    
    public class AphidExpressionHelper {
        
        public static System.Collections.Generic.IEnumerable<AphidExpression> GetCollection(System.Collections.Generic.IEnumerable<AphidExpression> collection) {
            if ((collection == null)) {
                return new AphidExpression[0];
            }
            else {
                return collection;
            }
        }
    }
    
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    public sealed partial class AphidExpressionContext {
        
        private string _filename;
        
        private string _code;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Filename {
            get {
                return _filename;
            }
            set {
                _filename = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return _code;
            }
            set {
                _code = value;
            }
        }
    }
    
    public partial class AphidParser {
        
        private AphidExpressionContext _context;
        
        public System.Collections.Generic.List<AphidExpression> Parse() {
            if ((this._context == null)) {
                _context = new AphidExpressionContext();
            }
            var expressionSequence = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            for (
            ; ((CurrentToken.TokenType == AphidTokenType.None) 
                        == false); 
            ) {
                expressionSequence.Add(ParseStatement());
            }
            return expressionSequence;
        }
        
        private AphidExpression ParseStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((CurrentToken.TokenType == AphidTokenType.ifKeyword)) {
                var index0000 = CurrentToken.Index;
                exp = ParseIfExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index0000;
                    exp.Length = (CurrentToken.Index - index0000);
                }
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.forKeyword)) {
                    var index0001 = CurrentToken.Index;
                    exp = ParseForExpression();
                    if ((exp.Index < 0)) {
                        exp.Index = index0001;
                        exp.Length = (CurrentToken.Index - index0001);
                    }
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.whileKeyword)) {
                        var index0002 = CurrentToken.Index;
                        exp = ParseWhileExpression();
                        if ((exp.Index < 0)) {
                            exp.Index = index0002;
                            exp.Length = (CurrentToken.Index - index0002);
                        }
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.doKeyword)) {
                            var index0003 = CurrentToken.Index;
                            exp = ParseDoWhileExpression();
                            if ((exp.Index < 0)) {
                                exp.Index = index0003;
                                exp.Length = (CurrentToken.Index - index0003);
                            }
                            if (true) {
                                if ((CurrentToken.TokenType == AphidTokenType.EndOfStatement)) {
                                    NextToken();
                                }
                                else {
                                    if ((((CurrentToken.TokenType == AphidTokenType.RightBrace) 
                                                == false) 
                                                && ((CurrentToken.TokenType == AphidTokenType.None) 
                                                == false))) {
                                        throw new AphidParserException(CurrentToken);
                                    }
                                }
                            }
                        }
                        else {
                            if ((CurrentToken.TokenType == AphidTokenType.extendKeyword)) {
                                var index0004 = CurrentToken.Index;
                                exp = ParseExtendExpression();
                                if ((exp.Index < 0)) {
                                    exp.Index = index0004;
                                    exp.Length = (CurrentToken.Index - index0004);
                                }
                            }
                            else {
                                if ((CurrentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    var index0005 = CurrentToken.Index;
                                    exp = ParseTryExpression();
                                    if ((exp.Index < 0)) {
                                        exp.Index = index0005;
                                        exp.Length = (CurrentToken.Index - index0005);
                                    }
                                }
                                else {
                                    if ((CurrentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        var index0006 = CurrentToken.Index;
                                        exp = ParseSwitchExpression();
                                        if ((exp.Index < 0)) {
                                            exp.Index = index0006;
                                            exp.Length = (CurrentToken.Index - index0006);
                                        }
                                    }
                                    else {
                                        if ((CurrentToken.TokenType == AphidTokenType.usingKeyword)) {
                                            var index0007 = CurrentToken.Index;
                                            exp = ParseUsingExpression();
                                            if ((exp.Index < 0)) {
                                                exp.Index = index0007;
                                                exp.Length = (CurrentToken.Index - index0007);
                                            }
                                        }
                                        else {
                                            if ((CurrentToken.TokenType == AphidTokenType.lockKeyword)) {
                                                var index0008 = CurrentToken.Index;
                                                exp = ParseLockExpression();
                                                if ((exp.Index < 0)) {
                                                    exp.Index = index0008;
                                                    exp.Length = (CurrentToken.Index - index0008);
                                                }
                                            }
                                            else {
                                                if ((CurrentToken.TokenType == AphidTokenType.Text)) {
                                                    var index0009 = CurrentToken.Index;
                                                    exp = ParseTextExpression();
                                                    if ((exp.Index < 0)) {
                                                        exp.Index = index0009;
                                                        exp.Length = (CurrentToken.Index - index0009);
                                                    }
                                                }
                                                else {
                                                    if ((CurrentToken.TokenType == AphidTokenType.GatorOpenOperator)) {
                                                        exp = new GatorOpenExpression(this._context);
                                                        NextToken();
                                                    }
                                                    else {
                                                        if ((CurrentToken.TokenType == AphidTokenType.GatorCloseOperator)) {
                                                            exp = new GatorCloseExpression(this._context);
                                                            NextToken();
                                                        }
                                                        else {
                                                            if ((CurrentToken.TokenType == AphidTokenType.GatorEmitOperator)) {
                                                                var index000A = CurrentToken.Index;
                                                                exp = ParseGatorEmitExpression();
                                                                if ((exp.Index < 0)) {
                                                                    exp.Index = index000A;
                                                                    exp.Length = (CurrentToken.Index - index000A);
                                                                }
                                                            }
                                                            else {
                                                                var index000B = CurrentToken.Index;
                                                                exp = ParseExpression();
                                                                if ((exp.Index < 0)) {
                                                                    exp.Index = index000B;
                                                                    exp.Length = (CurrentToken.Index - index000B);
                                                                }
                                                                if (true) {
                                                                    for (
                                                                    ; (CurrentToken.TokenType == AphidTokenType.Comma); 
                                                                    ) {
                                                                        NextToken();
                                                                        exp = new BinaryOperatorExpression(this._context, exp, AphidTokenType.Comma, ParseExpression());
                                                                    }
                                                                }
                                                                if ((CurrentToken.TokenType == AphidTokenType.forKeyword)) {
                                                                    NextToken();
                                                                    IdentifierExpression id = default(IdentifierExpression);
                                                                    if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                                                                        NextToken();
                                                                        var index000C = CurrentToken.Index;
                                                                        id = ParseIdentifierExpression();
                                                                        if ((id.Index < 0)) {
                                                                            id.Index = index000C;
                                                                            id.Length = (CurrentToken.Index - index000C);
                                                                        }
                                                                        Match(AphidTokenType.RightParenthesis);
                                                                    }
                                                                    exp = new ForEachExpression(this._context, exp, ParseSingleBlock(), id);
                                                                }
                                                                if (true) {
                                                                    if ((CurrentToken.TokenType == AphidTokenType.EndOfStatement)) {
                                                                        NextToken();
                                                                    }
                                                                    else {
                                                                        if ((((CurrentToken.TokenType == AphidTokenType.RightBrace) 
                                                                                    == false) 
                                                                                    && ((CurrentToken.TokenType == AphidTokenType.None) 
                                                                                    == false))) {
                                                                            throw new AphidParserException(CurrentToken);
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
        
        private AphidExpression ParseSingleStatement() {
            AphidExpression exp = default(AphidExpression);
            if ((CurrentToken.TokenType == AphidTokenType.ifKeyword)) {
                var index000D = CurrentToken.Index;
                exp = ParseIfExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index000D;
                    exp.Length = (CurrentToken.Index - index000D);
                }
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.forKeyword)) {
                    var index000E = CurrentToken.Index;
                    exp = ParseForExpression();
                    if ((exp.Index < 0)) {
                        exp.Index = index000E;
                        exp.Length = (CurrentToken.Index - index000E);
                    }
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.whileKeyword)) {
                        var index000F = CurrentToken.Index;
                        exp = ParseWhileExpression();
                        if ((exp.Index < 0)) {
                            exp.Index = index000F;
                            exp.Length = (CurrentToken.Index - index000F);
                        }
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.doKeyword)) {
                            var index0010 = CurrentToken.Index;
                            exp = ParseDoWhileExpression();
                            if ((exp.Index < 0)) {
                                exp.Index = index0010;
                                exp.Length = (CurrentToken.Index - index0010);
                            }
                            if (false) {
                                if ((CurrentToken.TokenType == AphidTokenType.EndOfStatement)) {
                                    NextToken();
                                }
                                else {
                                    if ((((CurrentToken.TokenType == AphidTokenType.RightBrace) 
                                                == false) 
                                                && ((CurrentToken.TokenType == AphidTokenType.None) 
                                                == false))) {
                                        throw new AphidParserException(CurrentToken);
                                    }
                                }
                            }
                        }
                        else {
                            if ((CurrentToken.TokenType == AphidTokenType.extendKeyword)) {
                                var index0011 = CurrentToken.Index;
                                exp = ParseExtendExpression();
                                if ((exp.Index < 0)) {
                                    exp.Index = index0011;
                                    exp.Length = (CurrentToken.Index - index0011);
                                }
                            }
                            else {
                                if ((CurrentToken.TokenType == AphidTokenType.tryKeyword)) {
                                    var index0012 = CurrentToken.Index;
                                    exp = ParseTryExpression();
                                    if ((exp.Index < 0)) {
                                        exp.Index = index0012;
                                        exp.Length = (CurrentToken.Index - index0012);
                                    }
                                }
                                else {
                                    if ((CurrentToken.TokenType == AphidTokenType.switchKeyword)) {
                                        var index0013 = CurrentToken.Index;
                                        exp = ParseSwitchExpression();
                                        if ((exp.Index < 0)) {
                                            exp.Index = index0013;
                                            exp.Length = (CurrentToken.Index - index0013);
                                        }
                                    }
                                    else {
                                        if ((CurrentToken.TokenType == AphidTokenType.usingKeyword)) {
                                            var index0014 = CurrentToken.Index;
                                            exp = ParseUsingExpression();
                                            if ((exp.Index < 0)) {
                                                exp.Index = index0014;
                                                exp.Length = (CurrentToken.Index - index0014);
                                            }
                                        }
                                        else {
                                            if ((CurrentToken.TokenType == AphidTokenType.lockKeyword)) {
                                                var index0015 = CurrentToken.Index;
                                                exp = ParseLockExpression();
                                                if ((exp.Index < 0)) {
                                                    exp.Index = index0015;
                                                    exp.Length = (CurrentToken.Index - index0015);
                                                }
                                            }
                                            else {
                                                if ((CurrentToken.TokenType == AphidTokenType.Text)) {
                                                    var index0016 = CurrentToken.Index;
                                                    exp = ParseTextExpression();
                                                    if ((exp.Index < 0)) {
                                                        exp.Index = index0016;
                                                        exp.Length = (CurrentToken.Index - index0016);
                                                    }
                                                }
                                                else {
                                                    if ((CurrentToken.TokenType == AphidTokenType.GatorOpenOperator)) {
                                                        exp = new GatorOpenExpression(this._context);
                                                        NextToken();
                                                    }
                                                    else {
                                                        if ((CurrentToken.TokenType == AphidTokenType.GatorCloseOperator)) {
                                                            exp = new GatorCloseExpression(this._context);
                                                            NextToken();
                                                        }
                                                        else {
                                                            if ((CurrentToken.TokenType == AphidTokenType.GatorEmitOperator)) {
                                                                var index0017 = CurrentToken.Index;
                                                                exp = ParseGatorEmitExpression();
                                                                if ((exp.Index < 0)) {
                                                                    exp.Index = index0017;
                                                                    exp.Length = (CurrentToken.Index - index0017);
                                                                }
                                                            }
                                                            else {
                                                                var index0018 = CurrentToken.Index;
                                                                exp = ParseExpression();
                                                                if ((exp.Index < 0)) {
                                                                    exp.Index = index0018;
                                                                    exp.Length = (CurrentToken.Index - index0018);
                                                                }
                                                                if (false) {
                                                                    for (
                                                                    ; (CurrentToken.TokenType == AphidTokenType.Comma); 
                                                                    ) {
                                                                        NextToken();
                                                                        exp = new BinaryOperatorExpression(this._context, exp, AphidTokenType.Comma, ParseExpression());
                                                                    }
                                                                }
                                                                if ((CurrentToken.TokenType == AphidTokenType.forKeyword)) {
                                                                    NextToken();
                                                                    IdentifierExpression id = default(IdentifierExpression);
                                                                    if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                                                                        NextToken();
                                                                        var index0019 = CurrentToken.Index;
                                                                        id = ParseIdentifierExpression();
                                                                        if ((id.Index < 0)) {
                                                                            id.Index = index0019;
                                                                            id.Length = (CurrentToken.Index - index0019);
                                                                        }
                                                                        Match(AphidTokenType.RightParenthesis);
                                                                    }
                                                                    exp = new ForEachExpression(this._context, exp, ParseSingleBlock(), id);
                                                                }
                                                                if (false) {
                                                                    if ((CurrentToken.TokenType == AphidTokenType.EndOfStatement)) {
                                                                        NextToken();
                                                                    }
                                                                    else {
                                                                        if ((((CurrentToken.TokenType == AphidTokenType.RightBrace) 
                                                                                    == false) 
                                                                                    && ((CurrentToken.TokenType == AphidTokenType.None) 
                                                                                    == false))) {
                                                                            throw new AphidParserException(CurrentToken);
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
        
        public AphidExpression ParseExpression() {
            if ((this._context == null)) {
                _context = new AphidExpressionContext();
            }
            return ParseAssignmentExpression();
        }
        
        private AphidExpression ParseAssignmentExpression() {
            var index001A = CurrentToken.Index;
            var operand = ParsePipelineExpression();
            if ((operand.Index < 0)) {
                operand.Index = index001A;
                operand.Length = (CurrentToken.Index - index001A);
            }
            for (
            ; (((((((((((CurrentToken.TokenType == AphidTokenType.AssignmentOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.PlusEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.MinusEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.MultiplicationEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.DivisionEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ModulusEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.BinaryAndEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.OrEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.XorEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ShiftLeftEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ShiftRightEqualOperator)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParsePipelineExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePipelineExpression() {
            var index001B = CurrentToken.Index;
            var operand = ParseRangeExpression();
            if ((operand.Index < 0)) {
                operand.Index = index001B;
                operand.Length = (CurrentToken.Index - index001B);
            }
            var inPipeline = false;
            for (
            ; true; 
            ) {
                if (((CurrentToken.TokenType == AphidTokenType.PipelineOperator) 
                            || (CurrentToken.TokenType == AphidTokenType.toKeyword))) {
                    inPipeline = true;
                    var op = CurrentToken.TokenType;
                    NextToken();
                    operand = new BinaryOperatorExpression(this._context, operand, AphidTokenType.PipelineOperator, ParseRangeExpression());
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.ReversePipelineOperator)) {
                        inPipeline = true;
                        var op = CurrentToken.TokenType;
                        NextToken();
                        operand = new BinaryOperatorExpression(this._context, operand, AphidTokenType.ReversePipelineOperator, ParseRangeExpression());
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.InteropOperator)) {
                            inPipeline = true;
                            operand = new BinaryOperatorExpression(this._context, operand, AphidTokenType.PipelineOperator, ParsePrefixUnaryOperatorExpression());
                        }
                        else {
                            if ((CurrentToken.TokenType == AphidTokenType.FunctionOperator)) {
                                inPipeline = true;
                                operand = new BinaryOperatorExpression(this._context, operand, AphidTokenType.PipelineOperator, ParseFunctionExpression());
                            }
                            else {
                                if ((((((((((((((CurrentToken.TokenType == AphidTokenType.AggregateOperator) 
                                            || (CurrentToken.TokenType == AphidTokenType.AnyOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.CountOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.EndsWithOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.FirstOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.GroupByOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.LastOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.OrderByOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.OrderByDescendingOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.SelectManyOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.SelectOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.StartsWithOperator)) 
                                            || (CurrentToken.TokenType == AphidTokenType.WhereOperator))) {
                                    inPipeline = true;
                                    var t = CurrentToken.TokenType;
                                    NextToken();
                                    operand = new BinaryOperatorExpression(this._context, operand, t, ParseRangeExpression());
                                }
                                else {
                                    if (((((((CurrentToken.TokenType == AphidTokenType.DistinctOperator) 
                                                || (CurrentToken.TokenType == AphidTokenType.PostfixCountOperator)) 
                                                || (CurrentToken.TokenType == AphidTokenType.PostfixFirstOperator)) 
                                                || (CurrentToken.TokenType == AphidTokenType.PostfixLastOperator)) 
                                                || (CurrentToken.TokenType == AphidTokenType.PostfixOrderOperator)) 
                                                || (CurrentToken.TokenType == AphidTokenType.PostfixOrderDescendingOperator))) {
                                        inPipeline = true;
                                        operand = new UnaryOperatorExpression(this._context, CurrentToken.TokenType, operand);
                                        NextToken();
                                    }
                                    else {
                                        if ((inPipeline 
                                                    && (CurrentToken.TokenType == AphidTokenType.Identifier))) {
                                            operand = new BinaryOperatorExpression(this._context, operand, AphidTokenType.PipelineOperator, ParseExpression());
                                        }
                                        else {
break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return operand;
        }
        
        private AphidExpression ParseRangeExpression() {
            var index001C = CurrentToken.Index;
            var operand = ParseConditionalExpression();
            if ((operand.Index < 0)) {
                operand.Index = index001C;
                operand.Length = (CurrentToken.Index - index001C);
            }
            for (
            ; ((((CurrentToken.TokenType == AphidTokenType.RangeOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.CompositionOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ReverseCompositionOperator)) 
                        || (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((CurrentToken.TokenType == AphidTokenType.CustomOperator000) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator001)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator002)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator003)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator004)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator005)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator006)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator007)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator008)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator009)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator010)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator011)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator012)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator013)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator014)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator015)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator016)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator017)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator018)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator019)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator020)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator021)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator022)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator023)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator024)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator025)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator026)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator027)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator028)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator029)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator030)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator031)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator032)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator033)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator034)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator035)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator036)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator037)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator038)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator039)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator040)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator041)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator042)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator043)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator044)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator045)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator046)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator047)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator048)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator049)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator050)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator051)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator052)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator053)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator054)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator055)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator056)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator057)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator058)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator059)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator060)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator061)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator062)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator063)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator064)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator065)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator066)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator067)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator068)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator069)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator070)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator071)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator072)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator073)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator074)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator075)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator076)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator077)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator078)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator079)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator080)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator081)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator082)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator083)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator084)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator085)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator086)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator087)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator088)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator089)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator090)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator091)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator092)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator093)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator094)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator095)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator096)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator097)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator098)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator099)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator100)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator101)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator102)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator103)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator104)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator105)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator106)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator107)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator108)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator109)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator110)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator111)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator112)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator113)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator114)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator115)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator116)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator117)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator118)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator119)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator120)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator121)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator122)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator123)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator124)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator125)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator126)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator127)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator128)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator129)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator130)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator131)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator132)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator133)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator134)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator135)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator136)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator137)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator138)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator139)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator140)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator141)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator142)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator143)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator144)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator145)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator146)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator147)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator148)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator149)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator150)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator151)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator152)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator153)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator154)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator155)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator156)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator157)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator158)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator159)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator160)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator161)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator162)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator163)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator164)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator165)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator166)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator167)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator168)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator169)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator170)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator171)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator172)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator173)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator174)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator175)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator176)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator177)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator178)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator179)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator180)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator181)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator182)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator183)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator184)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator185)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator186)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator187)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator188)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator189)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator190)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator191)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator192)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator193)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator194)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator195)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator196)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator197)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator198)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator199)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator200)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator201)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator202)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator203)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator204)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator205)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator206)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator207)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator208)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator209)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator210)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator211)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator212)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator213)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator214)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator215)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator216)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator217)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator218)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator219)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator220)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator221)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator222)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator223)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator224)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator225)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator226)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator227)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator228)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator229)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator230)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator231)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator232)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator233)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator234)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator235)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator236)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator237)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator238)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator239)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator240)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator241)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator242)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator243)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator244)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator245)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator246)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator247)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator248)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator249)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator250)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator251)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator252)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator253)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator254)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator255)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator256)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator257)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator258)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator259)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator260)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator261)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator262)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator263)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator264)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator265)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator266)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator267)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator268)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator269)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator270)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator271)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator272)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator273)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator274)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator275)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator276)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator277)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator278)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator279)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator280)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator281)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator282)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator283)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator284)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator285)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator286)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator287)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator288)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator289)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator290)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator291)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator292)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator293)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator294)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator295)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator296)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator297)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator298)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator299)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator300)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator301)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator302)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator303)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator304)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator305)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator306)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator307)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator308)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator309)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator310)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator311)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator312)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator313)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator314)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator315)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator316))); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseConditionalExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseConditionalExpression() {
            var index001D = CurrentToken.Index;
            var exp = ParseLogicalExpression();
            if ((exp.Index < 0)) {
                exp.Index = index001D;
                exp.Length = (CurrentToken.Index - index001D);
            }
            if ((CurrentToken.TokenType == AphidTokenType.ConditionalOperator)) {
                NextToken();
                var index001E = CurrentToken.Index;
                var trueExpression = ParseExpression();
                if ((trueExpression.Index < 0)) {
                    trueExpression.Index = index001E;
                    trueExpression.Length = (CurrentToken.Index - index001E);
                }
                Match(AphidTokenType.ColonOperator);
                var index001F = CurrentToken.Index;
                var falseExpression = ParseExpression();
                if ((falseExpression.Index < 0)) {
                    falseExpression.Index = index001F;
                    falseExpression.Length = (CurrentToken.Index - index001F);
                }
                return new TernaryOperatorExpression(this._context, AphidTokenType.ConditionalOperator, exp, trueExpression, falseExpression);
            }
            else {
                return exp;
            }
        }
        
        private AphidExpression ParseLogicalExpression() {
            var index0020 = CurrentToken.Index;
            var operand = ParseComparisonExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0020;
                operand.Length = (CurrentToken.Index - index0020);
            }
            for (
            ; ((((CurrentToken.TokenType == AphidTokenType.AndOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.OrOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.andKeyword)) 
                        || (CurrentToken.TokenType == AphidTokenType.orKeyword)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseComparisonExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseComparisonExpression() {
            var index0021 = CurrentToken.Index;
            var operand = ParsePostfixUnaryOperationExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0021;
                operand.Length = (CurrentToken.Index - index0021);
            }
            for (
            ; ((((((CurrentToken.TokenType == AphidTokenType.EqualityOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.NotEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.LessThanOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.LessThanOrEqualOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.GreaterThanOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParsePostfixUnaryOperationExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePostfixUnaryOperationExpression() {
            var index0022 = CurrentToken.Index;
            var term = ParseBinaryOrExpression();
            if ((term.Index < 0)) {
                term.Index = index0022;
                term.Length = (CurrentToken.Index - index0022);
            }
            if (((CurrentToken.TokenType == AphidTokenType.IncrementOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.DecrementOperator))) {
                var op = CurrentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(this._context, op, term, true);
            }
            else {
                return term;
            }
        }
        
        private AphidExpression ParseBinaryOrExpression() {
            var index0023 = CurrentToken.Index;
            var operand = ParseXorExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0023;
                operand.Length = (CurrentToken.Index - index0023);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.BinaryOrOperator); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseXorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseXorExpression() {
            var index0024 = CurrentToken.Index;
            var operand = ParseBinaryAndExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0024;
                operand.Length = (CurrentToken.Index - index0024);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.XorOperator); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseBinaryAndExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseBinaryAndExpression() {
            var index0025 = CurrentToken.Index;
            var operand = ParseShiftExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0025;
                operand.Length = (CurrentToken.Index - index0025);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.BinaryAndOperator); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseShiftExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseShiftExpression() {
            var index0026 = CurrentToken.Index;
            var operand = ParseAdditionExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0026;
                operand.Length = (CurrentToken.Index - index0026);
            }
            for (
            ; ((CurrentToken.TokenType == AphidTokenType.ShiftLeft) 
                        || (CurrentToken.TokenType == AphidTokenType.ShiftRight)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseAdditionExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseAdditionExpression() {
            var index0027 = CurrentToken.Index;
            var operand = ParseTermExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0027;
                operand.Length = (CurrentToken.Index - index0027);
            }
            for (
            ; ((CurrentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.MinusOperator)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParseTermExpression());
            }
            return operand;
        }
        
        private AphidExpression ParseTermExpression() {
            var index0028 = CurrentToken.Index;
            var operand = ParsePrefixUnaryOperatorExpression();
            if ((operand.Index < 0)) {
                operand.Index = index0028;
                operand.Length = (CurrentToken.Index - index0028);
            }
            for (
            ; (((CurrentToken.TokenType == AphidTokenType.MultiplicationOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.DivisionOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ModulusOperator)); 
            ) {
                var op = CurrentToken.TokenType;
                NextToken();
                operand = new BinaryOperatorExpression(this._context, operand, op, ParsePrefixUnaryOperatorExpression());
            }
            return operand;
        }
        
        private AphidExpression ParsePrefixUnaryOperatorExpression() {
            if ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((CurrentToken.TokenType == AphidTokenType.AdditionOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.MinusOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.NotOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.IncrementOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.DecrementOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.MultiplicationOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.ComplementOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.InteropOperator)) 
                        || (CurrentToken.TokenType == AphidTokenType.newKeyword)) 
                        || (CurrentToken.TokenType == AphidTokenType.loadKeyword)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator000)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator001)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator002)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator003)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator004)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator005)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator006)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator007)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator008)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator009)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator010)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator011)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator012)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator013)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator014)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator015)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator016)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator017)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator018)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator019)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator020)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator021)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator022)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator023)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator024)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator025)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator026)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator027)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator028)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator029)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator030)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator031)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator032)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator033)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator034)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator035)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator036)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator037)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator038)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator039)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator040)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator041)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator042)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator043)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator044)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator045)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator046)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator047)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator048)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator049)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator050)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator051)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator052)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator053)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator054)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator055)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator056)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator057)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator058)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator059)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator060)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator061)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator062)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator063)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator064)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator065)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator066)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator067)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator068)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator069)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator070)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator071)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator072)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator073)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator074)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator075)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator076)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator077)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator078)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator079)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator080)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator081)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator082)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator083)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator084)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator085)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator086)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator087)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator088)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator089)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator090)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator091)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator092)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator093)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator094)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator095)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator096)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator097)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator098)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator099)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator100)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator101)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator102)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator103)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator104)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator105)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator106)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator107)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator108)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator109)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator110)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator111)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator112)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator113)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator114)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator115)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator116)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator117)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator118)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator119)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator120)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator121)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator122)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator123)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator124)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator125)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator126)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator127)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator128)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator129)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator130)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator131)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator132)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator133)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator134)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator135)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator136)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator137)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator138)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator139)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator140)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator141)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator142)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator143)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator144)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator145)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator146)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator147)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator148)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator149)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator150)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator151)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator152)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator153)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator154)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator155)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator156)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator157)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator158)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator159)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator160)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator161)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator162)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator163)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator164)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator165)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator166)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator167)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator168)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator169)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator170)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator171)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator172)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator173)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator174)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator175)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator176)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator177)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator178)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator179)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator180)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator181)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator182)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator183)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator184)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator185)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator186)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator187)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator188)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator189)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator190)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator191)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator192)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator193)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator194)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator195)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator196)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator197)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator198)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator199)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator200)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator201)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator202)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator203)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator204)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator205)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator206)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator207)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator208)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator209)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator210)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator211)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator212)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator213)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator214)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator215)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator216)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator217)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator218)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator219)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator220)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator221)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator222)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator223)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator224)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator225)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator226)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator227)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator228)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator229)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator230)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator231)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator232)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator233)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator234)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator235)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator236)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator237)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator238)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator239)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator240)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator241)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator242)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator243)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator244)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator245)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator246)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator247)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator248)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator249)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator250)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator251)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator252)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator253)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator254)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator255)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator256)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator257)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator258)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator259)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator260)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator261)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator262)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator263)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator264)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator265)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator266)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator267)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator268)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator269)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator270)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator271)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator272)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator273)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator274)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator275)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator276)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator277)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator278)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator279)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator280)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator281)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator282)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator283)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator284)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator285)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator286)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator287)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator288)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator289)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator290)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator291)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator292)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator293)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator294)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator295)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator296)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator297)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator298)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator299)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator300)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator301)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator302)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator303)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator304)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator305)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator306)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator307)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator308)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator309)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator310)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator311)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator312)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator313)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator314)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator315)) 
                        || (CurrentToken.TokenType == AphidTokenType.CustomOperator316))) {
                var t = CurrentToken.TokenType;
                NextToken();
                return new UnaryOperatorExpression(this._context, t, ParseArrayAccessExpression());
            }
            else {
                return ParseArrayAccessExpression();
            }
        }
        
        private AphidExpression ParseArrayAccessExpression() {
            var index0029 = CurrentToken.Index;
            var exp = ParseCallExpression();
            if ((exp.Index < 0)) {
                exp.Index = index0029;
                exp.Length = (CurrentToken.Index - index0029);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.LeftBracket); 
            ) {
                NextToken();
                var keys = ParseTuple();
                Match(AphidTokenType.RightBracket);
                exp = new ArrayAccessExpression(this._context, exp, keys);
                for (
                ; (CurrentToken.TokenType == AphidTokenType.MemberOperator); 
                ) {
                    NextToken();
                    AphidExpression memberExp = default(AphidExpression);
                    if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                        memberExp = new IdentifierExpression(this._context, CurrentToken.Lexeme);
                        NextToken();
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.String)) {
                            var index002A = CurrentToken.Index;
                            memberExp = ParseStringExpression();
                            if ((memberExp.Index < 0)) {
                                memberExp.Index = index002A;
                                memberExp.Length = (CurrentToken.Index - index002A);
                            }
                        }
                        else {
                            if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                                NextToken();
                                memberExp = new DynamicMemberExpression(this._context, ParseExpression());
                                Match(AphidTokenType.RightBrace);
                            }
                            else {
                                throw new AphidParserException(CurrentToken);
                            }
                        }
                    }
                    exp = new BinaryOperatorExpression(this._context, exp, AphidTokenType.MemberOperator, memberExp);
                    for (
                    ; (CurrentToken.TokenType == AphidTokenType.LeftParenthesis); 
                    ) {
                        NextToken();
                        if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                            NextToken();
                            exp = new CallExpression(this._context, exp);
                        }
                        else {
                            var args = ParseTuple();
                            Match(AphidTokenType.RightParenthesis);
                            exp = new CallExpression(this._context, exp, args);
                        }
                    }
                    if ((CurrentToken.TokenType == AphidTokenType.definedKeyword)) {
                        NextToken();
                        return new UnaryOperatorExpression(this._context, AphidTokenType.definedKeyword, exp, true);
                    }
                }
                for (
                ; (CurrentToken.TokenType == AphidTokenType.LeftParenthesis); 
                ) {
                    NextToken();
                    if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                        NextToken();
                        exp = new CallExpression(this._context, exp);
                    }
                    else {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        exp = new CallExpression(this._context, exp, args);
                    }
                }
            }
            if ((CurrentToken.TokenType == AphidTokenType.definedKeyword)) {
                NextToken();
                return new UnaryOperatorExpression(this._context, AphidTokenType.definedKeyword, exp, true);
            }
            else {
                return exp;
            }
        }
        
        private AphidExpression ParseCallExpression() {
            var index002B = CurrentToken.Index;
            var function = ParseMemberExpression();
            if ((function.Index < 0)) {
                function.Index = index002B;
                function.Length = (CurrentToken.Index - index002B);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(this._context, function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(this._context, function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseMemberExpression() {
            var index002C = CurrentToken.Index;
            var factor = ParseFactorCallExpression();
            if ((factor.Index < 0)) {
                factor.Index = index002C;
                factor.Length = (CurrentToken.Index - index002C);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.MemberOperator); 
            ) {
                NextToken();
                AphidExpression memberExp = default(AphidExpression);
                if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                    memberExp = new IdentifierExpression(this._context, CurrentToken.Lexeme);
                    NextToken();
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.String)) {
                        var index002D = CurrentToken.Index;
                        memberExp = ParseStringExpression();
                        if ((memberExp.Index < 0)) {
                            memberExp.Index = index002D;
                            memberExp.Length = (CurrentToken.Index - index002D);
                        }
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                            NextToken();
                            memberExp = new DynamicMemberExpression(this._context, ParseExpression());
                            Match(AphidTokenType.RightBrace);
                        }
                        else {
                            throw new AphidParserException(CurrentToken);
                        }
                    }
                }
                factor = new BinaryOperatorExpression(this._context, factor, AphidTokenType.MemberOperator, memberExp);
                for (
                ; (CurrentToken.TokenType == AphidTokenType.LeftParenthesis); 
                ) {
                    NextToken();
                    if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                        NextToken();
                        factor = new CallExpression(this._context, factor);
                    }
                    else {
                        var args = ParseTuple();
                        Match(AphidTokenType.RightParenthesis);
                        factor = new CallExpression(this._context, factor, args);
                    }
                }
                if ((CurrentToken.TokenType == AphidTokenType.definedKeyword)) {
                    NextToken();
                    return new UnaryOperatorExpression(this._context, AphidTokenType.definedKeyword, factor, true);
                }
            }
            return factor;
        }
        
        private AphidExpression ParseFactorCallExpression() {
            var index002E = CurrentToken.Index;
            var function = ParseFactorExpression();
            if ((function.Index < 0)) {
                function.Index = index002E;
                function.Length = (CurrentToken.Index - index002E);
            }
            for (
            ; (CurrentToken.TokenType == AphidTokenType.LeftParenthesis); 
            ) {
                NextToken();
                if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    NextToken();
                    function = new CallExpression(this._context, function);
                }
                else {
                    var args = ParseTuple();
                    Match(AphidTokenType.RightParenthesis);
                    function = new CallExpression(this._context, function, args);
                }
            }
            return function;
        }
        
        private AphidExpression ParseStringExpression() {
            var exp = new StringExpression(this._context, CurrentToken.Lexeme);
            NextToken();
            return exp;
        }
        
        private IdentifierExpression ParseIdentifierExpression() {
            var exp = new IdentifierExpression(this._context, CurrentToken.Lexeme);
            NextToken();
            if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                var id = exp;
                var attrs = new System.Collections.Generic.List<IdentifierExpression>();
                for (
                ; true; 
                ) {
                    attrs.Add(id);
                    id = new IdentifierExpression(this._context, CurrentToken.Lexeme);
                    NextToken();
                    if (((CurrentToken.TokenType == AphidTokenType.Identifier) 
                                == false)) {
break;
                    }
                }
                exp = new IdentifierExpression(this._context, id.Identifier, attrs);
            }
            return exp;
        }
        
        private AphidExpression ParseUnaryExpression() {
            var t = CurrentToken.TokenType;
            NextToken();
            return new UnaryOperatorExpression(this._context, t, ParseExpression());
        }
        
        private AphidExpression ParseCondition() {
            Match(AphidTokenType.LeftParenthesis);
            var index002F = CurrentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0)) {
                condition.Index = index002F;
                condition.Length = (CurrentToken.Index - index002F);
            }
            Match(AphidTokenType.RightParenthesis);
            return condition;
        }
        
        private AphidExpression ParseIfExpression() {
            NextToken();
            var index0030 = CurrentToken.Index;
            var condition = ParseCondition();
            if ((condition.Index < 0)) {
                condition.Index = index0030;
                condition.Length = (CurrentToken.Index - index0030);
            }
            var body = ParseBlock();
            System.Collections.Generic.List<AphidExpression> elseBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((CurrentToken.TokenType == AphidTokenType.elseKeyword)) {
                NextToken();
                elseBody = ParseBlock();
            }
            return new IfExpression(this._context, condition, body, elseBody);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseBlock() {
            var statements = new System.Collections.Generic.List<AphidExpression>();
            if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((CurrentToken.TokenType == AphidTokenType.RightBrace) 
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
            if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                NextToken();
                for (
                ; ((CurrentToken.TokenType == AphidTokenType.RightBrace) 
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
            return new ExtendExpression(this._context, ParseIdentifierExpression(), ParseObjectExpression());
        }
        
        private AphidExpression ParseForExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var index0031 = CurrentToken.Index;
            var initOrElement = ParseExpression();
            if ((initOrElement.Index < 0)) {
                initOrElement.Index = index0031;
                initOrElement.Length = (CurrentToken.Index - index0031);
            }
            if ((CurrentToken.TokenType == AphidTokenType.inKeyword)) {
                NextToken();
                var index0032 = CurrentToken.Index;
                var collection = ParseExpression();
                if ((collection.Index < 0)) {
                    collection.Index = index0032;
                    collection.Length = (CurrentToken.Index - index0032);
                }
                Match(AphidTokenType.RightParenthesis);
                var body = ParseBlock();
                return new ForEachExpression(this._context, collection, body, initOrElement);
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.RightParenthesis)) {
                    Match(AphidTokenType.RightParenthesis);
                    var body = ParseBlock();
                    return new ForEachExpression(this._context, initOrElement, body, null);
                }
                else {
                    Match(AphidTokenType.EndOfStatement);
                    var index0033 = CurrentToken.Index;
                    var condition = ParseExpression();
                    if ((condition.Index < 0)) {
                        condition.Index = index0033;
                        condition.Length = (CurrentToken.Index - index0033);
                    }
                    Match(AphidTokenType.EndOfStatement);
                    var index0034 = CurrentToken.Index;
                    var afterthought = ParseExpression();
                    if ((afterthought.Index < 0)) {
                        afterthought.Index = index0034;
                        afterthought.Length = (CurrentToken.Index - index0034);
                    }
                    Match(AphidTokenType.RightParenthesis);
                    var body = ParseBlock();
                    return new ForExpression(this._context, initOrElement, condition, afterthought, body);
                }
            }
        }
        
        private AphidExpression ParseWhileExpression() {
            NextToken();
            return new WhileExpression(this._context, ParseCondition(), ParseBlock());
        }
        
        private AphidExpression ParseDoWhileExpression() {
            NextToken();
            var body = ParseBlock();
            Match(AphidTokenType.whileKeyword);
            Match(AphidTokenType.LeftParenthesis);
            var index0035 = CurrentToken.Index;
            var condition = ParseExpression();
            if ((condition.Index < 0)) {
                condition.Index = index0035;
                condition.Length = (CurrentToken.Index - index0035);
            }
            Match(AphidTokenType.RightParenthesis);
            return new DoWhileExpression(this._context, condition, body);
        }
        
        private System.Collections.Generic.List<AphidExpression> ParseTuple() {
            var tuple = new System.Collections.Generic.List<AphidExpression>();
            for (
            ; true; 
            ) {
                tuple.Add(ParseExpression());
                if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
                    return tuple;
                }
            }
        }
        
        private AphidExpression ParseUsingExpression() {
            NextToken();
            if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                NextToken();
                var index0036 = CurrentToken.Index;
                var exp = ParseExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index0036;
                    exp.Length = (CurrentToken.Index - index0036);
                }
                Match(AphidTokenType.RightParenthesis);
                return new UsingExpression(this._context, exp, ParseBlock());
            }
            else {
                var index0037 = CurrentToken.Index;
                var exp = ParseMemberExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index0037;
                    exp.Length = (CurrentToken.Index - index0037);
                }
                if ((CurrentToken.TokenType == AphidTokenType.EndOfStatement)) {
                    NextToken();
                }
                return new UnaryOperatorExpression(this._context, AphidTokenType.usingKeyword, exp);
            }
        }
        
        private AphidExpression ParseLockExpression() {
            NextToken();
            var exps = new System.Collections.Generic.List<AphidExpression>();
            for (
            ; true; 
            ) {
                if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                    NextToken();
                    exps.Add(ParseExpression());
                    Match(AphidTokenType.RightParenthesis);
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                        AphidExpression exp = default(AphidExpression);
                        exp = new IdentifierExpression(this._context, CurrentToken.Lexeme);
                        NextToken();
                        for (
                        ; (CurrentToken.TokenType == AphidTokenType.MemberOperator); 
                        ) {
                            NextToken();
                            AphidExpression memberExp = default(AphidExpression);
                            if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                                memberExp = new IdentifierExpression(this._context, CurrentToken.Lexeme);
                                NextToken();
                            }
                            else {
                                if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                                    NextToken();
                                    memberExp = new DynamicMemberExpression(this._context, ParseExpression());
                                    Match(AphidTokenType.RightBrace);
                                }
                                else {
                                    throw new AphidParserException(CurrentToken);
                                }
                            }
                            exp = new BinaryOperatorExpression(this._context, exp, AphidTokenType.MemberOperator, memberExp);
                        }
                        exps.Add(exp);
                    }
                }
                if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
break;
                }
            }
            return new LockExpression(this._context, exps, ParseBlock());
        }
        
        private AphidExpression ParseLoadScriptExpression() {
            NextToken();
            return new LoadScriptExpression(this._context, ParseExpression());
        }
        
        private AphidExpression ParseLoadLibraryExpression() {
            NextToken();
            return new LoadLibraryExpression(this._context, ParseExpression());
        }
        
        private AphidExpression ParseTryExpression() {
            NextToken();
            var tryBody = ParseBlock();
            IdentifierExpression catchArg = default(IdentifierExpression);
            System.Collections.Generic.List<AphidExpression> catchBody = default(System.Collections.Generic.List<AphidExpression>);
            System.Collections.Generic.List<AphidExpression> finallyBody = default(System.Collections.Generic.List<AphidExpression>);
            if ((CurrentToken.TokenType == AphidTokenType.catchKeyword)) {
                NextToken();
                if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                    Match(AphidTokenType.LeftParenthesis);
                    var index0038 = CurrentToken.Index;
                    catchArg = ParseIdentifierExpression();
                    if ((catchArg.Index < 0)) {
                        catchArg.Index = index0038;
                        catchArg.Length = (CurrentToken.Index - index0038);
                    }
                    Match(AphidTokenType.RightParenthesis);
                }
                catchBody = ParseBlock();
                if ((CurrentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.finallyKeyword)) {
                    NextToken();
                    finallyBody = ParseBlock();
                }
                else {
                    throw new AphidParserException(CurrentToken);
                }
            }
            return new TryExpression(this._context, tryBody, catchArg, catchBody, finallyBody);
        }
        
        private AphidExpression ParseSwitchExpression() {
            NextToken();
            Match(AphidTokenType.LeftParenthesis);
            var index0039 = CurrentToken.Index;
            var exp = ParseExpression();
            if ((exp.Index < 0)) {
                exp.Index = index0039;
                exp.Length = (CurrentToken.Index - index0039);
            }
            Match(AphidTokenType.RightParenthesis);
            Match(AphidTokenType.LeftBrace);
            var cases = new System.Collections.Generic.List<SwitchCase>();
            System.Collections.Generic.List<AphidExpression> defaultCase = default(System.Collections.Generic.List<AphidExpression>);
            for (
            ; ((CurrentToken.TokenType == AphidTokenType.RightBrace) 
                        == false); 
            ) {
                if (((CurrentToken.TokenType == AphidTokenType.defaultKeyword) 
                            == false)) {
                    var caseTuple = ParseTuple();
                    Match(AphidTokenType.ColonOperator);
                    var block = ParseBlock();
                    cases.Add(new SwitchCase(this._context, caseTuple, block));
                }
                else {
                    NextToken();
                    Match(AphidTokenType.ColonOperator);
                    defaultCase = ParseBlock();
                }
            }
            NextToken();
            return new SwitchExpression(this._context, exp, cases, defaultCase);
        }
        
        private ObjectExpression ParseObjectExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<BinaryOperatorExpression>();
            for (
            ; inNode; 
            ) {
                if (((CurrentToken.TokenType == AphidTokenType.Identifier) 
                            || (CurrentToken.TokenType == AphidTokenType.String))) {
                    childNodes.Add(ParseKeyValuePairExpression());
                    if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.RightBrace)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(CurrentToken);
                        }
                    }
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.RightBrace)) {
                        NextToken();
                        inNode = false;
                    }
                    else {
                        throw new AphidParserException(CurrentToken);
                    }
                }
            }
            return new ObjectExpression(this._context, childNodes);
        }
        
        private BinaryOperatorExpression ParseKeyValuePairExpression() {
            AphidExpression exp = default(AphidExpression);
            AphidExpression id = default(AphidExpression);
            if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                var index003A = CurrentToken.Index;
                id = ParseIdentifierExpression();
                if ((id.Index < 0)) {
                    id.Index = index003A;
                    id.Length = (CurrentToken.Index - index003A);
                }
            }
            else {
                var index003B = CurrentToken.Index;
                id = ParseStringExpression();
                if ((id.Index < 0)) {
                    id.Index = index003B;
                    id.Length = (CurrentToken.Index - index003B);
                }
            }
            if (((CurrentToken.TokenType == AphidTokenType.ColonOperator) 
                        || (CurrentToken.TokenType == AphidTokenType.AssignmentOperator))) {
                NextToken();
                var index003C = CurrentToken.Index;
                exp = ParseExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index003C;
                    exp.Length = (CurrentToken.Index - index003C);
                }
            }
            else {
                exp = id;
            }
            return new BinaryOperatorExpression(this._context, id, AphidTokenType.ColonOperator, exp);
        }
        
        private AphidExpression ParseArrayExpression() {
            NextToken();
            var inNode = true;
            var childNodes = new System.Collections.Generic.List<AphidExpression>();
            if (((CurrentToken.TokenType == AphidTokenType.RightBracket) 
                        == false)) {
                for (
                ; inNode; 
                ) {
                    childNodes.Add(ParseExpression());
                    if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                        if ((CurrentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.RightBracket)) {
                            NextToken();
                            inNode = false;
                        }
                        else {
                            throw new AphidParserException(CurrentToken);
                        }
                    }
                }
            }
            else {
                NextToken();
            }
            return new ArrayExpression(this._context, childNodes);
        }
        
        private AphidExpression ParseNumberExpression() {
            var exp = new NumberExpression(this._context, decimal.Parse(CurrentToken.Lexeme));
            NextToken();
            return exp;
        }
        
        private FunctionExpression ParseFunctionDeclaration() {
            AphidExpression argExp = default(AphidExpression);
            var args = new System.Collections.Generic.List<AphidExpression>();
            var body = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            if (((CurrentToken.TokenType == AphidTokenType.RightParenthesis) 
                        == false)) {
                for (
                ; true; 
                ) {
                    if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                        var index003D = CurrentToken.Index;
                        var id = ParseIdentifierExpression();
                        if ((id.Index < 0)) {
                            id.Index = index003D;
                            id.Length = (CurrentToken.Index - index003D);
                        }
                        argExp = id;
                        if ((CurrentToken.TokenType == AphidTokenType.AssignmentOperator)) {
                            var op = CurrentToken.TokenType;
                            NextToken();
                            argExp = new BinaryOperatorExpression(this._context, id, op, ParseExpression());
                        }
                        args.Add(argExp);
                        if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                            NextToken();
                        }
                        else {
break;
                        }
                    }
                    else {
                        throw new AphidParserException(CurrentToken);
                    }
                }
            }
            Match(AphidTokenType.RightParenthesis);
            var isSingleLine = (CurrentToken.TokenType != AphidTokenType.LeftBrace);
            var block = ParseSingleBlock();
            if ((isSingleLine && UseImplicitReturns)) {
                body.Add(new UnaryOperatorExpression(this._context, AphidTokenType.retKeyword, block[0]));
            }
            else {
                body = block;
            }
            return new FunctionExpression(this._context, args, body);
        }
        
        private AphidExpression ParseFunctionExpression() {
            AphidExpression exp = default(AphidExpression);
            var body = new System.Collections.Generic.List<AphidExpression>();
            var args = new System.Collections.Generic.List<AphidExpression>();
            NextToken();
            if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                var index003E = CurrentToken.Index;
                exp = ParseFunctionDeclaration();
                if ((exp.Index < 0)) {
                    exp.Index = index003E;
                    exp.Length = (CurrentToken.Index - index003E);
                }
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                    exp = new FunctionExpression(this._context, args, ParseBlock());
                }
                else {
                    if (((((((((((((((((((((((CurrentToken.TokenType == AphidTokenType.MinusOperator) 
                                || (CurrentToken.TokenType == AphidTokenType.AdditionOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.MultiplicationOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.DivisionOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.ModulusOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.BinaryAndOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.BinaryOrOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.XorOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.ShiftLeft)) 
                                || (CurrentToken.TokenType == AphidTokenType.ShiftRight)) 
                                || (CurrentToken.TokenType == AphidTokenType.AndOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.OrOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.EqualityOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.NotEqualOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.NotEqualOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.LessThanOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.GreaterThanOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.LessThanOrEqualOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.GreaterThanOrEqualOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.PipelineOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.ReversePipelineOperator)) 
                                || (CurrentToken.TokenType == AphidTokenType.MemberOperator))) {
                        var op = CurrentToken.TokenType;
                        NextToken();
                        exp = new PartialOperatorExpression(this._context, op, ParseRangeExpression());
                    }
                    else {
                        if ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((CurrentToken.TokenType == AphidTokenType.CustomOperator000) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator001)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator002)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator003)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator004)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator005)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator006)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator007)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator008)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator009)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator010)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator011)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator012)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator013)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator014)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator015)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator016)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator017)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator018)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator019)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator020)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator021)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator022)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator023)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator024)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator025)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator026)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator027)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator028)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator029)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator030)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator031)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator032)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator033)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator034)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator035)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator036)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator037)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator038)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator039)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator040)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator041)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator042)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator043)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator044)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator045)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator046)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator047)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator048)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator049)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator050)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator051)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator052)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator053)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator054)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator055)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator056)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator057)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator058)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator059)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator060)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator061)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator062)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator063)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator064)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator065)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator066)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator067)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator068)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator069)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator070)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator071)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator072)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator073)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator074)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator075)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator076)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator077)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator078)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator079)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator080)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator081)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator082)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator083)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator084)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator085)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator086)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator087)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator088)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator089)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator090)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator091)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator092)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator093)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator094)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator095)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator096)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator097)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator098)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator099)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator100)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator101)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator102)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator103)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator104)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator105)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator106)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator107)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator108)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator109)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator110)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator111)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator112)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator113)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator114)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator115)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator116)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator117)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator118)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator119)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator120)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator121)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator122)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator123)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator124)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator125)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator126)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator127)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator128)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator129)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator130)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator131)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator132)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator133)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator134)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator135)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator136)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator137)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator138)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator139)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator140)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator141)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator142)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator143)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator144)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator145)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator146)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator147)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator148)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator149)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator150)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator151)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator152)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator153)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator154)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator155)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator156)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator157)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator158)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator159)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator160)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator161)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator162)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator163)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator164)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator165)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator166)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator167)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator168)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator169)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator170)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator171)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator172)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator173)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator174)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator175)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator176)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator177)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator178)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator179)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator180)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator181)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator182)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator183)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator184)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator185)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator186)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator187)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator188)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator189)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator190)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator191)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator192)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator193)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator194)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator195)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator196)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator197)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator198)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator199)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator200)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator201)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator202)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator203)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator204)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator205)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator206)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator207)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator208)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator209)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator210)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator211)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator212)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator213)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator214)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator215)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator216)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator217)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator218)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator219)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator220)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator221)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator222)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator223)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator224)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator225)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator226)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator227)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator228)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator229)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator230)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator231)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator232)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator233)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator234)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator235)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator236)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator237)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator238)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator239)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator240)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator241)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator242)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator243)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator244)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator245)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator246)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator247)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator248)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator249)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator250)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator251)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator252)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator253)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator254)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator255)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator256)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator257)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator258)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator259)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator260)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator261)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator262)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator263)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator264)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator265)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator266)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator267)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator268)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator269)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator270)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator271)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator272)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator273)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator274)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator275)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator276)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator277)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator278)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator279)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator280)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator281)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator282)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator283)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator284)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator285)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator286)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator287)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator288)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator289)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator290)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator291)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator292)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator293)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator294)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator295)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator296)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator297)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator298)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator299)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator300)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator301)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator302)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator303)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator304)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator305)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator306)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator307)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator308)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator309)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator310)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator311)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator312)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator313)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator314)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator315)) 
                                    || (CurrentToken.TokenType == AphidTokenType.CustomOperator316))) {
                            var op = CurrentToken.TokenType;
                            NextToken();
                            exp = new BinaryOperatorBodyExpression(this._context, op, ParseFunctionDeclaration());
                        }
                        else {
                            exp = new PartialFunctionExpression(this._context, ParseCallExpression());
                        }
                    }
                }
            }
            return exp;
        }
        
        private AphidExpression ParsePatternMatchingExpression() {
            NextToken();
            var patterns = new System.Collections.Generic.List<PatternExpression>();
            Match(AphidTokenType.LeftParenthesis);
            var index003F = CurrentToken.Index;
            var testExp = ParseExpression();
            if ((testExp.Index < 0)) {
                testExp.Index = index003F;
                testExp.Length = (CurrentToken.Index - index003F);
            }
            Match(AphidTokenType.RightParenthesis);
            for (
            ; true; 
            ) {
                var tuple = new System.Collections.Generic.List<AphidExpression>();
                for (
                ; true; 
                ) {
                    tuple.Add(ParseExpression());
                    if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                        NextToken();
                    }
                    else {
break;
                    }
                }
                AphidExpression valueExp = default(AphidExpression);
                if ((CurrentToken.TokenType == AphidTokenType.ColonOperator)) {
                    NextToken();
                    var index0040 = CurrentToken.Index;
                    valueExp = ParseExpression();
                    if ((valueExp.Index < 0)) {
                        valueExp.Index = index0040;
                        valueExp.Length = (CurrentToken.Index - index0040);
                    }
                    patterns.Add(new PatternExpression(this._context, valueExp, tuple));
                }
                else {
                    if ((tuple.Count != 1)) {
                        throw new AphidParserException(CurrentToken);
                    }
                    patterns.Add(new PatternExpression(this._context, tuple[0]));
                }
                if ((CurrentToken.TokenType == AphidTokenType.Comma)) {
                    NextToken();
                }
                else {
break;
                }
            }
            return new PatternMatchingExpression(this._context, testExp, patterns);
        }
        
        private AphidExpression ParseFactorExpression() {
            AphidExpression exp = default(AphidExpression);
            if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                var index0041 = CurrentToken.Index;
                exp = ParseObjectExpression();
                if ((exp.Index < 0)) {
                    exp.Index = index0041;
                    exp.Length = (CurrentToken.Index - index0041);
                }
            }
            else {
                if ((CurrentToken.TokenType == AphidTokenType.LeftBracket)) {
                    var index0042 = CurrentToken.Index;
                    exp = ParseArrayExpression();
                    if ((exp.Index < 0)) {
                        exp.Index = index0042;
                        exp.Length = (CurrentToken.Index - index0042);
                    }
                }
                else {
                    if ((CurrentToken.TokenType == AphidTokenType.LeftParenthesis)) {
                        NextToken();
                        var index0043 = CurrentToken.Index;
                        exp = ParseExpression();
                        if ((exp.Index < 0)) {
                            exp.Index = index0043;
                            exp.Length = (CurrentToken.Index - index0043);
                        }
                        Match(AphidTokenType.RightParenthesis);
                    }
                    else {
                        if ((CurrentToken.TokenType == AphidTokenType.String)) {
                            var index0044 = CurrentToken.Index;
                            exp = ParseStringExpression();
                            if ((exp.Index < 0)) {
                                exp.Index = index0044;
                                exp.Length = (CurrentToken.Index - index0044);
                            }
                        }
                        else {
                            if ((CurrentToken.TokenType == AphidTokenType.Number)) {
                                var index0045 = CurrentToken.Index;
                                exp = ParseNumberExpression();
                                if ((exp.Index < 0)) {
                                    exp.Index = index0045;
                                    exp.Length = (CurrentToken.Index - index0045);
                                }
                            }
                            else {
                                if ((CurrentToken.TokenType == AphidTokenType.Identifier)) {
                                    var index0046 = CurrentToken.Index;
                                    var id = ParseIdentifierExpression();
                                    if ((id.Index < 0)) {
                                        id.Index = index0046;
                                        id.Length = (CurrentToken.Index - index0046);
                                    }
                                    if ((CurrentToken.TokenType == AphidTokenType.definedKeyword)) {
                                        NextToken();
                                        exp = new UnaryOperatorExpression(this._context, AphidTokenType.definedKeyword, id, true);
                                    }
                                    else {
                                        if ((CurrentToken.TokenType == AphidTokenType.LeftBrace)) {
                                            var index0047 = CurrentToken.Index;
                                            var obj = ParseObjectExpression();
                                            if ((obj.Index < 0)) {
                                                obj.Index = index0047;
                                                obj.Length = (CurrentToken.Index - index0047);
                                            }
                                            exp = new ObjectExpression(this._context, obj.Pairs, id);
                                        }
                                        else {
                                            exp = id;
                                        }
                                    }
                                }
                                else {
                                    if ((CurrentToken.TokenType == AphidTokenType.FunctionOperator)) {
                                        var index0048 = CurrentToken.Index;
                                        exp = ParseFunctionExpression();
                                        if ((exp.Index < 0)) {
                                            exp.Index = index0048;
                                            exp.Length = (CurrentToken.Index - index0048);
                                        }
                                    }
                                    else {
                                        if ((CurrentToken.TokenType == AphidTokenType.ImplicitArgumentOperator)) {
                                            var op = CurrentToken.TokenType;
                                            NextToken();
                                            exp = new ImplicitArgumentExpression(this._context, op);
                                        }
                                        else {
                                            if ((CurrentToken.TokenType == AphidTokenType.ImplicitArgumentsOperator)) {
                                                var op = CurrentToken.TokenType;
                                                NextToken();
                                                exp = new ImplicitArgumentsExpression(this._context, op);
                                            }
                                            else {
                                                if ((((CurrentToken.TokenType == AphidTokenType.throwKeyword) 
                                                            || (CurrentToken.TokenType == AphidTokenType.retKeyword)) 
                                                            || (CurrentToken.TokenType == AphidTokenType.deleteKeyword))) {
                                                    var index0049 = CurrentToken.Index;
                                                    exp = ParseUnaryExpression();
                                                    if ((exp.Index < 0)) {
                                                        exp.Index = index0049;
                                                        exp.Length = (CurrentToken.Index - index0049);
                                                    }
                                                }
                                                else {
                                                    if ((CurrentToken.TokenType == AphidTokenType.trueKeyword)) {
                                                        exp = new BooleanExpression(this._context, true);
                                                        NextToken();
                                                    }
                                                    else {
                                                        if ((CurrentToken.TokenType == AphidTokenType.falseKeyword)) {
                                                            exp = new BooleanExpression(this._context, false);
                                                            NextToken();
                                                        }
                                                        else {
                                                            if ((CurrentToken.TokenType == AphidTokenType.thisKeyword)) {
                                                                exp = new ThisExpression(this._context);
                                                                NextToken();
                                                            }
                                                            else {
                                                                if ((CurrentToken.TokenType == AphidTokenType.LoadScriptOperator)) {
                                                                    var index004A = CurrentToken.Index;
                                                                    exp = ParseLoadScriptExpression();
                                                                    if ((exp.Index < 0)) {
                                                                        exp.Index = index004A;
                                                                        exp.Length = (CurrentToken.Index - index004A);
                                                                    }
                                                                }
                                                                else {
                                                                    if ((CurrentToken.TokenType == AphidTokenType.LoadLibraryOperator)) {
                                                                        var index004B = CurrentToken.Index;
                                                                        exp = ParseLoadLibraryExpression();
                                                                        if ((exp.Index < 0)) {
                                                                            exp.Index = index004B;
                                                                            exp.Length = (CurrentToken.Index - index004B);
                                                                        }
                                                                    }
                                                                    else {
                                                                        if ((CurrentToken.TokenType == AphidTokenType.nullKeyword)) {
                                                                            exp = new NullExpression(this._context);
                                                                            NextToken();
                                                                        }
                                                                        else {
                                                                            if ((CurrentToken.TokenType == AphidTokenType.continueKeyword)) {
                                                                                exp = new ContinueExpression(this._context);
                                                                                NextToken();
                                                                            }
                                                                            else {
                                                                                if ((CurrentToken.TokenType == AphidTokenType.breakKeyword)) {
                                                                                    exp = new BreakExpression(this._context);
                                                                                    NextToken();
                                                                                }
                                                                                else {
                                                                                    if ((CurrentToken.TokenType == AphidTokenType.HexNumber)) {
                                                                                        exp = new NumberExpression(this._context, System.Convert.ToUInt64(CurrentToken.Lexeme.Substring(2), 16));
                                                                                        NextToken();
                                                                                    }
                                                                                    else {
                                                                                        if ((CurrentToken.TokenType == AphidTokenType.BinaryNumber)) {
                                                                                            exp = new NumberExpression(this._context, BinaryNumber.Parse(CurrentToken.Lexeme.Substring(2)));
                                                                                            NextToken();
                                                                                        }
                                                                                        else {
                                                                                            if ((CurrentToken.TokenType == AphidTokenType.PatternMatchingOperator)) {
                                                                                                var index004C = CurrentToken.Index;
                                                                                                exp = ParsePatternMatchingExpression();
                                                                                                if ((exp.Index < 0)) {
                                                                                                    exp.Index = index004C;
                                                                                                    exp.Length = (CurrentToken.Index - index004C);
                                                                                                }
                                                                                            }
                                                                                            else {
                                                                                                throw new AphidParserException(CurrentToken);
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
        
        private AphidExpression ParseTextExpression() {
            AphidExpression t = default(AphidExpression);
            if ((CurrentToken.TokenType == AphidTokenType.Text)) {
                t = new TextExpression(this._context, CurrentToken.Lexeme);
                NextToken();
            }
            else {
                t = new TextExpression(this._context, "");
            }
            return t;
        }
        
        private AphidExpression ParseGatorEmitExpression() {
            NextToken();
            var t = new GatorEmitExpression(this._context, ParseExpression());
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
andKeyword,
AndOperator,
AnyOperator,
AphidExpressionOperator,
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
CountOperator,
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
EndsWithOperator,
EqualityOperator,
extendKeyword,
falseKeyword,
finallyKeyword,
FirstOperator,
forKeyword,
FunctionOperator,
GatorCloseOperator,
GatorEmitOperator,
GatorOpenOperator,
GreaterThanOperator,
GreaterThanOrEqualOperator,
GroupByOperator,
HexNumber,
Identifier,
ifKeyword,
ImplicitArgumentOperator,
ImplicitArgumentsOperator,
IncrementOperator,
inKeyword,
InteropOperator,
LastOperator,
LeftBrace,
LeftBracket,
LeftParenthesis,
LessThanOperator,
LessThanOrEqualOperator,
loadKeyword,
LoadLibraryOperator,
LoadScriptOperator,
lockKeyword,
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
OrderByDescendingOperator,
OrderByOperator,
OrEqualOperator,
orKeyword,
OrOperator,
PatternMatchingOperator,
PipelineOperator,
PlusEqualOperator,
PostfixAnyOperator,
PostfixCountOperator,
PostfixFirstOperator,
PostfixLastOperator,
PostfixManyOperator,
PostfixOrderDescendingOperator,
PostfixOrderOperator,
RangeOperator,
retKeyword,
ReverseCompositionOperator,
ReversePipelineOperator,
RightBrace,
RightBracket,
RightParenthesis,
SelectManyOperator,
SelectOperator,
ShellText,
ShiftLeft,
ShiftLeftEqualOperator,
ShiftRight,
ShiftRightEqualOperator,
StartsWithOperator,
String,
switchKeyword,
Text,
thisKeyword,
throwKeyword,
toKeyword,
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
        public readonly partial struct AphidToken
        {
            public readonly AphidTokenType TokenType;
            public readonly string Lexeme;
            public readonly int Index;

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
                return TokenType == AphidTokenType.breakKeyword||
                TokenType == AphidTokenType.catchKeyword||
                TokenType == AphidTokenType.continueKeyword||
                TokenType == AphidTokenType.defaultKeyword||
                TokenType == AphidTokenType.definedKeyword||
                TokenType == AphidTokenType.deleteKeyword||
                TokenType == AphidTokenType.doKeyword||
                TokenType == AphidTokenType.elseKeyword||
                TokenType == AphidTokenType.extendKeyword||
                TokenType == AphidTokenType.falseKeyword||
                TokenType == AphidTokenType.finallyKeyword||
                TokenType == AphidTokenType.forKeyword||
                TokenType == AphidTokenType.ifKeyword||
                TokenType == AphidTokenType.inKeyword||
                TokenType == AphidTokenType.loadKeyword||
                TokenType == AphidTokenType.lockKeyword||
                TokenType == AphidTokenType.newKeyword||
                TokenType == AphidTokenType.nullKeyword||
                TokenType == AphidTokenType.retKeyword||
                TokenType == AphidTokenType.switchKeyword||
                TokenType == AphidTokenType.thisKeyword||
                TokenType == AphidTokenType.throwKeyword||
                TokenType == AphidTokenType.trueKeyword||
                TokenType == AphidTokenType.tryKeyword||
                TokenType == AphidTokenType.usingKeyword||
                TokenType == AphidTokenType.whileKeyword||
                TokenType == AphidTokenType.andKeyword||
                TokenType == AphidTokenType.orKeyword||
                TokenType == AphidTokenType.toKeyword;
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
        
        return AphidTokenType.CustomOperator073;

    case '~':
        
        return AphidTokenType.CustomOperator074;

    case '!':
        
        return AphidTokenType.CustomOperator075;

    case '#':
        
        return AphidTokenType.CustomOperator076;

    case '^':
        
        return AphidTokenType.CustomOperator077;

    case '&':
        
        return AphidTokenType.CustomOperator078;

    case '*':
        
        return AphidTokenType.CustomOperator079;

    case '-':
        
        return AphidTokenType.CustomOperator080;

    case '\\':
        
        return AphidTokenType.CustomOperator081;

    case '+':
        
        return AphidTokenType.CustomOperator082;

    case ':':
        
        return AphidTokenType.CustomOperator083;

    case '<':
        
        return AphidTokenType.CustomOperator084;

    case '.':
        
        return AphidTokenType.CustomOperator085;

    case '|':
        
        return AphidTokenType.CustomOperator086;

    case '/':
        
        return AphidTokenType.CustomOperator087;

    case '?':
        
        return AphidTokenType.CustomOperator088;

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

    case '!':
        
        return AphidTokenType.PostfixCountOperator;

    case '`':
        
        return AphidTokenType.CustomOperator056;

    case '~':
        
        return AphidTokenType.CustomOperator057;

    case '%':
        
        return AphidTokenType.CustomOperator058;

    case '^':
        
        return AphidTokenType.CustomOperator059;

    case '&':
        
        return AphidTokenType.CustomOperator060;

    case '*':
        
        return AphidTokenType.CustomOperator061;

    case '-':
        
        return AphidTokenType.CustomOperator062;

    case '=':
        
        return AphidTokenType.CustomOperator063;

    case '\\':
        
        return AphidTokenType.CustomOperator064;

    case '+':
        
        return AphidTokenType.CustomOperator065;

    case ':':
        
        return AphidTokenType.CustomOperator066;

    case '<':
        
        return AphidTokenType.CustomOperator067;

    case '>':
        
        return AphidTokenType.CustomOperator068;

    case '.':
        
        return AphidTokenType.CustomOperator069;

    case '|':
        
        return AphidTokenType.CustomOperator070;

    case '/':
        
        return AphidTokenType.CustomOperator071;

    case '?':
        
        return AphidTokenType.CustomOperator072;

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
        
        return AphidTokenType.CustomOperator201;

    case '~':
        
        return AphidTokenType.CustomOperator202;

    case '!':
        
        return AphidTokenType.CustomOperator203;

    case '#':
        
        return AphidTokenType.CustomOperator204;

    case '%':
        
        return AphidTokenType.CustomOperator205;

    case '^':
        
        return AphidTokenType.CustomOperator206;

    case '&':
        
        return AphidTokenType.CustomOperator207;

    case '*':
        
        return AphidTokenType.CustomOperator208;

    case '-':
        
        return AphidTokenType.CustomOperator209;

    case '=':
        
        return AphidTokenType.CustomOperator210;

    case '\\':
        
        return AphidTokenType.CustomOperator211;

    case '+':
        
        return AphidTokenType.CustomOperator212;

    case ':':
        
        return AphidTokenType.CustomOperator213;

    case '<':
        
        return AphidTokenType.CustomOperator214;

    case '>':
        
        return AphidTokenType.CustomOperator215;

    case '.':
        
        return AphidTokenType.CustomOperator216;

    case '|':
        
        return AphidTokenType.CustomOperator217;

    case '/':
        
        return AphidTokenType.CustomOperator218;

    case '?':
        
        return AphidTokenType.CustomOperator219;

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

    case '<':
            if (charIndex < lastIndex)
    {
        currentChar = text[++charIndex];

        switch (currentChar)
        {
                case '@':
        
        return AphidTokenType.ReverseCompositionOperator;

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

    case '|':
        
        return AphidTokenType.ReversePipelineOperator;

    case '`':
        
        return AphidTokenType.CustomOperator220;

    case '~':
        
        return AphidTokenType.CustomOperator221;

    case '!':
        
        return AphidTokenType.CustomOperator222;

    case '#':
        
        return AphidTokenType.CustomOperator223;

    case '%':
        
        return AphidTokenType.CustomOperator224;

    case '^':
        
        return AphidTokenType.CustomOperator225;

    case '&':
        
        return AphidTokenType.CustomOperator226;

    case '*':
        
        return AphidTokenType.CustomOperator227;

    case '-':
        
        return AphidTokenType.CustomOperator228;

    case '\\':
        
        return AphidTokenType.CustomOperator229;

    case '+':
        
        return AphidTokenType.CustomOperator230;

    case ':':
        
        return AphidTokenType.CustomOperator231;

    case '.':
        
        return AphidTokenType.CustomOperator232;

    case '/':
        
        return AphidTokenType.CustomOperator233;

    case '?':
        
        return AphidTokenType.CustomOperator234;

        }

        charIndex--;
    }
        return AphidTokenType.LessThanOperator;

    case '?':
            if (charIndex < lastIndex)
    {
        currentChar = text[++charIndex];

        switch (currentChar)
        {
                case '!':
        
        return AphidTokenType.PostfixAnyOperator;

    case '`':
        
        return AphidTokenType.CustomOperator299;

    case '~':
        
        return AphidTokenType.CustomOperator300;

    case '#':
        
        return AphidTokenType.CustomOperator301;

    case '%':
        
        return AphidTokenType.CustomOperator302;

    case '^':
        
        return AphidTokenType.CustomOperator303;

    case '&':
        
        return AphidTokenType.CustomOperator304;

    case '*':
        
        return AphidTokenType.CustomOperator305;

    case '-':
        
        return AphidTokenType.CustomOperator306;

    case '=':
        
        return AphidTokenType.CustomOperator307;

    case '\\':
        
        return AphidTokenType.CustomOperator308;

    case '+':
        
        return AphidTokenType.CustomOperator309;

    case ':':
        
        return AphidTokenType.CustomOperator310;

    case '<':
        
        return AphidTokenType.CustomOperator311;

    case '>':
        
        return AphidTokenType.CustomOperator312;

    case '.':
        
        return AphidTokenType.CustomOperator313;

    case '|':
        
        return AphidTokenType.CustomOperator314;

    case '/':
        
        return AphidTokenType.CustomOperator315;

    case '?':
        
        return AphidTokenType.CustomOperator316;

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
        
        return AphidTokenType.CustomOperator250;

    case '~':
        
        return AphidTokenType.CustomOperator251;

    case '!':
        
        return AphidTokenType.CustomOperator252;

    case '#':
        
        return AphidTokenType.CustomOperator253;

    case '%':
        
        return AphidTokenType.CustomOperator254;

    case '^':
        
        return AphidTokenType.CustomOperator255;

    case '&':
        
        return AphidTokenType.CustomOperator256;

    case '*':
        
        return AphidTokenType.CustomOperator257;

    case '-':
        
        return AphidTokenType.CustomOperator258;

    case '=':
        
        return AphidTokenType.CustomOperator259;

    case '\\':
        
        return AphidTokenType.CustomOperator260;

    case '+':
        
        return AphidTokenType.CustomOperator261;

    case ':':
        
        return AphidTokenType.CustomOperator262;

    case '<':
        
        return AphidTokenType.CustomOperator263;

    case '>':
        
        return AphidTokenType.CustomOperator264;

    case '|':
        
        return AphidTokenType.CustomOperator265;

    case '/':
        
        return AphidTokenType.CustomOperator266;

    case '?':
        
        return AphidTokenType.CustomOperator267;

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
        
        return AphidTokenType.CustomOperator150;

    case '~':
        
        return AphidTokenType.CustomOperator151;

    case '!':
        
        return AphidTokenType.CustomOperator152;

    case '#':
        
        return AphidTokenType.CustomOperator153;

    case '%':
        
        return AphidTokenType.CustomOperator154;

    case '^':
        
        return AphidTokenType.CustomOperator155;

    case '&':
        
        return AphidTokenType.CustomOperator156;

    case '*':
        
        return AphidTokenType.CustomOperator157;

    case '-':
        
        return AphidTokenType.CustomOperator158;

    case '\\':
        
        return AphidTokenType.CustomOperator159;

    case '+':
        
        return AphidTokenType.CustomOperator160;

    case ':':
        
        return AphidTokenType.CustomOperator161;

    case '<':
        
        return AphidTokenType.CustomOperator162;

    case '>':
        
        return AphidTokenType.CustomOperator163;

    case '.':
        
        return AphidTokenType.CustomOperator164;

    case '|':
        
        return AphidTokenType.CustomOperator165;

    case '/':
        
        return AphidTokenType.CustomOperator166;

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

    case '#':
        
        return AphidTokenType.CountOperator;

    case '&':
        
        return AphidTokenType.GroupByOperator;

    case '<':
        
        return AphidTokenType.SelectManyOperator;

    case '>':
        
        return AphidTokenType.SelectOperator;

    case '?':
        
        return AphidTokenType.WhereOperator;

    case '\\':
        
        return AphidTokenType.OrderByOperator;

    case '/':
        
        return AphidTokenType.OrderByDescendingOperator;

    case '`':
        
        return AphidTokenType.CustomOperator140;

    case '~':
        
        return AphidTokenType.CustomOperator141;

    case '!':
        
        return AphidTokenType.CustomOperator142;

    case '%':
        
        return AphidTokenType.CustomOperator143;

    case '^':
        
        return AphidTokenType.CustomOperator144;

    case '*':
        
        return AphidTokenType.CustomOperator145;

    case '+':
        
        return AphidTokenType.CustomOperator146;

    case ':':
        
        return AphidTokenType.CustomOperator147;

    case '.':
        
        return AphidTokenType.CustomOperator148;

    case '|':
        
        return AphidTokenType.CustomOperator149;

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
        
        return AphidTokenType.CustomOperator185;

    case '~':
        
        return AphidTokenType.CustomOperator186;

    case '!':
        
        return AphidTokenType.CustomOperator187;

    case '#':
        
        return AphidTokenType.CustomOperator188;

    case '%':
        
        return AphidTokenType.CustomOperator189;

    case '^':
        
        return AphidTokenType.CustomOperator190;

    case '&':
        
        return AphidTokenType.CustomOperator191;

    case '*':
        
        return AphidTokenType.CustomOperator192;

    case '-':
        
        return AphidTokenType.CustomOperator193;

    case '\\':
        
        return AphidTokenType.CustomOperator194;

    case ':':
        
        return AphidTokenType.CustomOperator195;

    case '<':
        
        return AphidTokenType.CustomOperator196;

    case '.':
        
        return AphidTokenType.CustomOperator197;

    case '|':
        
        return AphidTokenType.CustomOperator198;

    case '/':
        
        return AphidTokenType.CustomOperator199;

    case '?':
        
        return AphidTokenType.CustomOperator200;

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

    case '!':
        
        return AphidTokenType.PostfixManyOperator;

    case '`':
        
        return AphidTokenType.CustomOperator123;

    case '~':
        
        return AphidTokenType.CustomOperator124;

    case '#':
        
        return AphidTokenType.CustomOperator125;

    case '%':
        
        return AphidTokenType.CustomOperator126;

    case '^':
        
        return AphidTokenType.CustomOperator127;

    case '&':
        
        return AphidTokenType.CustomOperator128;

    case '*':
        
        return AphidTokenType.CustomOperator129;

    case '-':
        
        return AphidTokenType.CustomOperator130;

    case '\\':
        
        return AphidTokenType.CustomOperator131;

    case '+':
        
        return AphidTokenType.CustomOperator132;

    case ':':
        
        return AphidTokenType.CustomOperator133;

    case '<':
        
        return AphidTokenType.CustomOperator134;

    case '>':
        
        return AphidTokenType.CustomOperator135;

    case '.':
        
        return AphidTokenType.CustomOperator136;

    case '|':
        
        return AphidTokenType.CustomOperator137;

    case '/':
        
        return AphidTokenType.CustomOperator138;

    case '?':
        
        return AphidTokenType.CustomOperator139;

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

    case '!':
        
        return AphidTokenType.PostfixOrderDescendingOperator;

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
        
        return AphidTokenType.CustomOperator284;

    case '~':
        
        return AphidTokenType.CustomOperator285;

    case '#':
        
        return AphidTokenType.CustomOperator286;

    case '%':
        
        return AphidTokenType.CustomOperator287;

    case '^':
        
        return AphidTokenType.CustomOperator288;

    case '&':
        
        return AphidTokenType.CustomOperator289;

    case '-':
        
        return AphidTokenType.CustomOperator290;

    case '\\':
        
        return AphidTokenType.CustomOperator291;

    case '+':
        
        return AphidTokenType.CustomOperator292;

    case ':':
        
        return AphidTokenType.CustomOperator293;

    case '<':
        
        return AphidTokenType.CustomOperator294;

    case '>':
        
        return AphidTokenType.CustomOperator295;

    case '.':
        
        return AphidTokenType.CustomOperator296;

    case '|':
        
        return AphidTokenType.CustomOperator297;

    case '?':
        
        return AphidTokenType.CustomOperator298;

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
        
        return AphidTokenType.CustomOperator106;

    case '~':
        
        return AphidTokenType.CustomOperator107;

    case '!':
        
        return AphidTokenType.CustomOperator108;

    case '#':
        
        return AphidTokenType.CustomOperator109;

    case '%':
        
        return AphidTokenType.CustomOperator110;

    case '^':
        
        return AphidTokenType.CustomOperator111;

    case '*':
        
        return AphidTokenType.CustomOperator112;

    case '-':
        
        return AphidTokenType.CustomOperator113;

    case '\\':
        
        return AphidTokenType.CustomOperator114;

    case '+':
        
        return AphidTokenType.CustomOperator115;

    case ':':
        
        return AphidTokenType.CustomOperator116;

    case '<':
        
        return AphidTokenType.CustomOperator117;

    case '>':
        
        return AphidTokenType.CustomOperator118;

    case '.':
        
        return AphidTokenType.CustomOperator119;

    case '|':
        
        return AphidTokenType.CustomOperator120;

    case '/':
        
        return AphidTokenType.CustomOperator121;

    case '?':
        
        return AphidTokenType.CustomOperator122;

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
        
        return AphidTokenType.CustomOperator268;

    case '~':
        
        return AphidTokenType.CustomOperator269;

    case '!':
        
        return AphidTokenType.CustomOperator270;

    case '#':
        
        return AphidTokenType.CustomOperator271;

    case '%':
        
        return AphidTokenType.CustomOperator272;

    case '^':
        
        return AphidTokenType.CustomOperator273;

    case '&':
        
        return AphidTokenType.CustomOperator274;

    case '*':
        
        return AphidTokenType.CustomOperator275;

    case '-':
        
        return AphidTokenType.CustomOperator276;

    case '\\':
        
        return AphidTokenType.CustomOperator277;

    case '+':
        
        return AphidTokenType.CustomOperator278;

    case ':':
        
        return AphidTokenType.CustomOperator279;

    case '<':
        
        return AphidTokenType.CustomOperator280;

    case '.':
        
        return AphidTokenType.CustomOperator281;

    case '/':
        
        return AphidTokenType.CustomOperator282;

    case '?':
        
        return AphidTokenType.CustomOperator283;

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

    case '!':
        
        return AphidTokenType.PostfixFirstOperator;

    case '`':
        
        return AphidTokenType.CustomOperator089;

    case '~':
        
        return AphidTokenType.CustomOperator090;

    case '#':
        
        return AphidTokenType.CustomOperator091;

    case '%':
        
        return AphidTokenType.CustomOperator092;

    case '^':
        
        return AphidTokenType.CustomOperator093;

    case '&':
        
        return AphidTokenType.CustomOperator094;

    case '*':
        
        return AphidTokenType.CustomOperator095;

    case '-':
        
        return AphidTokenType.CustomOperator096;

    case '\\':
        
        return AphidTokenType.CustomOperator097;

    case '+':
        
        return AphidTokenType.CustomOperator098;

    case ':':
        
        return AphidTokenType.CustomOperator099;

    case '<':
        
        return AphidTokenType.CustomOperator100;

    case '>':
        
        return AphidTokenType.CustomOperator101;

    case '.':
        
        return AphidTokenType.CustomOperator102;

    case '|':
        
        return AphidTokenType.CustomOperator103;

    case '/':
        
        return AphidTokenType.CustomOperator104;

    case '?':
        
        return AphidTokenType.CustomOperator105;

        }

        charIndex--;
    }
        return AphidTokenType.XorOperator;

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

    case '^':
        
        return AphidTokenType.FirstOperator;

    case '$':
        
        return AphidTokenType.LastOperator;

    case '#':
        
        return AphidTokenType.CountOperator;

    case '`':
        
        return AphidTokenType.CustomOperator235;

    case '~':
        
        return AphidTokenType.CustomOperator236;

    case '!':
        
        return AphidTokenType.CustomOperator237;

    case '%':
        
        return AphidTokenType.CustomOperator238;

    case '&':
        
        return AphidTokenType.CustomOperator239;

    case '*':
        
        return AphidTokenType.CustomOperator240;

    case '-':
        
        return AphidTokenType.CustomOperator241;

    case '\\':
        
        return AphidTokenType.CustomOperator242;

    case '+':
        
        return AphidTokenType.CustomOperator243;

    case ':':
        
        return AphidTokenType.CustomOperator244;

    case '<':
        
        return AphidTokenType.CustomOperator245;

    case '.':
        
        return AphidTokenType.CustomOperator246;

    case '|':
        
        return AphidTokenType.CustomOperator247;

    case '/':
        
        return AphidTokenType.CustomOperator248;

    case '?':
        
        return AphidTokenType.CustomOperator249;

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
                case '^':
        
        return AphidTokenType.StartsWithOperator;

    case '$':
        
        return AphidTokenType.EndsWithOperator;

    case '`':
        
        return AphidTokenType.CustomOperator021;

    case '~':
        
        return AphidTokenType.CustomOperator022;

    case '!':
        
        return AphidTokenType.CustomOperator023;

    case '#':
        
        return AphidTokenType.CustomOperator024;

    case '%':
        
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
                case '!':
        
        return AphidTokenType.PostfixLastOperator;

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

    case '\\':
            if (charIndex < lastIndex)
    {
        currentChar = text[++charIndex];

        switch (currentChar)
        {
                case '!':
        
        return AphidTokenType.PostfixOrderOperator;

    case '`':
        
        return AphidTokenType.CustomOperator167;

    case '~':
        
        return AphidTokenType.CustomOperator168;

    case '#':
        
        return AphidTokenType.CustomOperator169;

    case '%':
        
        return AphidTokenType.CustomOperator170;

    case '^':
        
        return AphidTokenType.CustomOperator171;

    case '&':
        
        return AphidTokenType.CustomOperator172;

    case '*':
        
        return AphidTokenType.CustomOperator173;

    case '-':
        
        return AphidTokenType.CustomOperator174;

    case '=':
        
        return AphidTokenType.CustomOperator175;

    case '\\':
        
        return AphidTokenType.CustomOperator176;

    case '+':
        
        return AphidTokenType.CustomOperator177;

    case ':':
        
        return AphidTokenType.CustomOperator178;

    case '<':
        
        return AphidTokenType.CustomOperator179;

    case '>':
        
        return AphidTokenType.CustomOperator180;

    case '.':
        
        return AphidTokenType.CustomOperator181;

    case '|':
        
        return AphidTokenType.CustomOperator182;

    case '/':
        
        return AphidTokenType.CustomOperator183;

    case '?':
        
        return AphidTokenType.CustomOperator184;

        }

        charIndex--;
    }
        return AphidTokenType.CustomOperator001;

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
        
        return AphidTokenType.CustomOperator002;

    case '~':
        
        return AphidTokenType.CustomOperator003;

    case '!':
        
        return AphidTokenType.CustomOperator004;

    case '#':
        
        return AphidTokenType.CustomOperator005;

    case '%':
        
        return AphidTokenType.CustomOperator006;

    case '^':
        
        return AphidTokenType.CustomOperator007;

    case '&':
        
        return AphidTokenType.CustomOperator008;

    case '*':
        
        return AphidTokenType.CustomOperator009;

    case '-':
        
        return AphidTokenType.CustomOperator010;

    case '=':
        
        return AphidTokenType.CustomOperator011;

    case '\\':
        
        return AphidTokenType.CustomOperator012;

    case '+':
        
        return AphidTokenType.CustomOperator013;

    case ':':
        
        return AphidTokenType.CustomOperator014;

    case '<':
        
        return AphidTokenType.CustomOperator015;

    case '>':
        
        return AphidTokenType.CustomOperator016;

    case '.':
        
        return AphidTokenType.CustomOperator017;

    case '|':
        
        return AphidTokenType.CustomOperator018;

    case '/':
        
        return AphidTokenType.CustomOperator019;

    case '?':
        
        return AphidTokenType.CustomOperator020;

        }

        charIndex--;
    }
        return AphidTokenType.CustomOperator000;

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

    case 'c':
            if (charIndex < lastIndex)
    {
        currentChar = text[++charIndex];

        switch (currentChar)
        {
                case 'k':
        
        
    if (!NextChar())
    {
        return AphidTokenType.lockKeyword;
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

            return AphidTokenType.lockKeyword;
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

    case 't':
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

    case 'r':
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
                case 'w':
        
        
    if (!NextChar())
    {
        return AphidTokenType.throwKeyword;
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

            return AphidTokenType.throwKeyword;
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

    case 'o':
        
        
    if (!NextChar())
    {
        return AphidTokenType.toKeyword;
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

            return AphidTokenType.toKeyword;
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

    case 'a':
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
        return AphidTokenType.andKeyword;
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

            return AphidTokenType.andKeyword;
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
        return AphidTokenType.orKeyword;
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

            return AphidTokenType.orKeyword;
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
                    else 
                    if (mode == 2)
                    {
                            if (charIndex < lastIndex)
    {
        currentChar = text[++charIndex];

        switch (currentChar)
        {
                case '$':
        
        mode = 0;
return AphidTokenType.AphidExpressionOperator;

default:

    state = 0;

    while (NextChar())
    {
        if (currentChar == '^')
        {
            if (state == 0)
            {
                state = 1;
            }
            else if (state == 1)
            {
                state = 0;
            }
        }
        else if (currentChar == '$')
        {
            if (state == 1)
            {
                state = 0;
            }
            else
            {
                charIndex--;

                return AphidTokenType.ShellText;
            }
        }
    }

    return AphidTokenType.ShellText;

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
                    if (tokenType != AphidTokenType.WhiteSpace&&tokenType != AphidTokenType.Comment)
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