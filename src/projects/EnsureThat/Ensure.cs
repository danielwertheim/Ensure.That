using EnsureThat.Enforcers;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Ensure
    {
        private static readonly IExceptionFactory ExceptionFactory = new ExceptionFactory();

        public static void Off()
        {
            Any = new DummyAnyArg();
            Bool = new DummyBoolArg();
            Enumerable = new DummyEnumerableArg();
            Collection = new DummyCollectionArg();
            Comparable = new DummyComparableArg();
            Guid = new DummyGuidArg();
            String = new DummyStringArg();
            Type = new DummyTypeArg();
        }

        public static void On()
        {
            Any = new AnyArg(ExceptionFactory);
            Bool = new BoolArg(ExceptionFactory);
            Enumerable = new EnumerableArg(ExceptionFactory);
            Collection = new CollectionArg(ExceptionFactory);
            Comparable = new ComparableArg(ExceptionFactory);
            Guid = new GuidArg(ExceptionFactory);
            String = new StringArg(ExceptionFactory);
            Type = new TypeArg(ExceptionFactory);
        }

        /// <summary>
        /// Ensures for objects.
        /// </summary>
        [NotNull]
        public static IAnyArg Any { get; set; } = new AnyArg(ExceptionFactory);

        /// <summary>
        /// Ensures for booleans.
        /// </summary>
        [NotNull]
        public static IBoolArg Bool { get; set; } = new BoolArg(ExceptionFactory);

        /// <summary>
        /// Ensures for enumerables.
        /// </summary>
        /// <remarks>MULTIPLE ENUMERATION OF PASSED ENUMERABLE IS POSSIBLE.</remarks>
        [NotNull]
        public static IEnumerableArg Enumerable { get; set; } = new EnumerableArg(ExceptionFactory);

        /// <summary>
        /// Ensures for collections.
        /// </summary>
        [NotNull]
        public static ICollectionArg Collection { get; set; } = new CollectionArg(ExceptionFactory);

        /// <summary>
        /// Ensures for comparables.
        /// </summary>
        [NotNull]
        public static IComparableArg Comparable { get; set; } = new ComparableArg(ExceptionFactory);

        /// <summary>
        /// Ensures for guids.
        /// </summary>
        [NotNull]
        public static IGuidArg Guid { get; set; } = new GuidArg(ExceptionFactory);

        /// <summary>
        /// Ensures for strings.
        /// </summary>
        [NotNull]
        public static IStringArg String { get; set; } = new StringArg(ExceptionFactory);

        /// <summary>
        /// Ensures for types.
        /// </summary>
        [NotNull]
        public static ITypeArg Type { get; set; } = new TypeArg(ExceptionFactory);

        /// <summary>
        /// Ensures via discoverable API. Please note that an extra wrapping object
        /// <see cref="Param{T}"/> will be created. This can have performance impacts.
        /// Use <see cref="EnsureArg"/> or contextual e.g. <see cref="Ensure.String"/>
        /// if worried about performance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="optsFn"></param>
        /// <returns></returns>
        [Pure]
        public static Param<T> That<T>([NoEnumeration]T value, string name = Param.DefaultName, OptsFn optsFn = null)
            => new Param<T>(name, value);
    }
}