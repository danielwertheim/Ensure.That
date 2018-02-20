using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static bool IsTrue(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Bool.IsTrue(value, paramName, optsFn);

        public static bool IsFalse(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Bool.IsFalse(value, paramName, optsFn);
    }
}