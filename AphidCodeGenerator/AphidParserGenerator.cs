using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace AphidCodeGenerator
{
    public class AphidParserGenerator : IAphidCodeObject
    {
        public string CodeFile { get { return @"Parser\AphidParser.g.cs"; } }

        private static CodeExpression CreateParseOperand(AphidBinaryOperatorExpressionRule rule)
        {
            return CodeHelper.This().InvokeMethod("Parse" + rule.Operand);
        }

        private static CodeMemberMethod CreateBinOpParseFunction(AphidBinaryOperatorExpressionRule rule)
        {
            var parseOperand = CreateParseOperand(rule);
            var operandRef = CodeHelper.VarRef("operand");
            var operandVar = CodeHelper.VarDecl(typeof(AphidExpression), "operand", parseOperand);
            var curTokenTypeRef = CodeHelper.PropRef("_currentToken").GetProperty("TokenType");
            var tokenTypeRef = CodeHelper.TypeRefExp<AphidTokenType>();
            var operatorRef = CodeHelper.VarRef("op");
            var operatorVar = CodeHelper.VarDecl(typeof(AphidTokenType), "op", curTokenTypeRef);
            var nextToken = CodeHelper.This().InvokeMethod("NextToken");

            var condition = rule.Operators
                .Select(x => tokenTypeRef.GetProperty(x))
                .Select(x => CodeHelper.BinOpExp(curTokenTypeRef, CodeBinaryOperatorType.ValueEquality, x))
                .BinOpExpJoin(CodeBinaryOperatorType.BooleanOr);

            var assignStmt = CodeHelper.Assign(
                operandRef,
                CodeHelper.New(
                    typeof(BinaryOperatorExpression),
                    operandRef,
                    operatorRef,
                    parseOperand));

            var whileStmt = CodeHelper.While(condition);
            whileStmt.Statements.Add(operatorVar);
            whileStmt.Statements.Add(nextToken);
            whileStmt.Statements.Add(assignStmt);

            var method = new CodeMemberMethod()
            {
                ReturnType = CodeHelper.TypeRef<AphidExpression>(),
                Name = "Parse" + rule.Name,
            };

            method.Statements.Add(operandVar);
            method.Statements.Add(whileStmt);
            method.Statements.Add(CodeHelper.Return(operandRef));

            return method;
        }

        private static CodeTypeDeclaration CreateParserType(IEnumerable<CodeMemberMethod> methods)
        {
            var typeDecl = new CodeTypeDeclaration("AphidParser")
            {
                IsPartial = true,
                Attributes = MemberAttributes.Public,
            };

            foreach (var t in methods)
            {
                typeDecl.Members.Add(t);
            }

            return typeDecl;
        }

        public CodeObject CreateCodeObject()
        {
            var interpreter = new AphidInterpreter();
            interpreter.InterpretFile("ParserRules.alx");
            var methods = interpreter
                .GetReturnValue()
                .ConvertTo<AphidParserRules>().BinaryOperatorExpressions
                .Select(CreateBinOpParseFunction)
                .ToArray();

            var t = CreateParserType(methods);

            var ns = new CodeNamespace("Components.Aphid.Parser");
            ns.Types.Add(t);
            
            return ns;
        }
    }
}
