using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    public interface IExceptionFactory
    {
        Exception ArgumentException([NotNull] string defaultMessage, string paramName, OptsFn optsFn = null);
        Exception ArgumentNullException([NotNull] string defaultMessage, string paramName, OptsFn optsFn = null);
        Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, string paramName, TValue value, OptsFn optsFn = null);
    }
}
