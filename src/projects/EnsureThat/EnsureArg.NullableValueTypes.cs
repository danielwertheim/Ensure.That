using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = Param.DefaultName) where T : struct
            => Ensure.Any.IsNotNull(value, paramName);
    }
}