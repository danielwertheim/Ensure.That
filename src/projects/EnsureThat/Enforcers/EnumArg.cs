using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class EnumArg
    {
        /// <summary>
        /// Confirms that the <paramref name="value"/> is defined in the enum <typeparamref name="T"/>.
        /// Note that just like `Enum.IsDefined`, `Flags` based enums may be valid combination of defined values, but if the combined value
        /// itself is not named an error will be raised. Avoid usage with `Flags` enums.
        /// </summary>
        /// <example>
        /// Flags example:
        /// 
        /// [Flags]
        /// enum Abc{
        ///   A = 1,
        ///   B = 2,
        ///   C = 4,
        ///   AB = 3
        /// }
        ///
        /// Abc.A | Abc.B IsDefined=true (due to Abc.AB)
        /// Abc.A | Abc.C IsDefined=false (A and C are both valid, the composite is valid due to `Flags` attribute, but the composite is not a named enum value
        /// </example>
        public T IsDefined<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct, Enum
        {
            if (!Enum.IsDefined(typeof(T), value))
            {
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Enum_IsValidEnum, value, typeof(T)),
                    paramName,
                    value,
                    optsFn);
            }

            return value;
        }
    }
}