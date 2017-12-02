using System;
using System.Collections.Generic;
using System.Diagnostics;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class EquatableArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public T Equals<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T Equals<T>(T value, T expected, [NotNull] IEqualityComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected, comparer))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T DoesNotEqual<T>([NotNull] T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T DoesNotEqual<T>(T value, T expected, [NotNull] IEqualityComparer<T> comparer, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected, comparer))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }
    }
}