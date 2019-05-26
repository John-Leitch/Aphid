
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using static Components.Aphid.TypeSystem.ValueHelper;

namespace Components.Aphid.Wpf
{
    [ContentProperty("Expression")]
    [ValueConversion(typeof(object), typeof(object), ParameterType = typeof(object))]
    public class Aphid : MarkupExtension, IValueConverter, IMultiValueConverter
    {
        [ThreadStatic]
        public static AphidInterpreter Interpreter;

        private Lazy<AphidExpression> _expression;

        public Binding AssociatedBinding { get; set; }

        public bool Init { get; set; }

        public string EventName { get; set; }

        [ConstructorArgument("expression")]
        public string Expression { get; set; }

        public Aphid() => _expression = new Lazy<AphidExpression>(Parse);

        public Aphid(string expression)
            : this() => Expression = expression;

        public Aphid(AphidExpression node) =>
            _expression = new Lazy<AphidExpression>(() => node);

        private void InitAphid(string code = null)
        {
            Interpreter = new AphidInterpreter();

            if (code != null)
            {
                Interpreter.Interpret(AphidParser.Parse(code));
            }
        }

        private void EnsureInit()
        {
            if (Interpreter == null)
            {
                InitAphid();
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var target = serviceProvider.GetService<IProvideValueTarget>();
            var to = target.TargetObject;

            if (EventName != null)
            {
                if (to.GetType().Name == "SharedDp")
                {
                    return this;
                }

                AddEventHandler(to);

                return this;
            }

            switch (target.TargetProperty)
            {
                case DependencyProperty property:
                    return InterpretAndConvert(property.PropertyType);

                case EventInfo eventInfo:
                    return GetType()
                        .GetMethod("ExecHandler")
                        .MakeGenericMethod(
                            eventInfo
                                .EventHandlerType
                                .GetMethod("Invoke")
                                .GetParameters()[1]
                                .ParameterType)
                        .CreateDelegate(eventInfo.EventHandlerType, this);

                case PropertyInfo propertyInfo:
                    return propertyInfo.PropertyType == typeof(IValueConverter) &&
                        ((to is Binding) || (to is System.Windows.Data.Binding)) ?
                        this :
                        InterpretAndConvert(propertyInfo.PropertyType);

                case MethodInfo m:
                    return m.Name == nameof(Components.Aphid.Wpf.Event.SetHandler) ?
                        this :
                        throw new InvalidOperationException("Invalid Aphid extension ProvideValue call for MethodInfo.");

                case null:
                    return to is ResourceDictionary ?
                        this :
                        throw new InvalidOperationException("Invalid Aphid extension ProvideValue call.");

                default:
                    throw new NotImplementedException();
            }
        }

        private void AddEventHandler(object target) =>
            AddEventHandler(target, target.GetType().GetEvent(EventName));

        private void AddEventHandler(object target, EventInfo eventInfo) =>
            eventInfo.AddEventHandler(target, CreateEventHandler(eventInfo.EventHandlerType));

        private Delegate CreateEventHandler(Type eventHandlerType) =>
            GetType()
                .GetMethod("ExecHandler")
                .MakeGenericMethod(eventHandlerType
                    .GetMethod("Invoke")
                    .GetParameters()[1]
                    .ParameterType)
                .CreateDelegate(eventHandlerType, this);

        public void ExecHandler<TEventArgs>(object o, TEventArgs e)
        {
            void setVars()
            {
                Interpreter.CurrentScope.Add("sender", Wrap(o));
                Interpreter.CurrentScope.Add("args", Wrap(e));
            }

            if (Init)
            {
                Interpreter = new AphidInterpreter();
                setVars();
                Interpreter.CurrentScope.Add("root", Interpreter.CurrentScope);
                var exp = _expression.Value;

                if (exp.Type != AphidExpressionType.FunctionExpression)
                {
                    Interpreter.Interpret(exp);
                }
                else
                {
                    var func = (FunctionExpression)exp;

                    if (func.Args.Count != 0)
                    {
                        throw new NotSupportedException("Init function arguments not yet supported.");
                    }

                    Interpreter.Interpret(func.Body);
                }
            }
            else
            {
                EnsureInit();
                Interpreter.EnterScope();

                try
                {
                    setVars();
                    Interpreter.Interpret(_expression.Value);
                }
                finally
                {
                    Interpreter.LeaveScope(false);
                }
            }
        }

        private AphidExpression Parse() => AphidAttributeParser.Parse(Expression);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            Convert(new[] { value }, targetType, parameter, culture);

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            void add(string name, object obj) => Interpreter.CurrentScope.Add(name, Wrap(obj));

            if (parameter == null)
            {
                throw new ArgumentNullException("parameter");
            }

            EnsureInit();

            if (!(parameter is AphidExpression exp))
            {
                exp = AphidAttributeParser.Parse(parameter.ToString());
            }

            Interpreter.EnterScope();
            var id = 'x';

            try
            {
                foreach (var v in values)
                {
                    add(id++.ToString(), v);
                }

                add(nameof(targetType), targetType);
                add(nameof(culture), culture);

                Interpreter.Interpret(
                    new BinaryOperatorExpression(
                        new IdentifierExpression("_result",
                            new List<IdentifierExpression> { new IdentifierExpression("var") }),
                        AphidTokenType.AssignmentOperator,
                        exp));

                return AphidExtensionTypeConverter.Interpret(Interpreter, targetType);
            }
            finally
            {
                Interpreter.LeaveScope(false);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            parameter != null ?
                Convert(value, targetType, parameter, culture) :
                throw new ArgumentNullException("parameter");

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) =>
            new[] { value };

        public object InterpretAndConvert(Type targetType)
        {
            EnsureInit();
            Interpreter.EnterScope();

            try
            {
                var obj = Interpreter.Interpret(_expression.Value);
                var result = Unwrap(obj);

                if (targetType == typeof(Uri) && result is string resultStr)
                {
                    return new Uri(resultStr);
                }

                return System.Convert.ChangeType(result, targetType);
            }
            finally
            {
                Interpreter.LeaveScope(false);
            }
        }
    }
}
