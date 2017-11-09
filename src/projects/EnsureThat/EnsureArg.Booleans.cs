using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static bool IsTrue(bool value, string paramName = Param.DefaultName)
            => Ensure.Bool.IsTrue(value, paramName);

        [DebuggerStepThrough]
        public static bool IsFalse(bool value, string paramName = Param.DefaultName)
            => Ensure.Bool.IsFalse(value, paramName);
    }
}