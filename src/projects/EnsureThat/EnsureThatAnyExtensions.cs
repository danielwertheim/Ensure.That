using System;

namespace EnsureThat
{
    public static class EnsureThatAnyExtensions
    {
        public static Param<T> IsNotNull<T>(this in Param<T> param) where T : class
        {
            Ensure.Any.IsNotNull(param.Value, param.Name);

            return param;
        }
    }
}
