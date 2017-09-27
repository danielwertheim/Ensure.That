using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T? IsNotNull<T>(T? value, string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Common_IsNotNull_Failed);

            return value;
        }
    }
}