using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Ensure
    {
        public static bool IsActive { get; private set; } = true;

        public static void Off() => IsActive = false;

        public static void On() => IsActive = true;

        /// <summary>
        /// Ensures for objects.
        /// </summary>
        [NotNull]
        public static AnyArg Any { get; } = new AnyArg();

        /// <summary>
        /// Ensures for booleans.
        /// </summary>
        [NotNull]
        public static BoolArg Bool { get; } = new BoolArg();

        /// <summary>
        /// Ensures for enumerables.
        /// </summary>
        /// <remarks>MULTIPLE ENUMERATION OF PASSED ENUMERABLE IS POSSIBLE.</remarks>
        [NotNull]
        public static EnumerableArg Enumerable { get; } = new EnumerableArg();

        /// <summary>
        /// Ensures for collections.
        /// </summary>
        [NotNull]
        public static CollectionArg Collection { get; } = new CollectionArg();

        /// <summary>
        /// Ensures for comparables.
        /// </summary>
        [NotNull]
        public static ComparableArg Comparable { get; } = new ComparableArg();

        /// <summary>
        /// Ensures for guids.
        /// </summary>
        [NotNull]
        public static GuidArg Guid { get; } = new GuidArg();

        /// <summary>
        /// Ensures for strings.
        /// </summary>
        [NotNull]
        public static StringArg String { get; } = new StringArg();

        /// <summary>
        /// Ensures for types.
        /// </summary>
        [NotNull]
        public static TypeArg Type { get; } = new TypeArg();
    }
}