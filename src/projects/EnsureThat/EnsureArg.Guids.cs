using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static Guid IsNotEmpty(Guid value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.Equals(Guid.Empty))
                throw new ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName);

            return value;
        }
    }
}