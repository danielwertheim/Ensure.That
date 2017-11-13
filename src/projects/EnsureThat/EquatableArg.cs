using System;
using System.Diagnostics;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public class EquatableArg
    {
        [DebuggerStepThrough]
        public T Is<T>(T value, T expected, string paramName = Param.DefaultName) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (!value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_Is_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public T IsNot<T>(T value, T expected, string paramName = Param.DefaultName) where T : IEquatable<T>
        {
            if (!Ensure.IsActive)
                return value;

            if (value.IsEq(expected))
                throw new ArgumentException(ExceptionMessages.Comp_IsNot_Failed.Inject(value, expected), paramName);

            return value;
        }
    }
}