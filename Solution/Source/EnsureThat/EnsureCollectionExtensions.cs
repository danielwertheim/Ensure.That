using System.Collections;
using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureCollectionExtensions
    {
        [DebuggerStepThrough]
        public static Param<T> HasItems<T>(this Param<T> param) where T : class, ICollection
        {
            if (param.Value == null || param.Value.Count < 1)
                throw ExceptionFactory.CreateForParamValidation(param.Name, ExceptionMessages.EnsureExtensions_IsNonEmptyCollection);

            return param;
        }
    }
}