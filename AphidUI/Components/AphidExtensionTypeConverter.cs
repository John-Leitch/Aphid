using Components;
using Components.Aphid;
using static Components.Aphid.Lexer.AphidTokenType;
using Components.Aphid.Parser;
using Exp = Components.Aphid.Parser.AphidExpressionType;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Interpreter;
using Components.External;

namespace Components.Aphid.Wpf
{
    public static class AphidExtensionTypeConverter
    {
        private static readonly Memoizer<Type, AphidObject> _memoizer = new Memoizer<Type, AphidObject>();

        public static object Interpret(AphidInterpreter interpreter, Type targetType)
        {
            interpreter.Interpret(
                AphidParser.ParseExpression(
                    $"using {targetType.FullName.RemoveAtLastIndexOf('.')}"));

            var converterName = $"{targetType.Name}Converter";
            var converterRef = new IdentifierExpression(converterName);

            _memoizer.Call(
                x =>
                {
                    var prop = new IdentifierExpression(
                        "Value",
                        new List<IdentifierExpression>
                        {
                            new IdentifierExpression(targetType.Name)
                        });

                    return interpreter.Interpret(
                        new ObjectExpression(
                            new List<BinaryOperatorExpression>
                            {
                                new BinaryOperatorExpression(prop, ColonOperator, prop),
                            },
                            new IdentifierExpression(
                                converterName,
                                new List<IdentifierExpression> { new IdentifierExpression("class") })));
                },
                targetType);

            var resultId = new IdentifierExpression("_result");

            var converterVarName = $"{targetType.Name}ConverterInstance";
            var converterVarId = new IdentifierExpression(converterVarName);

            var valuePath = new BinaryOperatorExpression(
                converterVarId,
                MemberOperator,
                new IdentifierExpression("Value"));

            var ast = new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    new IdentifierExpression(
                        converterVarName,
                        new List<IdentifierExpression> { new IdentifierExpression("var") }),
                    AssignmentOperator,
                    new UnaryOperatorExpression(
                        newKeyword,
                        new CallExpression(converterRef))),
                new BinaryOperatorExpression(valuePath, @operator: AssignmentOperator, resultId),
                new UnaryOperatorExpression(retKeyword, valuePath),
            };

            interpreter.Interpret(ast);
            var retObj = interpreter.GetReturnValue();
            var retVal = ValueHelper.Unwrap(retObj);

            return retVal;
        }
    }
}
