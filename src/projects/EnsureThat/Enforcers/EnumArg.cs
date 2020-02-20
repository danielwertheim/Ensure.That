using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class EnumArg
    {
        /// <summary>
        /// Confirms that the <paramref name="value"/> is defined in the enum <typeparamref name="T"/>.
        /// </summary>
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