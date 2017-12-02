using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Ensure
    {
        public static bool IsActive { get; private set; } = true;

        public static void Off() => IsActive = false;

        public static void On() => IsActive = true;

        [NotNull]
        public static AnyArg Any { get; } = new AnyArg();

        [NotNull]
        public static BoolArg Bool { get; } = new BoolArg();

        [NotNull]
        public static CollectionArg Collection { get; } = new CollectionArg();

        [NotNull]
        public static ComparableArg Comparable { get; } = new ComparableArg();

        [NotNull]
        public static EquatableArg Equatable { get; } = new EquatableArg();

        [NotNull]
        public static GuidArg Guid { get; } = new GuidArg();

        [NotNull]
        public static StringArg String { get; } = new StringArg();

        [NotNull]
        public static TypeArg Type { get; } = new TypeArg();

        [DebuggerStepThrough]
        [Pure]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>([NoEnumeration]T value, string name = Param.DefaultName) => new Param<T>(name, value);

        [DebuggerStepThrough]
        [Pure]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>([NotNull] Func<T> expression, string name = Param.DefaultName) => new Param<T>(
            name,
            expression.Invoke());

        [DebuggerStepThrough]
        [Pure]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static TypeParam ThatTypeFor<T>([NotNull] T value, string name = Param.DefaultName) => new TypeParam(name, value.GetType());
    }
}