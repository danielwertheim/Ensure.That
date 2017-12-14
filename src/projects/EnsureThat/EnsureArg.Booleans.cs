using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Bool.IsTrue(value, paramName);

        public static bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.Bool.IsFalse(value, paramName);
    }
}