using System;
using System.Collections.Generic;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IEnumerableArg
    {
        IEnumerable<T> HasItems<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        IEnumerable<T> SizeIs<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        IEnumerable<T> SizeIs<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, long expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        IEnumerable<T> HasAny<T>([ValidatedNotNull, InstantHandle]IEnumerable<T> value, [NotNull] Func<T, bool> predicate, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
    }
}