using System;
using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [DebuggerStepThrough]
        public static void IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsInt(param, paramName);

        [DebuggerStepThrough]
        public static void IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [DebuggerStepThrough]
        public static void IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsShort(param, paramName);

        [DebuggerStepThrough]
        public static void IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [DebuggerStepThrough]
        public static void IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDecimal(param, paramName);

        [DebuggerStepThrough]
        public static void IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [DebuggerStepThrough]
        public static void IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDouble(param, paramName);

        [DebuggerStepThrough]
        public static void IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [DebuggerStepThrough]
        public static void IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsFloat(param, paramName);

        [DebuggerStepThrough]
        public static void IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [DebuggerStepThrough]
        public static void IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsBool(param, paramName);

        [DebuggerStepThrough]
        public static void IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [DebuggerStepThrough]
        public static void IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsDateTime(param, paramName);

        [DebuggerStepThrough]
        public static void IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [DebuggerStepThrough]
        public static void IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsString(param, paramName);

        [DebuggerStepThrough]
        public static void IsOfType<T>([ValidatedNotNull] T param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [DebuggerStepThrough]
        public static void IsOfType([ValidatedNotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [DebuggerStepThrough]
        public static void IsNotOfType<T>([ValidatedNotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [DebuggerStepThrough]
        public static void IsNotOfType([ValidatedNotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [DebuggerStepThrough]
        public static void IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);

        [DebuggerStepThrough]
        public static void IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Type.IsClass(param, paramName);
    }
}