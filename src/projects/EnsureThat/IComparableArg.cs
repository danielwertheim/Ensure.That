using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IComparableArg
    {
        T Is<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T Is<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsNot<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsNot<T>(T value, T expected, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsLt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsLt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsLte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsLte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsGt<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsGt<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsGte<T>([NotNull] T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsGte<T>(T value, T limit, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsInRange<T>([NotNull] T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : IComparable<T>;
        T IsInRange<T>(T value, T min, T max, [NotNull] IComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
    }
}