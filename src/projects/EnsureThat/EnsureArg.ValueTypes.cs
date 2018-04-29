using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static bool IsTrue(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Bool.IsTrue(value, paramName, optsFn);

        public static bool IsFalse(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Bool.IsFalse(value, paramName, optsFn);

        public static T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Any.IsNotDefault(value, paramName, optsFn);

        public static T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Any.IsNotNull(value, paramName, optsFn);

        public static Guid IsNotEmpty(Guid value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Guid.IsNotEmpty(value, paramName, optsFn);
    }
}