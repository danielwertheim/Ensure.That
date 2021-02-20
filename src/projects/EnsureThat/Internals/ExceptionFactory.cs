using System;
using JetBrains.Annotations;

namespace EnsureThat.Internals
{
    internal sealed class ExceptionFactory : IExceptionFactory
    {
        [NotNull]
        [Pure]
        public Exception ArgumentException(string defaultMessage, string paramName, OptsFn optsFn = null)
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
        public Exception ArgumentNullException(string defaultMessage, string paramName, OptsFn optsFn = null)
        {
            if (optsFn != null)
            {
                var opts = optsFn(new EnsureOptions());

                if (opts.CustomExceptionFactory != null)
                    return opts.CustomExceptionFactory(defaultMessage, paramName);

                if (opts.CustomException != null)
                    return opts.CustomException;

                if (opts.CustomMessage != null)
                    return new ArgumentNullException(paramName, opts.CustomMessage);
            }

            return new ArgumentNullException(paramName, defaultMessage);
        }

        [NotNull]
        [Pure]
        public Exception ArgumentOutOfRangeException<TValue>(string defaultMessage, string paramName, TValue value, OptsFn optsFn = null)
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
    }
}
