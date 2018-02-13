using System;
using System.Collections.Generic;

namespace EnsureThat.Enforcers
{
    internal class DummyEnumerableArg : IEnumerableArg
    {
        public IEnumerable<T> HasItems<T>(IEnumerable<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IEnumerable<T> SizeIs<T>(IEnumerable<T> value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IEnumerable<T> SizeIs<T>(IEnumerable<T> value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IEnumerable<T> HasAny<T>(IEnumerable<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}