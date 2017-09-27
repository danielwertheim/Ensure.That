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

        [DebuggerStepThrough]
        [Obsolete("Use EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>([NoEnumeration]T value, string name = Param.DefaultName) => new Param<T>(name, value);

        [DebuggerStepThrough]
        [Obsolete("Use EnsureArg instead. This version will eventually be removed.", false)]
        public static Param<T> That<T>(Func<T> expression, string name = Param.DefaultName) => new Param<T>(
            name,
            expression.Invoke());

        [DebuggerStepThrough]
        [Obsolete("Use EnsureArg instead. This version will eventually be removed.", false)]
        public static TypeParam ThatTypeFor<T>(T value, string name = Param.DefaultName) => new TypeParam(name, value.GetType());
    }
}