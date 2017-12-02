using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public static T Equals<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IEquatable<T>
            => Ensure.Equatable.Equals(value, expected, paramName);

        [DebuggerStepThrough]
        public static T Equals<T>(T value, T expected, [NotNull] IEqualityComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Equatable.Equals(value, expected, comparer, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T DoesNotEqual<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IEquatable<T>
            => Ensure.Equatable.DoesNotEqual(value, expected, paramName);

        [DebuggerStepThrough]
        public static T DoesNotEqual<T>(T value, T expected, [NotNull] IEqualityComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Equatable.DoesNotEqual(value, expected, comparer, paramName);
    }
}
