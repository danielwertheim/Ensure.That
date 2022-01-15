using System;

namespace EnsureThat
{
    public static class EnsureThatAnyExtensions
    {
        /// <summary>
        /// Ensures value is not null.
        /// Supports both <see cref="Nullable{T}"/> and reference types.
        /// If you know you are dealing with a certain type, e.g struct use preferred <see cref="EnsureThatValueTypeExtensions.IsNotNull{T}"/>
        /// overload instead as it is more performant.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <remarks>If you know you are dealing with e.g. a struct, the <see cref="EnsureThatValueTypeExtensions.IsNotNull{T}"/> overload is more performant.</remarks>
        public static Param<T> HasValue<T>(this in Param<T> param)
        {
            Ensure.Any.HasValue(param.Value, param.Name);

            return param;
        }

        /// <summary>
        /// Ensures value is not null.
        /// Supports both <see cref="Nullable{T}"/> and reference types.
        /// If you know you are dealing with a certain type, e.g struct use preferred <see cref="EnsureThatValueTypeExtensions.IsNotNull{T}"/>
        /// overload instead as it is more performant.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <remarks>If you know you are dealing with e.g. a struct, the <see cref="EnsureThatValueTypeExtensions.IsNotNull{T}"/> overload is more performant.</remarks>
        public static Param<T> IsNotNull<T>(this in Param<T> param) where T : class
        {
            Ensure.Any.IsNotNull(param.Value, param.Name);

            return param;
        }
    }
}
