using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
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
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T HasValue<T>([NoEnumeration, ValidatedNotNull, NotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Any.HasValue(value, paramName, optsFn);
        
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T IsNotNull<T>([NoEnumeration, ValidatedNotNull, NotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Any.IsNotNull(value, paramName, optsFn);
    }
}
