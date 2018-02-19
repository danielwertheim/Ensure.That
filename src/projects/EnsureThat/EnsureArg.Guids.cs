using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Guid.IsNotEmpty(value, paramName, optsFn);
    }
}