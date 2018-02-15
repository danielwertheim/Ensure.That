using System;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public class GuidArg : IGuidArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public GuidArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

        public Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value.Equals(Guid.Empty))
                throw _exceptionFactory.ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}