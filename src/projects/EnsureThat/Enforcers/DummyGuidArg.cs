using System;

namespace EnsureThat.Enforcers
{
    internal class DummyGuidArg : IGuidArg
    {
        public Guid IsNotEmpty(Guid value, string paramName = null, OptsFn optsFn = null)
            => value;
    }
}