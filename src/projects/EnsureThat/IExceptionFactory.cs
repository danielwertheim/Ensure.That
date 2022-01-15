using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    public interface IExceptionFactory
    {
        Exception ArgumentException([NotNull] string defaultMessage, string paramName);
        Exception ArgumentNullException([NotNull] string defaultMessage, string paramName);
        Exception ArgumentOutOfRangeException<TValue>([NotNull] string defaultMessage, string paramName, TValue value);
    }
}
