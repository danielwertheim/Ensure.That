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

        public static AnyArg Any { get; } = new AnyArg();

        public static BoolArg Bool { get; } = new BoolArg();

        public static CollectionArg Collection { get; } = new CollectionArg();

        public static ComparableArg Comparable { get; } = new ComparableArg();

        public static GuidArg Guid { get; } = new GuidArg();

        public static StringArg String { get; } = new StringArg();

        public static TypeArg Type { get; } = new TypeArg();

        [DebuggerStepThrough]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>([NoEnumeration]T value, string name = Param.DefaultName) => new Param<T>(name, value);

        [DebuggerStepThrough]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>(Func<T> expression, string name = Param.DefaultName) => new Param<T>(
            name,
            expression.Invoke());

        [DebuggerStepThrough]
        [Obsolete("Use contextual validation instead. E.g. Ensure.String.IsNotNull(value) or non contextual via EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<Type> ThatTypeFor<T>(T value, string name = Param.DefaultName) => new Param<Type>(name, value.GetType());
    }
}