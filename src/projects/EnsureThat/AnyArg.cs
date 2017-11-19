using System;
using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class AnyArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Common_IsNotNull_Failed);

            return value;
        }

        [DebuggerStepThrough]
        public T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Common_IsNotNull_Failed);

            return value;
        }

        [DebuggerStepThrough]
        public T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = Param.DefaultName) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (default(T).Equals(value))
                throw new ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName);

            return value;
        }
    }
}