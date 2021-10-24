using System;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class EnumArg
    {
        /// <summary>
        /// Confirms that the <paramref name="value"/> is defined in the enum <typeparamref name="T"/>.
        /// Note that just like <see cref="Enum.IsDefined(Type, object)"/>,
        /// <see cref="FlagsAttribute"/> based enums may be valid combination of defined values, but if the combined value
        /// itself is not named an error will be raised. Avoid usage with <see cref="FlagsAttribute"/> enums.
        /// </summary>
        /// <example>
        /// Flags example:
        ///
        /// [Flags]
        /// enum Abc {
        ///   A = 1,
        ///   B = 2,
        ///   C = 4,
        ///   AB = 3
        /// }
        ///
        /// Abc.A | Abc.B IsDefined=true (due to Abc.AB)
        /// Abc.A | Abc.C IsDefined=false (A and C are both valid, the composite is valid due to <see cref="FlagsAttribute"/> attribute, but the composite is not a named enum value
        /// </example>
        public T IsDefined<T>(T value, [InvokerParameterName] string paramName = null) where T : struct, Enum
        {
            if (!Enum.IsDefined(typeof(T), value))
            {
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Enum_IsValidEnum, value, typeof(T)),
                    paramName,
                    value);
            }

            return value;
        }

        /// <summary>
        /// Confirms that the <paramref name="value"/> is defined in the enum <typeparamref name="T"/>.
        /// Supports <see cref="FlagsAttribute"/> attribute.
        /// </summary>
        public T IsDefinedWithFlagsSupport<T>(T value, [InvokerParameterName] string paramName = null) where T : struct, Enum
        {
            var isEnumDefined = EnumOf<T>.Contains(value);

            if (!isEnumDefined)
            {
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Enum_IsValidEnum, value, EnumOf<T>.EnumType),
                    paramName,
                    value);
            }

            return value;
        }
    }
}
