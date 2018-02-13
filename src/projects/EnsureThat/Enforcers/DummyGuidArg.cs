using System;

namespace EnsureThat.Enforcers
{
    internal class DummyGuidArg : IGuidArg
    {
        public Guid IsNotEmpty(Guid value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}