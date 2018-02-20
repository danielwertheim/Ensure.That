using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    /// <summary>
    /// Ensures for <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <remarks>MULTIPLE ENUMERATION OF PASSED ENUMERABLE IS POSSIBLE.</remarks>
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public class EnumerableArg : IEnumerableArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public EnumerableArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

        [NotNull]
        public IEnumerable<T> HasItems<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any())
                throw _exceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public IEnumerable<T> SizeIs<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            var count = value.Count();

            if (count != expected)
                throw _exceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public IEnumerable<T> SizeIs<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, long expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

#if NETSTANDARD1_1
            var count = value.LongCount();

            if (count != expected)
#else
            var count = value.LongCount();

            if (count != expected)
#endif
                throw _exceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_SizeIs_Failed.Inject(expected, count),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public IEnumerable<T> HasAny<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw _exceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName,
                    optsFn);

            return value;
        }
    }
}