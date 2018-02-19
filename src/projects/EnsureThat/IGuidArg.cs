using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IGuidArg
    {
        Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
    }
}