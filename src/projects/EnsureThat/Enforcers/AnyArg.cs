using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class AnyArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T HasValue<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) => value switch
        {
            ValueType _ => value,
            var x => x ?? throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn)
        };
        
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
        {
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T? IsNotNull<T>([ValidatedNotNull] T? value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
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