using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsNotNull<T>(T? value, string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return;

            if (value == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.EnsureExtensions_IsNotNull);
        }
    }
}