using System;

namespace Components
{
    public class IfContext<TInput, TResult>
    {
        private readonly TInput _input;
        private readonly bool _condition;
        private readonly Func<TInput, bool> _conditionFunc;
        private readonly Func<TInput, TResult> _ifResultFunc;

        internal IfContext(
            TInput input,
            bool condition,
            Func<TInput, TResult> resultFunc)
        {
            _input = input;
            _condition = condition;
            _ifResultFunc = resultFunc;
        }

        internal IfContext(
            TInput input,
            Func<TInput, bool> conditionFunc,
            Func<TInput, TResult> resultFunc)
        {
            _input = input;
            _conditionFunc = conditionFunc;
            _ifResultFunc = resultFunc;
        }

        public TInput Else(Action<TInput> action)
        {
            if (_conditionFunc == null)
            {
                if (_condition)
                {
                    _ifResultFunc(_input);
                }
                else
                {
                    action(_input);
                }
            }
            else
            {
                if (_conditionFunc(_input))
                {
                    _ifResultFunc(_input);
                }
                else
                {
                    action(_input);
                }
            }

            return _input;
        }

        public TResult Else(Func<TInput, TResult> func) => _conditionFunc == null
                ? _condition ? _ifResultFunc(_input) : func(_input)
                : _conditionFunc(_input) ? _ifResultFunc(_input) : func(_input);
    }
}
