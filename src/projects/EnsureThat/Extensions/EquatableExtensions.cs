using System;

namespace EnsureThat.Extensions
{
    internal static class EquatableExtensions
    {
        internal static bool IsEq<T>(this IEquatable<T> x, T y) => x.Equals(y);
    }
}