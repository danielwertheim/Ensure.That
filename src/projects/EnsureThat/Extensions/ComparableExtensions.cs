using System;
using JetBrains.Annotations;

namespace EnsureThat.Extensions
{
    internal static class ComparableExtensions
    {
        internal static bool IsLt<T>(this IComparable<T> x, T y) => x.CompareTo(y) < 0;

        internal static bool IsEq<T>(this IComparable<T> x, T y) => x.CompareTo(y) == 0;

        internal static bool IsGt<T>(this IComparable<T> x, T y) => x.CompareTo(y) > 0;
    }
}