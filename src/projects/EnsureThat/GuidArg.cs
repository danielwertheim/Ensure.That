using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class GuidArg
    {
        public Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.Equals(Guid.Empty))
                throw ExceptionFactory.ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}