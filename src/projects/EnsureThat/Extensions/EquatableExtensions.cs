using System;
using System.Collections.Generic;

namespace EnsureThat.Extensions
{
    internal static class EquatableExtensions
    {
        internal static bool IsEq<T>(this IEquatable<T> x, T y) => x.Equals(y);

        internal static bool IsEq<T>(this T x, T y, IEqualityComparer<T> equalityComparer) => equalityComparer.Equals(x, y);
    }
}