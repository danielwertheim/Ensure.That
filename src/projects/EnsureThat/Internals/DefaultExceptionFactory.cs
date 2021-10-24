using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace EnsureThat.Internals
{
    public sealed class DefaultExceptionFactory : IExceptionFactory
    {
        [return: NotNull]
        [Pure]
        public Exception ArgumentException(string defaultMessage, string paramName)
        {
            var opts = EnsureScope.GetCurrent();
            if(opts.HasValue)
            {
                if (opts.Value.CustomExceptionFactory != null)
                    return opts.Value.CustomExceptionFactory(defaultMessage, paramName);

                if (opts.Value.CustomException != null)
                    return opts.Value.CustomException;

                if (opts.Value.CustomMessage != null)
                    return new ArgumentException(opts.Value.CustomMessage, paramName);
            }

            return new ArgumentException(defaultMessage, paramName);
        }

        [return: NotNull]
        [Pure]
        public Exception ArgumentNullException(string defaultMessage, string paramName)
        {
            var opts = EnsureScope.GetCurrent();
            if(opts.HasValue)
            {
                if (opts.Value.CustomExceptionFactory != null)
                    return opts.Value.CustomExceptionFactory(defaultMessage, paramName);

                if (opts.Value.CustomException != null)
                    return opts.Value.CustomException;

                if (opts.Value.CustomMessage != null)
                    return new ArgumentNullException(paramName, opts.Value.CustomMessage);
            }

            return new ArgumentNullException(paramName, defaultMessage);
        }

        [return: NotNull]
        [Pure]
        public Exception ArgumentOutOfRangeException<TValue>(string defaultMessage, string paramName, TValue value)
        {
            var opts = EnsureScope.GetCurrent();
            if(opts.HasValue)
            {
                if (opts.Value.CustomExceptionFactory != null)
                    return opts.Value.CustomExceptionFactory(defaultMessage, paramName);

                if (opts.Value.CustomException != null)
                    return opts.Value.CustomException;

                if (opts.Value.CustomMessage != null)
                    return new ArgumentOutOfRangeException(paramName, value, opts.Value.CustomMessage);
            }

            return new ArgumentOutOfRangeException(paramName, value, defaultMessage);
        }
    }
}
