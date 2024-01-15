using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static double Is(double value, double expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.Is(value, expected, paramName);

        public static double IsNot(double value, double expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static double IsLt(double value, double limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static double IsLte(double value, double limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static double IsGt(double value, double limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static double IsGte(double value, double limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static double IsInRange(double value, double min, double max, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
