using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class BoolArg
    {
        [DebuggerStepThrough]
        public bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
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
        public bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
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