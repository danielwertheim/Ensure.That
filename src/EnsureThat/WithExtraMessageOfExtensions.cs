using System;

namespace EnsureThat
{
    public static class WithExtraMessageOfExtensions
    {
        public static Param<T> WithExtraMessageOf<T>(this Param<T> param, Func<Param<T>, string> messageFn)
        {
            param.ExtraMessageFn = messageFn;

            return param;
        }
    }
}