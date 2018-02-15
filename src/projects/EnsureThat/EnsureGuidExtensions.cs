using System;

namespace EnsureThat
{
    public static class EnsureGuidExtensions
    {
        public static void IsNotEmpty(this Param<Guid> param)
            => Ensure.Guid.IsNotEmpty(param.Value, param.Name, param.OptsFn);
    }
}