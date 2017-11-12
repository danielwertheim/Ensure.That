using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class GuidArg
    {
        [DebuggerStepThrough]
        public Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.Equals(Guid.Empty))
                throw new ArgumentException(
                    ExceptionMessages.Guids_IsNotEmpty_Failed,
                    paramName);

            return value;
        }
    }
}