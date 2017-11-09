using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T IsNotDefault<T>(T value, string paramName = Param.DefaultName) where T : struct
            => Ensure.Any.IsNotDefault(value, paramName);
    }
}