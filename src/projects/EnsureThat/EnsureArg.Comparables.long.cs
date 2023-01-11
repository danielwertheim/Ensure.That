using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static long Is(long value, long expected, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.Is(value, expected, paramName);

        public static long IsNot(long value, long expected, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static long IsLt(long value, long limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static long IsLte(long value, long limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static long IsGt(long value, long limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static long IsGte(long value, long limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static long IsInRange(long value, long min, long max, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
