using System;
using System.Collections.Generic;

namespace EnsureThat.Enforcers
{
    internal class DummyComparableArg : IComparableArg
    {
        public T Is<T>(T value, T expected, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T Is<T>(T value, T expected, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsNot<T>(T value, T expected, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsNot<T>(T value, T expected, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsLt<T>(T value, T limit, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsLt<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsLte<T>(T value, T limit, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsLte<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsGt<T>(T value, T limit, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsGt<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsGte<T>(T value, T limit, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsGte<T>(T value, T limit, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T IsInRange<T>(T value, T min, T max, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>
            => value;

        public T IsInRange<T>(T value, T min, T max, IComparer<T> comparer, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}