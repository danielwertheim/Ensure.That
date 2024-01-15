using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static bool IsTrue(bool value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Bool.IsTrue(value, paramName);

        public static bool IsFalse(bool value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Bool.IsFalse(value, paramName);

        public static T IsNotDefault<T>(T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : struct
            => Ensure.Any.IsNotDefault(value, paramName);

        public static T? IsNotNull<T>(T? value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : struct
            => Ensure.Any.IsNotNull(value, paramName);

        public static Guid IsNotEmpty(Guid value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.Guid.IsNotEmpty(value, paramName);
    }
}
