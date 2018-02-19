using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        public static Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [NotNull]
        public static T IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [NotNull]
        public static Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [NotNull]
        public static T IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [NotNull]
        public static Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [NotNull]
        public static T IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [NotNull]
        public static Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [NotNull]
        public static T IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [NotNull]
        public static Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [NotNull]
        public static T IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [NotNull]
        public static Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [NotNull]
        public static T IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [NotNull]
        public static Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [NotNull]
        public static T IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [NotNull]
        public static Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [NotNull]
        public static T IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [NotNull]
        public static T IsOfType<T>([ValidatedNotNull] T param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [NotNull]
        public static Type IsOfType([ValidatedNotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [NotNull]
        public static T IsNotOfType<T>([ValidatedNotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [NotNull]
        public static Type IsNotOfType([ValidatedNotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [NotNull]
        public static T IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);

        [NotNull]
        public static Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);
    }
}