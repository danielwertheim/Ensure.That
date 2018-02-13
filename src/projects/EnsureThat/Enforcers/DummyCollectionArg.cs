using System;
using System.Collections;
using System.Collections.Generic;

namespace EnsureThat.Enforcers
{
    internal class DummyCollectionArg : ICollectionArg
    {
        public T HasItems<T>(T value, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => value;

        public ICollection<T> HasItems<T>(ICollection<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IReadOnlyCollection<T> HasItems<T>(IReadOnlyCollection<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IReadOnlyList<T> HasItems<T>(IReadOnlyList<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public ISet<T> HasItems<T>(ISet<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T[] HasItems<T>(T[] value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IList<T> HasItems<T>(IList<T> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IDictionary<TKey, TValue> HasItems<TKey, TValue>(IDictionary<TKey, TValue> value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T[] SizeIs<T>(T[] value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T[] SizeIs<T>(T[] value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T SizeIs<T>(T value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => value;

        public T SizeIs<T>(T value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : ICollection
            => value;

        public ICollection<T> SizeIs<T>(ICollection<T> value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public ICollection<T> SizeIs<T>(ICollection<T> value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IList<T> SizeIs<T>(IList<T> value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IList<T> SizeIs<T>(IList<T> value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, long expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>(IDictionary<TKey, TValue> value, TKey expectedKey, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public IList<T> HasAny<T>(IList<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public ICollection<T> HasAny<T>(ICollection<T> value, Func<T, bool> predicate, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T[] HasAny<T>(T[] value, Func<T, bool> predicate, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}