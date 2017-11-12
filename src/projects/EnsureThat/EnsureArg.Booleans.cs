using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Bool.IsTrue(value, paramName);

        [DebuggerStepThrough]
        public static bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Bool.IsFalse(value, paramName);
    }
}