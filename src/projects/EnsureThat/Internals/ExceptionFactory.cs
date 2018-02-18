using System;
using JetBrains.Annotations;

namespace EnsureThat.Internals
{
    internal sealed class ExceptionFactory
    {
        [NotNull]
        [Pure]
        internal Exception ArgumentException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
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
        internal Exception ArgumentNullException([NotNull] string defaultMessage, [NotNull] string paramName, OptsFn optsFn)
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
        internal Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, [NotNull] string paramName, TValue value, OptsFn optsFn)
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