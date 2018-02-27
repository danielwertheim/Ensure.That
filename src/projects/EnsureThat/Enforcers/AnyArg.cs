using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class AnyArg
    {
        [NotNull]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
        {
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
        {
            if (default(T).Equals(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName, optsFn);

            return value;
        }
    }
}