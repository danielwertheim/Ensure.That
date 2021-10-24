using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static int Is(int value, int expected, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.Is(value, expected, paramName);

        public static int IsNot(int value, int expected, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsNot(value, expected, paramName);

        public static int IsLt(int value, int limit, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsLt(value, limit, paramName);

        public static int IsLte(int value, int limit, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsLte(value, limit, paramName);

        public static int IsGt(int value, int limit, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsGt(value, limit, paramName);

        public static int IsGte(int value, int limit, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsGte(value, limit, paramName);

        public static int IsInRange(int value, int min, int max, [InvokerParameterName] string paramName = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}
