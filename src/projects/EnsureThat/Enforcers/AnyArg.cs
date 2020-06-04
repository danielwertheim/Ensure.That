using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class AnyArg
    {
        /// <summary>
        /// Ensures value is not null.
        /// Supports both <see cref="Nullable{T}"/> and reference types.
        /// If you know you are dealing with a certain type, e.g struct use preferred <see cref="IsNotNull{T}(T?, string, OptsFn)"/>
        /// overload instead as it is more performant.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="paramName"></param>
        /// <param name="optsFn"></param>
        /// <returns></returns>
        /// <remarks>If you know you are dealing with e.g. a struct, the <see cref="IsNotNull{T}(T?, string, OptsFn)"/> overload is more performant.</remarks>
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public T HasValue<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            // ReSharper disable once HeapView.BoxingAllocation
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

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