using Components.Aphid.Parser;
using System;
using System.Diagnostics;

namespace Components.Aphid.Compiler
{
    public abstract partial class AphidStringEmitter
    {
        [DebuggerStepThrough]
        protected void Emit(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.ArrayAccessExpression: EmitArrayAccessExpression((ArrayAccessExpression)expression); break;
                case AphidExpressionType.ArrayExpression: EmitArrayExpression((ArrayExpression)expression); break;
                case AphidExpressionType.BinaryOperatorExpression: EmitBinaryOperatorExpression((BinaryOperatorExpression)expression); break;
                case AphidExpressionType.BooleanExpression: EmitBooleanExpression((BooleanExpression)expression); break;
                case AphidExpressionType.BreakExpression: EmitBreakExpression((BreakExpression)expression); break;
                case AphidExpressionType.CallExpression: EmitCallExpression((CallExpression)expression); break;
                case AphidExpressionType.DoWhileExpression: EmitDoWhileExpression((DoWhileExpression)expression); break;
                case AphidExpressionType.DynamicMemberExpression: EmitDynamicMemberExpression((DynamicMemberExpression)expression); break;
                case AphidExpressionType.ExtendExpression: EmitExtendExpression((ExtendExpression)expression); break;
                case AphidExpressionType.ForEachExpression: EmitForEachExpression((ForEachExpression)expression); break;
                case AphidExpressionType.ForExpression: EmitForExpression((ForExpression)expression); break;
                case AphidExpressionType.FunctionExpression: EmitFunctionExpression((FunctionExpression)expression); break;
                case AphidExpressionType.GatorEmitExpression: EmitGatorEmitExpression((GatorEmitExpression)expression); break;
                case AphidExpressionType.IdentifierExpression: EmitIdentifierExpression((IdentifierExpression)expression); break;
                case AphidExpressionType.IfExpression: EmitIfExpression((IfExpression)expression); break;
                case AphidExpressionType.LoadLibraryExpression: EmitLoadLibraryExpression((LoadLibraryExpression)expression); break;
                case AphidExpressionType.LoadScriptExpression: EmitLoadScriptExpression((LoadScriptExpression)expression); break;
                case AphidExpressionType.NullExpression: EmitNullExpression((NullExpression)expression); break;
                case AphidExpressionType.NumberExpression: EmitNumberExpression((NumberExpression)expression); break;
                case AphidExpressionType.ObjectExpression: EmitObjectExpression((ObjectExpression)expression); break;
                case AphidExpressionType.PartialFunctionExpression: EmitPartialFunctionExpression((PartialFunctionExpression)expression); break;
                case AphidExpressionType.PatternExpression: EmitPatternExpression((PatternExpression)expression); break;
                case AphidExpressionType.PatternMatchingExpression: EmitPatternMatchingExpression((PatternMatchingExpression)expression); break;
                case AphidExpressionType.UnaryOperatorExpression: EmitUnaryOperatorExpression((UnaryOperatorExpression)expression); break;
                case AphidExpressionType.StringExpression: EmitStringExpression((StringExpression)expression); break;
                case AphidExpressionType.SwitchCase: EmitSwitchCase((SwitchCase)expression); break;
                case AphidExpressionType.SwitchExpression: EmitSwitchExpression((SwitchExpression)expression); break;
                case AphidExpressionType.TernaryOperatorExpression: EmitTernaryOperatorExpression((TernaryOperatorExpression)expression); break;
                case AphidExpressionType.TextExpression: EmitTextExpression((TextExpression)expression); break;
                case AphidExpressionType.ThisExpression: EmitThisExpression((ThisExpression)expression); break;
                case AphidExpressionType.TryExpression: EmitTryExpression((TryExpression)expression); break;
                case AphidExpressionType.WhileExpression: EmitWhileExpression((WhileExpression)expression); break;
                default:
                    throw new NotImplementedException();
            }
        }

        [DebuggerStepThrough] protected virtual void EmitArrayAccessExpression(ArrayAccessExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitArrayExpression(ArrayExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitBinaryOperatorExpression(BinaryOperatorExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitBooleanExpression(BooleanExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitBreakExpression(BreakExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitCallExpression(CallExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitDoWhileExpression(DoWhileExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitDynamicMemberExpression(DynamicMemberExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitExtendExpression(ExtendExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitForEachExpression(ForEachExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitForExpression(ForExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitFunctionExpression(FunctionExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitGatorEmitExpression(GatorEmitExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitIdentifierExpression(IdentifierExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitIfExpression(IfExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitLoadLibraryExpression(LoadLibraryExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitLoadScriptExpression(LoadScriptExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitNullExpression(NullExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitNumberExpression(NumberExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitObjectExpression(ObjectExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPartialFunctionExpression(PartialFunctionExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPatternExpression(PatternExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPatternMatchingExpression(PatternMatchingExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitUnaryOperatorExpression(UnaryOperatorExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitStringExpression(StringExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitSwitchCase(SwitchCase expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitSwitchExpression(SwitchExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTernaryOperatorExpression(TernaryOperatorExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTextExpression(TextExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitThisExpression(ThisExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTryExpression(TryExpression expression) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitWhileExpression(WhileExpression expression) { throw new NotImplementedException(); }

        protected virtual void BeginStatement() { }

        protected virtual void EndStatement() { }
    }
}
