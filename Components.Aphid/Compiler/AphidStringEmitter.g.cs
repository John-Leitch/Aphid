using Components.Aphid.Parser;
using System;
using System.Diagnostics;

namespace Components.Aphid.Compiler
{
    public abstract partial class AphidStringEmitter
    {
#if DBG_STEPTHROUGH
        [DebuggerStepThrough]
#endif
       protected virtual void Emit(AphidExpression expression, bool isStatement = false)
        {
            BeginExpression(expression);
            switch (expression.Type)
            {
                case AphidExpressionType.ArrayAccessExpression: EmitArrayAccessExpression((ArrayAccessExpression)expression, isStatement); break;
                case AphidExpressionType.ArrayExpression: EmitArrayExpression((ArrayExpression)expression, isStatement); break;
                case AphidExpressionType.BinaryOperatorExpression: EmitBinaryOperatorExpression((BinaryOperatorExpression)expression, isStatement); break;
                case AphidExpressionType.BooleanExpression: EmitBooleanExpression((BooleanExpression)expression, isStatement); break;
                case AphidExpressionType.BreakExpression: EmitBreakExpression((BreakExpression)expression, isStatement); break;
                case AphidExpressionType.CallExpression: EmitCallExpression((CallExpression)expression, isStatement); break;
                case AphidExpressionType.DoWhileExpression: EmitDoWhileExpression((DoWhileExpression)expression, isStatement); break;
                case AphidExpressionType.DynamicMemberExpression: EmitDynamicMemberExpression((DynamicMemberExpression)expression, isStatement); break;
                case AphidExpressionType.ExtendExpression: EmitExtendExpression((ExtendExpression)expression, isStatement); break;
                case AphidExpressionType.ForEachExpression: EmitForEachExpression((ForEachExpression)expression, isStatement); break;
                case AphidExpressionType.ForExpression: EmitForExpression((ForExpression)expression, isStatement); break;
                case AphidExpressionType.FunctionExpression: EmitFunctionExpression((FunctionExpression)expression, isStatement); break;
                case AphidExpressionType.GatorCloseExpression: EmitGatorCloseExpression((GatorCloseExpression)expression, isStatement); break;
                case AphidExpressionType.GatorEmitExpression: EmitGatorEmitExpression((GatorEmitExpression)expression, isStatement); break;
                case AphidExpressionType.GatorOpenExpression: EmitGatorOpenExpression((GatorOpenExpression)expression, isStatement); break;
                case AphidExpressionType.IdentifierExpression: EmitIdentifierExpression((IdentifierExpression)expression, isStatement); break;
                case AphidExpressionType.IfExpression: EmitIfExpression((IfExpression)expression, isStatement); break;
                case AphidExpressionType.LoadLibraryExpression: EmitLoadLibraryExpression((LoadLibraryExpression)expression, isStatement); break;
                case AphidExpressionType.LoadScriptExpression: EmitLoadScriptExpression((LoadScriptExpression)expression, isStatement); break;
                case AphidExpressionType.NullExpression: EmitNullExpression((NullExpression)expression, isStatement); break;
                case AphidExpressionType.NumberExpression: EmitNumberExpression((NumberExpression)expression, isStatement); break;
                case AphidExpressionType.ObjectExpression: EmitObjectExpression((ObjectExpression)expression, isStatement); break;
                case AphidExpressionType.PartialFunctionExpression: EmitPartialFunctionExpression((PartialFunctionExpression)expression, isStatement); break;
                case AphidExpressionType.PatternExpression: EmitPatternExpression((PatternExpression)expression, isStatement); break;
                case AphidExpressionType.PatternMatchingExpression: EmitPatternMatchingExpression((PatternMatchingExpression)expression, isStatement); break;
                case AphidExpressionType.UnaryOperatorExpression: EmitUnaryOperatorExpression((UnaryOperatorExpression)expression, isStatement); break;
                case AphidExpressionType.StringExpression: EmitStringExpression((StringExpression)expression, isStatement); break;
                case AphidExpressionType.SwitchCase: EmitSwitchCase((SwitchCase)expression, isStatement); break;
                case AphidExpressionType.SwitchExpression: EmitSwitchExpression((SwitchExpression)expression, isStatement); break;
                case AphidExpressionType.TernaryOperatorExpression: EmitTernaryOperatorExpression((TernaryOperatorExpression)expression, isStatement); break;
                case AphidExpressionType.TextExpression: EmitTextExpression((TextExpression)expression, isStatement); break;
                case AphidExpressionType.ThisExpression: EmitThisExpression((ThisExpression)expression, isStatement); break;
                case AphidExpressionType.TryExpression: EmitTryExpression((TryExpression)expression, isStatement); break;
                case AphidExpressionType.WhileExpression: EmitWhileExpression((WhileExpression)expression, isStatement); break;
                default:
                    throw new NotImplementedException();
            }
            EndExpression(expression);
        }

        [DebuggerStepThrough] protected virtual void EmitBreakExpression(BreakExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitDoWhileExpression(DoWhileExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitDynamicMemberExpression(DynamicMemberExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitExtendExpression(ExtendExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitForEachExpression(ForEachExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitForExpression(ForExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitFunctionExpression(FunctionExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitGatorCloseExpression(GatorCloseExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitGatorEmitExpression(GatorEmitExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitGatorOpenExpression(GatorOpenExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitIdentifierExpression(IdentifierExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitIfExpression(IfExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitLoadLibraryExpression(LoadLibraryExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitLoadScriptExpression(LoadScriptExpression expression, bool isStatement = false) { throw new NotImplementedException(); }        
        [DebuggerStepThrough] protected virtual void EmitObjectExpression(ObjectExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPartialFunctionExpression(PartialFunctionExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPatternExpression(PatternExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitPatternMatchingExpression(PatternMatchingExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitSwitchCase(SwitchCase expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitSwitchExpression(SwitchExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTernaryOperatorExpression(TernaryOperatorExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTextExpression(TextExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitThisExpression(ThisExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitTryExpression(TryExpression expression, bool isStatement = false) { throw new NotImplementedException(); }
        [DebuggerStepThrough] protected virtual void EmitWhileExpression(WhileExpression expression, bool isStatement = false) { throw new NotImplementedException(); }

        protected virtual void BeginStatement(AphidExpression expression) { }

        protected virtual void EndStatement(AphidExpression expression) { }
    }
}
