using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class GuidArg
    {
        public Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = null)
        {
            if (value.Equals(Guid.Empty))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName);

            return value;
        }
    }
}
