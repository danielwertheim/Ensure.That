using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IExceptionFactory
    {
        Exception ArgumentException([NotNull] string defaultMessage, string paramName, OptsFn optsFn);
        Exception ArgumentNullException([NotNull] string defaultMessage, string paramName, OptsFn optsFn);
        Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, string paramName, TValue value, OptsFn optsFn);
    }
}