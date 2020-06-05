using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static decimal Is(decimal value, decimal expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.Is(value, expected, paramName, optsFn);

        public static decimal IsNot(decimal value, decimal expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNot(value, expected, paramName, optsFn);

        public static decimal IsLt(decimal value, decimal limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLt(value, limit, paramName, optsFn);

        public static decimal IsLte(decimal value, decimal limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsLte(value, limit, paramName, optsFn);

        public static decimal IsGt(decimal value, decimal limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGt(value, limit, paramName, optsFn);

        public static decimal IsGte(decimal value, decimal limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsGte(value, limit, paramName, optsFn);

        public static decimal IsInRange(decimal value, decimal min, decimal max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsInRange(value, min, max, paramName, optsFn);

        public static decimal IsPositive(decimal value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
             => Ensure.Comparable.IsPositive(value, zeroSignMode, paramName, optsFn);

        public static decimal IsNegative(decimal value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNegative(value, zeroSignMode, paramName, optsFn);

        public static decimal IsNotNegative(decimal value, ZeroSignMode zeroSignMode = ZeroSignMode.IsNeither, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsNotNegative(value, zeroSignMode, paramName, optsFn);

        public static decimal IsApproximately(decimal value, decimal target, decimal accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Comparable.IsApproximately(value, target, accuracy, paramName, optsFn);
    }
}
