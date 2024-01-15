using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static decimal Is(decimal value, decimal expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.Is(value, expected, paramName);

        public static decimal IsNot(decimal value, decimal expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static decimal IsLt(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static decimal IsLte(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static decimal IsGt(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static decimal IsGte(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static decimal IsInRange(decimal value, decimal min, decimal max, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
