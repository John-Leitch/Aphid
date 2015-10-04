using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Components.Aphid.Interpreter
{
    public class AphidInterpreter
    {
        private const string _return = "$r";

        private bool _isReturning = false;

        private bool _isBreaking = false;

        private AphidObjectEqualityComparer _comparer = new AphidObjectEqualityComparer();

        private AphidLoader _loader;

        public AphidLoader Loader
        {
            get { return _loader; }
        }

        private AphidObject _currentScope;

        public AphidObject CurrentScope
        {
            get { return _currentScope; }
        }

        public AphidInterpreter()
        {
            Init();

            _currentScope = new AphidObject();
        }

        public AphidInterpreter(AphidObject currentScope)
        {
            Init();
            _currentScope = currentScope;
        }

        private void Init()
        {
            _loader = new AphidLoader(this);
        }

        private AphidRuntimeException CreateUndefinedMemberException(AphidExpression expression, AphidExpression memberExpression)
        {
            return new AphidRuntimeException(
                    "Undefined member {0} in expression {1}",
                    memberExpression,
                    expression);
        }

        private AphidRuntimeException CreateUnaryOperatorException(UnaryOperatorExpression expression)
        {
            return new AphidRuntimeException("Unknown operator {0} in expression {1}.", expression.Operator, expression);
        }

        public AphidObject GetReturnValue()
        {
            AphidObject retVal = null;

            if (_currentScope.TryResolve(_return, out retVal))
            {
                _currentScope.Remove(_return);
            }

            return retVal;
        }

        private void SetReturnValue(AphidObject obj)
        {
            _currentScope.Add(_return, obj);
        }

        public void EnterChildScope()
        {
            _currentScope = new AphidObject(null, _currentScope);
        }

        public bool LeaveChildScope(bool bubbleReturnValue = false)
        {
            if (bubbleReturnValue)
            {
                var ret = GetReturnValue();
                _currentScope = _currentScope.Parent;

                if (ret != null)
                {
                    SetReturnValue(ret);

                    return true;
                }
            }
            else
            {
                _currentScope = _currentScope.Parent;
            }

            return false;
        }

        private void InterpretChild(List<AphidExpression> block)
        {
            EnterChildScope();
            Interpret(block, false);
            LeaveChildScope(true);
        }

        private AphidObject CompareDecimals(BinaryOperatorExpression expression, Func<decimal, decimal, bool> equal)
        {
            return new AphidObject(
                equal(
                    (decimal)ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand)),
                    (decimal)ValueHelper.Unwrap(InterpretExpression(expression.RightOperand))));
        }

        private AphidObject InterpretAndExpression(BinaryOperatorExpression expression)
        {
            var left = (bool)ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand));

            if (!left)
            {
                return new AphidObject(false);
            }
            else
            {
                return new AphidObject((bool)ValueHelper.Unwrap(InterpretExpression(expression.RightOperand)));
            }
        }

        private AphidObject InterpretOrExpression(BinaryOperatorExpression expression)
        {
            var left = (bool)ValueHelper.Unwrap(InterpretExpression(expression.LeftOperand));

            if (left)
            {
                return new AphidObject(true);
            }
            else
            {
                return new AphidObject((bool)ValueHelper.Unwrap(InterpretExpression(expression.RightOperand)));
            }
        }        

        private AphidObject InterpretEqualityExpression(BinaryOperatorExpression expression)
        {
            var left = (AphidObject)InterpretExpression(expression.LeftOperand);
            var right = (AphidObject)InterpretExpression(expression.RightOperand);

            bool val;

            if (left == null)
            {
                throw CreateUndefinedMemberException(expression, expression.LeftOperand);
            }
            else if (right == null)
            {
                throw CreateUndefinedMemberException(expression, expression.RightOperand);
            }
            else if (left.Value != null)
            {
                val = left.Value.Equals(right.Value);
            }
            else if (right.Value != null)
            {
                val = right.Value.Equals(left.Value);                
            }
            else
            {
                val = left.Count == 0 && right.Count == 0;
            }            

            if (expression.Operator == AphidTokenType.NotEqualOperator)
            {
                val = !val;
            }

            return new AphidObject(val);
        }

        private object InterpretMemberExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            var obj = InterpretExpression(expression.LeftOperand) as AphidObject;

            string key;

            if (expression.RightOperand is IdentifierExpression)
            {
                key = (expression.RightOperand as IdentifierExpression).Identifier;
            }
            else if (expression.RightOperand is StringExpression)
            {
                key = (string)ValueHelper.Unwrap(InterpretStringExpression(expression.RightOperand as StringExpression));
            }
            else if (expression.RightOperand is DynamicMemberExpression)
            {
                var memberExp = expression.RightOperand as DynamicMemberExpression;
                key = ValueHelper.Unwrap(InterpretExpression(memberExp.MemberExpression)).ToString();
            }
            else
            {
                throw new AphidRuntimeException("Unexpected expression {0}", expression.RightOperand);
            }

            if (returnRef)
            {
                return new AphidRef() { Name = key, Object = obj };
            }
            else
            {
                AphidObject val;

                if (obj == null)
                {
                    throw new AphidRuntimeException("Undefined member {0} in expression {1}",
                        expression.LeftOperand,
                        expression);
                }
                else if (!obj.TryResolve(key, out val))
                {
                    var t = obj.GetValueType();
                    var extKey = TypeExtender.GetName(t, key);

                    if (!_currentScope.TryResolve(extKey, out val))
                    {
                        throw new AphidRuntimeException("Undefined member {0} in expression {1}", key, expression);
                    }

                    var function = ((AphidFunction)val.Value).Clone();
                    function.ParentScope = new AphidObject { Parent = _currentScope };
                    function.ParentScope.Add(function.Args[0], obj);
                    function.Args = function.Args.Skip(1).ToArray();
                    val = new AphidObject(function);
                }

                return val;
            }
        }

        private object InterpetAssignmentExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            var value = InterpretExpression(expression.RightOperand);
            var value2 = value as AphidObject;
            var idExp = expression.LeftOperand as IdentifierExpression;
            ArrayAccessExpression arrayAccessExp;
            if (idExp != null)
            {
                var id = idExp.Identifier;
                var destObj = InterpretIdentifierExpression(idExp);

                if (destObj == null)
                {
                    destObj = new AphidObject();

                    _currentScope.Add(id, destObj);
                }
                else
                {
                    destObj.Clear();
                }

                if (value2 != null)
                {
                    destObj.Value = value2.Value;
                    destObj.Parent = value2.Parent;

                    foreach (var x in value2)
                    {
                        destObj.Add(x.Key, x.Value);
                    }
                }
                else
                {
                    destObj.Value = value;
                }
            }
            else if ((arrayAccessExp = expression.LeftOperand as ArrayAccessExpression) != null)
            {
                var obj = InterpretArrayAccessExpression(arrayAccessExp);
                obj.Value = ValueHelper.Unwrap(value);
            }
            else
            {
                var objRef = InterpretBinaryOperatorExpression(expression.LeftOperand as BinaryOperatorExpression, true) as AphidRef;

                if (objRef.Object == null)
                {
                    throw new AphidRuntimeException("Undefined variable {0}", expression.LeftOperand);
                }
                else if (objRef.Object.ContainsKey(objRef.Name))
                {
                    objRef.Object[objRef.Name].Value = ValueHelper.Unwrap(value);
                    //ValueHelper.Wrap(value).CopyTo(objRef.Object[objRef.Name]);
                }
                else
                {
                    objRef.Object.Add(objRef.Name, ValueHelper.Wrap(value));
                }
            }

            return value;
        }

        private AphidObject InterprentOperatorAndAssignmentExpression(
            Func<AphidObject, AphidObject, AphidObject> performOperation,
            BinaryOperatorExpression expression)
        {
            var left = InterpretExpression(expression.LeftOperand) as AphidObject;
            var value = performOperation(left, InterpretExpression(expression.RightOperand) as AphidObject);
            left.Value = value.Value;

            return left;
        }

        private object InterpretBinaryOperatorExpression(BinaryOperatorExpression expression, bool returnRef = false)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.AdditionOperator:
                    return OperatorHelper.Add(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MinusOperator:
                    return OperatorHelper.Subtract(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MultiplicationOperator:
                    return OperatorHelper.Multiply(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.DivisionOperator:
                    return OperatorHelper.Divide(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.MemberOperator:
                    return InterpretMemberExpression(expression, returnRef);

                case AphidTokenType.AssignmentOperator:
                    return InterpetAssignmentExpression(expression, returnRef);

                case AphidTokenType.PlusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Add, expression);

                case AphidTokenType.MinusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Subtract, expression);

                case AphidTokenType.MultiplicationEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Multiply, expression);                

                case AphidTokenType.DivisionEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Divide, expression);

                case AphidTokenType.ModulusEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Mod, expression);

                case AphidTokenType.BinaryAndEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryAnd, expression);

                case AphidTokenType.OrEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryOr, expression);

                case AphidTokenType.XorEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.Xor, expression);

                case AphidTokenType.ShiftLeftEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftLeft, expression);

                case AphidTokenType.ShiftRightEqualOperator:
                    return InterprentOperatorAndAssignmentExpression(OperatorHelper.BinaryShiftRight, expression);

                case AphidTokenType.NotEqualOperator:
                case AphidTokenType.EqualityOperator:
                    return InterpretEqualityExpression(expression);

                case AphidTokenType.LessThanOperator:
                    return CompareDecimals(expression, (x, y) => x < y);

                case AphidTokenType.LessThanOrEqualOperator:
                    return CompareDecimals(expression, (x, y) => x <= y);

                case AphidTokenType.GreaterThanOperator:
                    return CompareDecimals(expression, (x, y) => x > y);

                case AphidTokenType.GreaterThanOrEqualOperator:
                    return CompareDecimals(expression, (x, y) => x >= y);

                case AphidTokenType.AndOperator:
                    return InterpretAndExpression(expression);

                case AphidTokenType.OrOperator:
                    return InterpretOrExpression(expression);

                case AphidTokenType.ModulusOperator:
                    return OperatorHelper.Mod(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.ShiftLeft:
                    return OperatorHelper.BinaryShiftLeft(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.ShiftRight:
                    return OperatorHelper.BinaryShiftRight(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.BinaryAndOperator:
                    return OperatorHelper.BinaryAnd(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.BinaryOrOperator:
                    return OperatorHelper.BinaryOr(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.XorOperator:
                    return OperatorHelper.Xor(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.PipelineOperator:
                    return InterpretCallExpression(new CallExpression(expression.RightOperand, expression.LeftOperand));

                case AphidTokenType.RangeOperator:
                    return OperatorHelper.Range(
                        InterpretExpression(expression.LeftOperand) as AphidObject,
                        InterpretExpression(expression.RightOperand) as AphidObject);

                case AphidTokenType.SelectOperator:
                    var collection = (List<AphidObject>)((AphidObject)InterpretExpression(expression.LeftOperand)).Value;
                    var value = ((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    var func = value as AphidFunction;

                    if (func != null)
                    {
                        return new AphidObject(collection.Select(x => CallFunction(func, x)).ToList());
                    }

                    var func2 = value as AphidInteropFunction;

                    if (func2 != null)
                    {
                        return new AphidObject(collection.Select(x => CallInteropFunction(func2, x)).ToList());
                    }

                    throw new InvalidOperationException();

                case AphidTokenType.SelectManyOperator:
                    collection = (List<AphidObject>)((AphidObject)InterpretExpression(expression.LeftOperand)).Value;
                    value = ((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    func = value as AphidFunction;

                    if (func != null)
                    {
                        return new AphidObject(collection.SelectMany(x => (List<AphidObject>)CallFunction(func, x).Value).ToList());
                    }

                    func2 = value as AphidInteropFunction;

                    if (func2 != null)
                    {
                        return new AphidObject(collection.SelectMany(x => (List<AphidObject>)CallInteropFunction(func2, x).Value).ToList());
                    }

                    throw new InvalidOperationException();

                case AphidTokenType.AggregateOperator:
                    collection = (List<AphidObject>)((AphidObject)InterpretExpression(expression.LeftOperand)).Value;
                    value = ((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    func = value as AphidFunction;

                    if (func != null)
                    {
                        return collection.Aggregate((x, y) => CallFunction(func, x, y));
                    }

                    func2 = value as AphidInteropFunction;

                    if (func2 != null)
                    {
                        return collection.Aggregate((x, y) => CallInteropFunction(func2, x, y));
                    }

                    throw new InvalidOperationException();

                case AphidTokenType.AnyOperator:
                    collection = (List<AphidObject>)((AphidObject)InterpretExpression(expression.LeftOperand)).Value;
                    value = ((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    func = (AphidFunction)((AphidObject)InterpretExpression(expression.RightOperand)).Value;

                    if (func != null)
                    {
                        return new AphidObject(collection.Any(x => (bool)CallFunction(func, x).Value));
                    }

                    func2 = value as AphidInteropFunction;

                    if (func2 != null)
                    {
                        return new AphidObject(collection.Any(x => (bool)CallInteropFunction(func2, x).Value));
                    }

                    throw new InvalidOperationException();

                case AphidTokenType.WhereOperator:
                    collection = (List<AphidObject>)((AphidObject)InterpretExpression(expression.LeftOperand)).Value;
                    value = ((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    func = (AphidFunction)((AphidObject)InterpretExpression(expression.RightOperand)).Value;
                    
                    if (func != null)
                    {
                        return new AphidObject(collection.Where(x => (bool)CallFunction(func, x).Value).ToList());
                    }

                    func2 = value as AphidInteropFunction;

                    if (func2 != null)
                    {
                        return new AphidObject(collection.Where(x => (bool)CallInteropFunction(func2, x).Value).ToList());
                    }

                    throw new InvalidOperationException();

                

                default:
                    throw new AphidRuntimeException("Unknown operator {0} in expression {1}", expression.Operator, expression);
            }
        }

        private AphidObject InterpretObjectExpression(ObjectExpression expression)
        {
            var obj = new AphidObject();

            foreach (var kvp in expression.Pairs)
            {
                var id = (kvp.LeftOperand as IdentifierExpression).Identifier;
                var value = ValueHelper.Wrap(InterpretExpression(kvp.RightOperand));
                obj.Add(id, value);
            }

            return obj;
        }

        private AphidObject InterpretIdentifierExpression(IdentifierExpression expression)
        {
            AphidObject obj;

            if (_currentScope.TryResolve(expression.Identifier, out obj))
            {
                return obj;
            }
            else
            {
                return null;
            }
        }

        private AphidObject InterpretStringExpression(StringExpression expression)
        {
            return new AphidObject(StringParser.Parse(expression.Value));
        }

        public AphidObject CallFunction(string name, params object[] parms)
        {
            var val = InterpretIdentifierExpression(new IdentifierExpression(name));
            var func = ValueHelper.Unwrap(val) as AphidFunction;
            return CallFunction(func, parms);
        }

        public AphidObject CallFunction(AphidFunction function, params object[] parms)
        {
            return CallFunctionCore(function, parms.Select(ValueHelper.Wrap));
        }

        private AphidObject CallFunctionCore(AphidFunction function, IEnumerable<AphidObject> parms)
        {
            var functionScope = new AphidObject(null, function.ParentScope);
            var i = 0;

            foreach (var arg in parms)
            {
                if (function.Args.Length == i)
                {
                    break;
                }

                functionScope.Add(function.Args[i++], arg);
            }

            var lastScope = _currentScope;
            _currentScope = functionScope;
            Interpret(function.Body);
            var retVal = GetReturnValue();
            _currentScope = lastScope;

            return retVal;
        }

        private AphidObject CallInteropFunction(AphidInteropFunction func, params AphidObject[] objArgs)
        {
            object[] args = objArgs;

            if (func.UnwrapParameters)
            {
                args = objArgs.Select(x => x.Value).ToArray();
            }

            return ValueHelper.Wrap(func.Invoke(this, args));
        }

        public AphidObject CallFunction(AphidObject function, params object[] args)
        {
            var value = function.Value;
            var func = value as AphidFunction;

            if (func != null)
            {
                return CallFunction(func, args);
            }

            var func2 = value as AphidInteropFunction;

            if (func2 != null)
            {
                return CallInteropFunction(func2, (AphidObject[])args);
            }

            throw new AphidRuntimeException("Object is not function: {0}", function);
        }

        private AphidObject InterpretCallExpression(CallExpression expression)
        {
            var value = InterpretExpression(expression.FunctionExpression);

            object funcExp = ValueHelper.Unwrap(value);

            var func = funcExp as AphidInteropFunction;

            if (func == null)
            {
                var func2 = funcExp as AphidFunction;

                if (func2 == null)
                {
                    throw new AphidRuntimeException("Could not find function {0}", expression.FunctionExpression);
                }

                return CallFunctionCore(func2, expression.Args.Select(x => ValueHelper.Wrap(InterpretExpression(x))));
            }
            else
            {
                Func<AphidExpression, object> selector;

                if (func.UnwrapParameters)
                {
                    selector = x => ValueHelper.Unwrap(InterpretExpression(x));
                }
                else
                {
                    selector = x =>
                    {
                        var r = InterpretExpression(x);

                        if (r == null)
                        {
                            throw new AphidRuntimeException(
                                "Could not find variable {0} in call expression {1}", 
                                x, 
                                expression);
                        }

                        return r;
                    };
                }

                var args = expression.Args.Select(selector).ToArray();

                return ValueHelper.Wrap(func.Invoke(this, args));
            }
        }

        private AphidObject InterpretFunctionExpression(FunctionExpression expression)
        {
            return new AphidObject(new AphidFunction()
            {
                Args = expression.Args
                    .Select(x => ((IdentifierExpression)x).Identifier)
                    .ToArray(),

                Body = expression.Body,
                ParentScope = _currentScope,
            });
        }

        private AphidObject InterpretArrayExpression(ArrayExpression expression)
        {
            var list = new AphidObject(expression.Elements.Select(InterpretExpression).OfType<AphidObject>().ToList());

            return list;
        }

        

        private AphidObject InterpretUnaryOperatorExpression(UnaryOperatorExpression expression)
        {
            if (!expression.IsPostfix)
            {
                switch (expression.Operator)
                {
                    case AphidTokenType.AdditionOperator:
                        return (AphidObject)InterpretExpression(expression.Operand);

                    case AphidTokenType.MinusOperator:
                        var val = ValueHelper.Unwrap(InterpretExpression(expression.Operand));

                        if (!(val is decimal))
                        {
                            throw new AphidRuntimeException(
                                "Unary operator '-' expects number, {0} was provided instead.",
                                val.GetType());
                        }

                        return ValueHelper.Wrap((decimal)val * -1);

                    case AphidTokenType.retKeyword:
                        SetReturnValue(ValueHelper.Wrap(InterpretExpression(expression.Operand)));
                        _isReturning = true;
                        return null;

                    case AphidTokenType.deleteKeyword:
                        var operand = ((IdentifierExpression)expression.Operand).Identifier;
                        return new AphidObject(_currentScope.TryResolveAndRemove(operand));

                    case AphidTokenType.NotOperator:
                        return new AphidObject(!(bool)ValueHelper.Unwrap(InterpretExpression(expression.Operand) as AphidObject));

                    case AphidTokenType.IncrementOperator:
                        var obj = InterpretExpression(expression.Operand) as AphidObject;
                        obj.Value = ((decimal)obj.Value) + 1;
                        return obj;

                    case AphidTokenType.DecrementOperator:
                        obj = InterpretExpression(expression.Operand) as AphidObject;
                        obj.Value = ((decimal)obj.Value) - 1;
                        return obj;

                    case AphidTokenType.DistinctOperator:
                        obj = ((AphidObject)InterpretExpression(expression.Operand));
                        var list = obj.Value as List<AphidObject>;

                        if (list == null)
                        {
                            throw CreateUnaryOperatorException(expression);
                        }

                        return new AphidObject(list.Distinct(_comparer).ToList());

                    default:
                        throw CreateUnaryOperatorException(expression);
                }
            }
            else
            {
                switch (expression.Operator)
                {
                    case AphidTokenType.IncrementOperator:
                        var obj = InterpretExpression(expression.Operand) as AphidObject;
                        var v = obj.Value;
                        obj.Value = ((decimal)obj.Value) + 1;
                        return new AphidObject(v);

                    case AphidTokenType.DecrementOperator:
                        obj = InterpretExpression(expression.Operand) as AphidObject;
                        v = obj.Value;
                        obj.Value = ((decimal)obj.Value) - 1;
                        return new AphidObject(v);

                    case AphidTokenType.definedKeyword:
                        if (expression.Operand is IdentifierExpression)
                        {
                            return ValueHelper.Wrap(InterpretIdentifierExpression(expression.Operand as IdentifierExpression) != null);
                        }
                        else if (expression.Operand is BinaryOperatorExpression)
                        {
                            var objRef = InterpretBinaryOperatorExpression(expression.Operand as BinaryOperatorExpression, true) as AphidRef;
                            return new AphidObject(objRef.Object.ContainsKey(objRef.Name));
                        }
                        else
                        {
                            throw new AphidRuntimeException("Unknown ? operand");
                        }

                    
                    //var obj = InterpretExpression(

                    default:
                        throw CreateUnaryOperatorException(expression);
                }
            }
        }

        private AphidObject InterpretBooleanExpression(BooleanExpression expression)
        {
            return new AphidObject(expression.Value);
        }

        private AphidObject InterpretIfExpression(IfExpression expression)
        {
            if ((bool)ValueHelper.Unwrap(InterpretExpression(expression.Condition)))
            {
                InterpretChild(expression.Body);
            }
            else if (expression.ElseBody != null)
            {
                InterpretChild(expression.ElseBody);
            }
            return null;
        }

        private AphidObject InterpretNumberExpression(NumberExpression expression)
        {
            return new AphidObject(expression.Value);
        }

        private AphidObject InterpretArrayAccessExpression(ArrayAccessExpression expression)
        {
            var val = ValueHelper.Unwrap(InterpretExpression(expression.ArrayExpression));
            var index = Convert.ToInt32(ValueHelper.Unwrap(InterpretExpression(expression.KeyExpression)));
            var array = val as List<AphidObject>;
            string str;

            if (array != null)
            {
                if (index < 0 || index >= array.Count)
                {
                    throw new AphidRuntimeException("Index out of range: {0}.", index);
                }

                return array[index];
            }
            else if ((str = val as string) != null)
            {
                return new AphidObject(str[index].ToString());
            }
            else
            {
                throw new AphidRuntimeException("Array access not supported by {0}.", val);
            }
        }

        private AphidObject InterpretForExpression(ForExpression expression)
        {
            EnterChildScope();
            var init = InterpretExpression(expression.Initialization);

            while ((bool)(InterpretExpression(expression.Condition) as AphidObject).Value)
            {
                EnterChildScope();
                Interpret(expression.Body, false);
                InterpretExpression(expression.Afterthought);
                if (LeaveChildScope(true) || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            }

            LeaveChildScope(true);

            return null;
        }

        private AphidObject InterpretForEachExpression(ForEachExpression expression)
        {
            var collection = InterpretExpression(expression.Collection) as AphidObject;
            var elements = collection.Value as List<AphidObject>;
            var elementId = (expression.Element as IdentifierExpression).Identifier;

            foreach (var element in elements)
            {
                EnterChildScope();
                _currentScope.Add(elementId, element);
                Interpret(expression.Body, false);

                if (LeaveChildScope(true) || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            }

            return null;
        }

        private AphidObject InterpretLoadScriptExpression(LoadScriptExpression expression)
        {
            var file = ValueHelper.Unwrap(InterpretExpression(expression.FileExpression)) as string;

            if (file == null)
            {
                throw new AphidRuntimeException("Cannot load script {0}", expression.FileExpression);
            }

            _loader.LoadScript(file);

            return null;
        }

        private AphidObject InterpretLoadLibraryExpression(LoadLibraryExpression expression)
        {
            var library = ValueHelper.Unwrap(InterpretExpression(expression.LibraryExpression)) as string;

            if (library == null)
            {
                throw new AphidRuntimeException("Cannot load script {0}", expression.LibraryExpression);
            }

            _loader.LoadLibrary(library, _currentScope);

            return null;
        }

        private AphidObject InterpretBreakExpression()
        {
            _isBreaking = true;
            return null;
        }

        private AphidObject InterpretPartialFunctionExpression(PartialFunctionExpression expression)
        {
            var obj = (AphidObject)InterpretExpression(expression.Call.FunctionExpression);
            var func = (AphidFunction)obj.Value;
            var partialArgCount = func.Args.Length - expression.Call.Args.Count();
            var partialArgs = func.Args.Skip(partialArgCount).ToArray();
            var partialFunc = new AphidFunction()
            {
                Args = partialArgs,
                Body = new List<AphidExpression> 
                {
                    new UnaryOperatorExpression(AphidTokenType.retKeyword,
                        new CallExpression(
                            expression.Call.FunctionExpression, 
                            expression.Call.Args.Concat(
                            partialArgs.Select(x => new IdentifierExpression(x))).ToList())),
                },
                ParentScope = _currentScope,
            };

            return new AphidObject(partialFunc);
        }

        private AphidObject InterpretThisExpression()
        {
            return _currentScope;
        }

        private AphidObject InterpretPatternMatchingExpression(PatternMatchingExpression expression)
        {
            var left = (AphidObject)InterpretExpression(expression.TestExpression);

            foreach (var pattern in expression.Patterns)
            {
                if (pattern.Patterns != null && pattern.Patterns.Any())
                {
                    foreach (var patternTest in pattern.Patterns)
                    {
                        var right = (AphidObject)InterpretExpression(patternTest);

                        var b = left.Value != null ?
                            left.Value.Equals(right.Value) :
                            (null == right.Value && left.Count == 0 && right.Count == 0);

                        if (b)
                        {
                            return ValueHelper.Wrap(InterpretExpression(pattern.Value));
                        }
                    }
                }
                else
                {
                    return ValueHelper.Wrap(InterpretExpression(pattern.Value));
                }
            }

            return new AphidObject();
        }

        private void InterpretExtendExpression(ExtendExpression expression)
        {
            var obj = InterpretObjectExpression(expression.Object);
            TypeExtender.Extend(this, expression.ExtendType, obj);
        }

        private void InterpretWhileExpression(WhileExpression expression)
        {
            while ((bool)((AphidObject)(InterpretExpression(expression.Condition))).Value)
            {
                EnterChildScope();
                Interpret(expression.Body, false);

                if (LeaveChildScope(true) || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            }
        }

        private void InterpretDoWhileExpression(DoWhileExpression expression)
        {
            do
            {
                EnterChildScope();
                Interpret(expression.Body, false);

                if (LeaveChildScope(true) || _isBreaking)
                {
                    _isBreaking = false;
                    break;
                }
            } while ((bool)((AphidObject)(InterpretExpression(expression.Condition))).Value);
        }

        private void InterpretTryBlock(TryExpression expression)
        {
            EnterChildScope();
            Interpret(expression.TryBody, false);
            LeaveChildScope(true);
        }

        private void InterpretCatchBlock(TryExpression expression, Exception e)
        {
            LeaveChildScope(true);
            EnterChildScope();
            _currentScope.Add(
                expression.CatchArg.Identifier,
                new AphidObject(e.Message));
            Interpret(expression.CatchBody, false);
            LeaveChildScope(true);
        }

        private void InterpretFinallyBlock(TryExpression expression)
        {
            EnterChildScope();
            Interpret(expression.FinallyBody, false);
            LeaveChildScope(false);
        }

        private void InterpretTryExpression(TryExpression expression)
        {
            if (expression.FinallyBody == null)
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                catch (Exception e)
                {
                    InterpretCatchBlock(expression, e);
                }
            }
            else if (expression.CatchBody != null)
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                catch (Exception e)
                {
                    InterpretCatchBlock(expression, e);
                }
                finally
                {
                    InterpretFinallyBlock(expression);
                }
            }
            else
            {
                try
                {
                    InterpretTryBlock(expression);
                }
                finally
                {
                    InterpretFinallyBlock(expression);
                }
            }
        }

        private AphidObject InterpretTernaryOperatorExpression(TernaryOperatorExpression expression)
        {
            switch (expression.Operator)
            {
                case AphidTokenType.ConditionalOperator:
                    return (AphidObject)InterpretExpression(
                        (bool)((AphidObject)InterpretExpression(expression.FirstOperand)).Value ?
                        expression.SecondOperand :
                        expression.ThirdOperand);

                default:
                    throw new InvalidOperationException();
            }
        }

        private void InterpretSwitchExpression(SwitchExpression expression)
        {
            var exp = (AphidObject)InterpretExpression(expression.Expression);

            foreach (var c in expression.Cases)
            {
                foreach (var c2 in c.Cases)
                {
                    var caseValue = (AphidObject)InterpretExpression(c2);
                    
                    if (!exp.Value.Equals(caseValue.Value))
                    {
                        continue;
                    }

                    EnterChildScope();
                    Interpret(c.Body, resetIsReturning: false);
                    LeaveChildScope(bubbleReturnValue: true);

                    return;
                }
            }

            if (expression.DefaultCase != null)
            {
                EnterChildScope();
                Interpret(expression.DefaultCase, resetIsReturning: false);
                LeaveChildScope(bubbleReturnValue: true);
            }
        }

        public object InterpretExpression(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.BinaryOperatorExpression:
                    return InterpretBinaryOperatorExpression((BinaryOperatorExpression)expression);

                case AphidExpressionType.ObjectExpression:
                    return InterpretObjectExpression((ObjectExpression)expression);

                case AphidExpressionType.StringExpression:
                    return InterpretStringExpression((StringExpression)expression);

                case AphidExpressionType.NumberExpression:
                    return InterpretNumberExpression((NumberExpression)expression);

                case AphidExpressionType.CallExpression:
                    return InterpretCallExpression((CallExpression)expression);

                case AphidExpressionType.IdentifierExpression:
                    return InterpretIdentifierExpression((IdentifierExpression)expression);

                case AphidExpressionType.FunctionExpression:
                    return InterpretFunctionExpression((FunctionExpression)expression);

                case AphidExpressionType.ArrayExpression:
                    return InterpretArrayExpression((ArrayExpression)expression);

                case AphidExpressionType.UnaryOperatorExpression:
                    return InterpretUnaryOperatorExpression((UnaryOperatorExpression)expression);

                case AphidExpressionType.BooleanExpression:
                    return InterpretBooleanExpression((BooleanExpression)expression);

                case AphidExpressionType.IfExpression:
                    return InterpretIfExpression((IfExpression)expression);

                case AphidExpressionType.ArrayAccessExpression:
                    return InterpretArrayAccessExpression((ArrayAccessExpression)expression);

                case AphidExpressionType.ForEachExpression:
                    return InterpretForEachExpression((ForEachExpression)expression);

                case AphidExpressionType.ForExpression:
                    return InterpretForExpression((ForExpression)expression);

                case AphidExpressionType.LoadScriptExpression:
                    return InterpretLoadScriptExpression((LoadScriptExpression)expression);

                case AphidExpressionType.LoadLibraryExpression:
                    return InterpretLoadLibraryExpression((LoadLibraryExpression)expression);

                case AphidExpressionType.NullExpression:
                    return new AphidObject(null);

                case AphidExpressionType.BreakExpression:
                    return InterpretBreakExpression();

                case AphidExpressionType.PartialFunctionExpression:
                    return InterpretPartialFunctionExpression((PartialFunctionExpression)expression);

                case AphidExpressionType.ThisExpression:
                    return InterpretThisExpression();

                case AphidExpressionType.PatternMatchingExpression:
                    return InterpretPatternMatchingExpression((PatternMatchingExpression)expression);

                case AphidExpressionType.ExtendExpression:
                    InterpretExtendExpression((ExtendExpression)expression);

                    return null;

                case AphidExpressionType.WhileExpression:
                    InterpretWhileExpression((WhileExpression)expression);

                    return null;

                case AphidExpressionType.DoWhileExpression:
                    InterpretDoWhileExpression((DoWhileExpression)expression);

                    return null;

                case AphidExpressionType.TryExpression:
                    InterpretTryExpression((TryExpression)expression);

                    return null;

                case AphidExpressionType.TernaryOperatorExpression:
                    return InterpretTernaryOperatorExpression((TernaryOperatorExpression)expression);

                case AphidExpressionType.SwitchExpression:
                    InterpretSwitchExpression((SwitchExpression)expression);

                    return null;

                default:
                    throw new AphidRuntimeException("Unexpected expression {0}", expression);
            }
        }

        public void Interpret(List<AphidExpression> expressions, bool resetIsReturning = true)
        {
            foreach (var expression in expressions)
            {
                if (expression is IdentifierExpression)
                {
                    _currentScope.Add((expression as IdentifierExpression).Identifier, new AphidObject());
                }
                else
                {
                    InterpretExpression(expression);
                }

                if (_isBreaking)
                {
                    break;
                }
                else if (_isReturning)
                {
                    if (resetIsReturning)
                    {
                        _isReturning = false;
                    }

                    break;
                }
            }
        }

        public void Interpret(string code)
        {
            var lexer = new AphidLexer(code);
            var parser = new AphidParser(lexer.GetTokens());
            var ast = parser.Parse();
            Interpret(ast);
        }

        public void InterpretFile(string filename)
        {
            _loader.LoadScript(filename);            
        }
    }
}
