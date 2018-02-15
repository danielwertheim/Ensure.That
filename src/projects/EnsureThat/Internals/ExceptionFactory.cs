using System;
using JetBrains.Annotations;

namespace EnsureThat.Internals
{
    internal class ExceptionFactory : IExceptionFactory
    {
        [NotNull]
        [Pure]
        public Exception ArgumentException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
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
        public Exception ArgumentNullException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
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
        public Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, [NotNull] string paramName, TValue value, OptsFn optsFn)
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