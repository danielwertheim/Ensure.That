using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed class GuidArg
    {
        public Guid IsNotEmpty(Guid value, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value.Equals(Guid.Empty))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName);

            return value;
        }
    }
}
