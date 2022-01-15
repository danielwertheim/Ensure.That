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
            => new ArgumentException(defaultMessage, paramName);

        [return: NotNull]
        [Pure]
        public Exception ArgumentNullException(string defaultMessage, string paramName)
            => new ArgumentNullException(paramName, defaultMessage);

        [return: NotNull]
        [Pure]
        public Exception ArgumentOutOfRangeException<TValue>(string defaultMessage, string paramName, TValue value)
            => new ArgumentOutOfRangeException(paramName, value, defaultMessage);
    }
}
