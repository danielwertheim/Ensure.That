using System;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static bool IsTrue(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsTrueFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        public static bool IsFalse(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsFalseFailed,
                    paramName);

            return value;
        }
    }
}