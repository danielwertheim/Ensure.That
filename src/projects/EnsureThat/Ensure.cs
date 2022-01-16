using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using EnsureThat.Enforcers;
using JetBrains.Annotations;

namespace EnsureThat
{
    [SuppressMessage("Naming", "CA1720:Identifier contains type name")]
    public static class Ensure
    {
        /// <summary>
        /// Gets or Sets the Exception factory to use.
        /// </summary>
        public static IExceptionFactory ExceptionFactory { get; set; } = EnsureThat.ExceptionFactory.Default;

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
        /// Ensures for enums.
        /// </summary>
        [NotNull]
        public static EnumArg Enum { get; } = new EnumArg();

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

        /// <summary>
        /// Ensures via discoverable API. Please note that an extra wrapping object
        /// <see cref="Param{T}"/> will be created. This can have performance impacts.
        /// Use <see cref="EnsureArg"/> or contextual e.g. <see cref="Ensure.String"/>
        /// if worried about performance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Pure]
        public static Param<T> That<T>([NoEnumeration] T value, string name = null)
            => new Param<T>(name, value);

        /// <summary>
        /// Ensures via discoverable API. Please note that an extra wrapping object
        /// <see cref="Param{T}"/> will be created. This can have performance impacts.
        /// Use <see cref="EnsureArg"/> or contextual e.g. <see cref="Ensure.String"/>
        /// if worried about performance.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Pure]
        public static StringParam That([NoEnumeration] string value, string name = null)
            => new StringParam(name, value);

        /// <summary>
        /// Ensures via discoverable API. Please note that an extra wrapping object
        /// <see cref="Param{T}"/> will be created. This can have performance impacts.
        /// Use <see cref="EnsureArg"/> or contextual e.g. <see cref="Ensure.Type"/>
        /// if worried about performance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Pure]
        public static TypeParam ThatTypeFor<T>([NotNull] T value, string name = null)
            => new TypeParam(name, value.GetType());

        /// <summary>
        /// Ensures via discoverable API. Please note that an extra wrapping object
        /// <see cref="Param{T}"/> will be created. This can have performance impacts.
        /// Use <see cref="EnsureArg"/> or contextual e.g. <see cref="Ensure.Type"/>
        /// if worried about performance.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [Pure]
        public static TypeParam ThatType([NotNull] Type value, string name = null)
            => new TypeParam(name, value);
    }
}
