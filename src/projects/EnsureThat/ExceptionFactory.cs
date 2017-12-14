using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class ExceptionFactory
    {
        [NotNull]
        [Pure]
        public static Exception ArgumentException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
        {
            if (optsFn != null)
            {
                var opts = optsFn(new EnsureOptions());

                if (opts.CustomException != null)
                    return opts.CustomException;

                if (opts.CustomMessage != null)
                    return new ArgumentException(opts.CustomMessage, paramName);
            }

            return new ArgumentException(defaultMessage, paramName);
        }

        [NotNull]
        [Pure]
        public static Exception ArgumentNullException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
        {
            if (optsFn != null)
            {
                var opts = optsFn(new EnsureOptions());

                if (opts.CustomException != null)
                    return opts.CustomException;

                if (opts.CustomMessage != null)
                    return new ArgumentNullException(paramName, opts.CustomMessage);
            }

            return new ArgumentNullException(paramName, defaultMessage);
        }

        [NotNull]
        [Pure]
        public static Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, [NotNull] string paramName, TValue value, OptsFn optsFn)
        {
            if (optsFn != null)
            {
                var opts = optsFn(new EnsureOptions());

                if (opts.CustomException != null)
                    return opts.CustomException;

                if (opts.CustomMessage != null)
                    return new ArgumentOutOfRangeException(paramName, value, opts.CustomMessage);
            }

            return new ArgumentOutOfRangeException(paramName, value, defaultMessage);
        }

        [NotNull]
        [Pure]
        public static ArgumentException CreateForParamValidation([NotNull] Param param, string message)
            => new ArgumentException(message, param.Name);

        [NotNull]
        [Pure]
        public static ArgumentNullException CreateForParamNullValidation([NotNull] Param param, string message)
            => new ArgumentNullException(param.Name, message);

        [NotNull]
        public static Exception CreateForComparableParamValidation<T>([NotNull] Param<T> param, string message)
        {
            if (param.ExceptionFn != null)
                return param.ExceptionFn(param);

            return new ArgumentOutOfRangeException(
                param.Name,
                param.Value,
                param.ExtraMessageFn == null
                    ? message
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn(param)));
        }

        [NotNull]
        public static Exception CreateForParamValidation<T>([NotNull] Param<T> param, string message)
        {
            if (param.ExceptionFn != null)
                return param.ExceptionFn(param);

            return new ArgumentException(
                param.ExtraMessageFn == null
                    ? message
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn(param)),
                param.Name);
        }

        public static Exception CreateForParamNullValidation<T>([NotNull] Param<T> param, string message)
        {
            if (param.ExceptionFn != null)
                return param.ExceptionFn(param);

            return new ArgumentNullException(
                param.Name,
                param.ExtraMessageFn == null
                    ? message
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn(param)));
        }
    }
}