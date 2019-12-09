using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static int Is(int value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.Is(value, expected, paramName, optsFn);

        public static int IsNot(int value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNot(value, expected, paramName, optsFn);

        public static int IsLt(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLt(value, limit, paramName, optsFn);

        public static int IsLte(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLte(value, limit, paramName, optsFn);

        public static int IsGt(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGt(value, limit, paramName, optsFn);

        public static int IsGte(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGte(value, limit, paramName, optsFn);

        public static int IsInRange(int value, int min, int max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName, optsFn);

        public static int IsPositive(int value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
             => Ensure.Comparable.IsPositive(value, zeroSignMode, paramName, optsFn);

        public static int IsNegative(int value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNegative(value, zeroSignMode, paramName, optsFn);

        public static int IsNotNegative(int value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNotNegative(value, zeroSignMode, paramName, optsFn);

        public static int IsApproximately(int value, int target, int accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsApproximately(value,target, accuracy, paramName, optsFn);
    }
}
