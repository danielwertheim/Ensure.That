using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    // TODO: these will all be [Pure] when/if Param is immutable
    public static class ParamExtensions
    {
        [Pure]
        public static Param<T> And<T>(this Param<T> param)
        {
            return param;
        }

        public static Param<T> WithExtraMessageOf<T>(this Param<T> param, string message)
        {
            param.ExtraMessageFn = p => message;

            return param;
        }

        public static Param<T> WithExtraMessageOf<T>(this Param<T> param, Func<string> messageFn)
        {
            param.ExtraMessageFn = p => messageFn();

            return param;
        }

        public static Param<T> WithExtraMessageOf<T>(this Param<T> param, Func<Param<T>, string> messageFn)
        {
            param.ExtraMessageFn = messageFn;

            return param;
        }

        public static Param<T> WithException<T>(this Param<T> param, Func<Param<T>, Exception> exceptionFn)
        {
            param.ExceptionFn = exceptionFn;

            return param;
        }
    }
}