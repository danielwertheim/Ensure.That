using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public class GuidArg : IGuidArg
    {
        public Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.Equals(Guid.Empty))
                throw ExceptionFactory.ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}