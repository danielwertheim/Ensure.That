using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsNotDefault<T>(T param, string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return;

            if (default(T).Equals(param))
                throw new ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName);
        }
    }
}