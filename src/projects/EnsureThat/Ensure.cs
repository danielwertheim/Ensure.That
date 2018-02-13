using EnsureThat.Enforcers;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Ensure
    {
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
            Any = new AnyArg();
            Bool = new BoolArg();
            Enumerable = new EnumerableArg();
            Collection = new CollectionArg();
            Comparable = new ComparableArg();
            Guid = new GuidArg();
            String = new StringArg();
            Type = new TypeArg();
        }

        /// <summary>
        /// Ensures for objects.
        /// </summary>
        [NotNull]
        public static IAnyArg Any { get; private set; } = new AnyArg();

        /// <summary>
        /// Ensures for booleans.
        /// </summary>
        [NotNull]
        public static IBoolArg Bool { get; private set; } = new BoolArg();

        /// <summary>
        /// Ensures for enumerables.
        /// </summary>
        /// <remarks>MULTIPLE ENUMERATION OF PASSED ENUMERABLE IS POSSIBLE.</remarks>
        [NotNull]
        public static IEnumerableArg Enumerable { get; private set; } = new EnumerableArg();

        /// <summary>
        /// Ensures for collections.
        /// </summary>
        [NotNull]
        public static ICollectionArg Collection { get; private set; } = new CollectionArg();

        /// <summary>
        /// Ensures for comparables.
        /// </summary>
        [NotNull]
        public static IComparableArg Comparable { get; private set; } = new ComparableArg();

        /// <summary>
        /// Ensures for guids.
        /// </summary>
        [NotNull]
        public static IGuidArg Guid { get; private set; } = new GuidArg();

        /// <summary>
        /// Ensures for strings.
        /// </summary>
        [NotNull]
        public static IStringArg String { get; private set; } = new StringArg();

        /// <summary>
        /// Ensures for types.
        /// </summary>
        [NotNull]
        public static ITypeArg Type { get; private set; } = new TypeArg();
    }
}