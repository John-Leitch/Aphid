using System;

namespace Components
{
    public class IfContext<TInput, TResult>
    {
        private TInput _input;

        bool _condition;

        Func<TInput, TResult> _ifResultFunc;

        internal IfContext(
            TInput input,
            bool condition,
            Func<TInput, TResult> resultFunc)
        {
            _input = input;
            _condition = condition;
            _ifResultFunc = resultFunc;
        }

        public TInput Else(Action<TInput> action)
        {
            if (_condition)
            {
                _ifResultFunc(_input);
            }
            else
            {
                action(_input);
            }

            return _input;
        }


        public TResult Else(Func<TInput, TResult> func)
        {
            if (_condition)
            {
                return _ifResultFunc(_input);
            }
            else
            {
                return func(_input);
            }
        }
    }
}
