using System;
using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public static Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsOfType<T>([ValidatedNotNull] T param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsOfType([ValidatedNotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsNotOfType<T>([ValidatedNotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsNotOfType([ValidatedNotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);
    }
}