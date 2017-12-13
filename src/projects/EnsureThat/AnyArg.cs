using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class AnyArg
    {
        [NotNull]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
        {
            if (!Ensure.IsActive)
                return value;

            if (default(T).Equals(value))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName, optsFn);

            return value;
        }
    }
}