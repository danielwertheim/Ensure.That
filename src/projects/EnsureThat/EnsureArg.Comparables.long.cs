using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static long Is(long value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.Is(value, expected, paramName, optsFn);

        public static long IsNot(long value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNot(value, expected, paramName, optsFn);

        public static long IsLt(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLt(value, limit, paramName, optsFn);

        public static long IsLte(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLte(value, limit, paramName, optsFn);

        public static long IsGt(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGt(value, limit, paramName, optsFn);

        public static long IsGte(long value, long limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGte(value, limit, paramName, optsFn);

        public static long IsInRange(long value, long min, long max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName, optsFn);
    }
}
