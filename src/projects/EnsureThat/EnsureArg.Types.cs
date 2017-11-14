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
        public static Type IsInt([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsInt<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsShort([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsShort<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDecimal([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDecimal<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDouble([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDouble<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsFloat([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsFloat<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsBool([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsBool<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsDateTime([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsDateTime<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsString([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsString<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsOfType<T>([NotNull, ValidatedNotNull] T param, Type expectedType, string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsOfType([NotNull, ValidatedNotNull]Type param, Type expectedType, string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsNotOfType<T>([NotNull, ValidatedNotNull]T param, Type nonExpectedType, string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsNotOfType([NotNull, ValidatedNotNull]Type param, Type nonExpectedType, string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static T IsClass<T>([NotNull, ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static Type IsClass([NotNull, ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);
    }
}