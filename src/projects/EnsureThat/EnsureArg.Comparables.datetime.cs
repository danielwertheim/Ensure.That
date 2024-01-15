using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static DateTime Is(DateTime value, DateTime expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.Is(value, expected, paramName);

        public static DateTime IsNot(DateTime value, DateTime expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static DateTime IsLt(DateTime value, DateTime limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static DateTime IsLte(DateTime value, DateTime limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static DateTime IsGt(DateTime value, DateTime limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static DateTime IsGte(DateTime value, DateTime limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static DateTime IsInRange(DateTime value, DateTime min, DateTime max, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
