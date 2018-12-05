using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Components
{
    public static class EnumerableMember
    {
        public static EnumerableMember<TSource, TMember> Create<TSource, TMember>(
            IEnumerable<TSource> source,
            Func<TSource, TMember> selector) =>
                new EnumerableMember<TSource, TMember>(source, selector);
    }

    public class EnumerableMember<TSource, TMember> : IEnumerable<TSource>, IEnumerator<TSource>
    {
        private int _state = 0;
        private IEnumerable<TSource> _source;
        private IEnumerator<TSource> _enumerator;
        private Func<TSource, TMember> _selector;
        private EqualityComparer<TMember> _comparer = EqualityComparer<TMember>.Default;

        public TSource Current { get; private set; }
        object IEnumerator.Current => Current;

        public EnumerableMember(IEnumerable<TSource> source, Func<TSource, TMember> childSelector)
        {
            _source = source;
            _selector = childSelector;
        }

        private bool Equals(TMember lhs, TMember rhs) => _comparer.Equals(lhs, rhs);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Is
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public EnumerableMember<TSource, TMemberType> Is<TMemberType>()
            where TMemberType : TMember =>
                EnumerableMember.Create(
                    _source.Where(x => _selector(x) is TMemberType),
                    x => (TMemberType)_selector(x));

        public EnumerableMember<TSource, TMember> Is(TMember value) =>
            EnumerableMember.Create(_source.Where(x => Equals(value, _selector(x))), _selector);

        public EnumerableMember<TSource, TMember> Is<TMemberValue>(TMemberValue value)
            where TMemberValue : IEquatable<TMemberValue>, TMember =>
                EnumerableMember.Create(_source.Where(x => Equals(value, _selector(x))), _selector);

        public EnumerableMember<TSource, TMember> Is(Func<TMember, bool> predicate) =>
            EnumerableMember.Create(_source.Where(x => predicate(_selector(x))), _selector);

        //public EnumerableMember<TSource, TMember> Is<TMemberValue>(Func<TMemberValue, bool> predicate)
        //    where TMemberValue : IEquatable<TMemberValue>, TMember =>
        //        EnumerableMember.Create(_source.Where(x => predicate(_selector(x))), _selector);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Not
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public EnumerableMember<TSource, TMember> Not<TMemberType>()
            where TMemberType : TMember =>
                EnumerableMember.Create(_source.Where(x => !(_selector(x) is TMemberType)), _selector);

        public EnumerableMember<TSource, TMember> Not(TMember value) =>
            EnumerableMember.Create(_source.Where(x => !Equals(value, _selector(x))), _selector);

        public EnumerableMember<TSource, TMember> Not<TMemberValue>(TMemberValue value)
            where TMemberValue : IEquatable<TMemberValue>, TMember =>
                EnumerableMember.Create(_source.Where(x => !Equals(value, _selector(x))), _selector);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // And
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public EnumerableMember<TSource, TNextMember> And<TNextMember>(Func<TMember, TNextMember> selector) =>
            EnumerableMember.Create(_source, x => selector(_selector(x)));

        public IEnumerator<TSource> GetEnumerator() => _source.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_source).GetEnumerator();

        ////////////////////////////////////////////////////////////////////////////////////////////////
        // Todo:
        // Contains
        // Any
        // StartsWith
        // EndsWith
        // In
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public void Dispose()
        {
            if (_enumerator != null)
            {
                _enumerator.Dispose();
                _enumerator = null;
            }
        }

        public bool MoveNext()
        {
            if (_state == 0)
            {
                _enumerator = GetEnumerator();
                _state = 1;
            }

            if (_enumerator.MoveNext())
            {
                Current = _enumerator.Current;

                return true;
            }
            else
            {
                Dispose();

                return false;
            }
        }

        public void Reset() => _state = 0;
    }
}
