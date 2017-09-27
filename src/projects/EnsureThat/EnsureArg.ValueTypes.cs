using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T IsNotDefault<T>(T value, string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (default(T).Equals(value))
                throw new ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName);

            return value;
        }
    }
}