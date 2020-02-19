using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class EnumArg
    {
        /// <summary>
        /// Confirms that the <paramref name="value"/> is defined in the enum <typeparamref name="T"/>.
        /// </summary>
        public T IsValidEnum<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct, Enum
        {
            // TODO: Test performance, not sure if the BCL IsDefined implements this naively or like the fast versino
            if (!Enum.IsDefined(typeof(T), value))
            {
                // TODO: I believe this 'throw' prevents inlining of this method. If that is validated to be true, we probably refactor all throws to be method calls in the 'cold-path' (error) cases
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