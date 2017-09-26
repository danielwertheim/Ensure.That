using System;
using System.Diagnostics;
using System.Reflection;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        private static class Types
        {
            internal static readonly Type IntType = typeof(int);

            internal static readonly Type ShortType = typeof(short);

            internal static readonly Type DecimalType = typeof(decimal);

            internal static readonly Type DoubleType = typeof(double);

            internal static readonly Type FloatType = typeof(float);

            internal static readonly Type BoolType = typeof(bool);

            internal static readonly Type DateTimeType = typeof(DateTime);

            internal static readonly Type StringType = typeof(string);
        }

        [DebuggerStepThrough]
        public static void IsInt([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.IntType, paramName);

        [DebuggerStepThrough]
        public static void IsInt<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.IntType, paramName);

        [DebuggerStepThrough]
        public static void IsShort([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.ShortType, paramName);

        [DebuggerStepThrough]
        public static void IsShort<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.ShortType, paramName);

        [DebuggerStepThrough]
        public static void IsDecimal([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.DecimalType, paramName);

        [DebuggerStepThrough]
        public static void IsDecimal<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.DecimalType, paramName);

        [DebuggerStepThrough]
        public static void IsDouble([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.DoubleType, paramName);

        [DebuggerStepThrough]
        public static void IsDouble<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.DoubleType, paramName);

        [DebuggerStepThrough]
        public static void IsFloat([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.FloatType, paramName);

        [DebuggerStepThrough]
        public static void IsFloat<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.FloatType, paramName);

        [DebuggerStepThrough]
        public static void IsBool([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.BoolType, paramName);

        [DebuggerStepThrough]
        public static void IsBool<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.BoolType, paramName);

        [DebuggerStepThrough]
        public static void IsDateTime([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.DateTimeType, paramName);

        [DebuggerStepThrough]
        public static void IsDateTime<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.DateTimeType, paramName);

        [DebuggerStepThrough]
        public static void IsString([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName) => IsOfType(param, Types.StringType, paramName);

        [DebuggerStepThrough]
        public static void IsString<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName) => IsOfType(param, Types.StringType, paramName);

        [DebuggerStepThrough]
        public static void IsOfType<T>([NotNull, ValidatedNotNull]T param, Type expectedType, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(param, paramName);

            IsOfType(param.GetType(), expectedType, paramName);
        }

        [DebuggerStepThrough]
        public static void IsOfType([NotNull, ValidatedNotNull]Type param, Type expectedType, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(param, paramName);
            IsNotNull(expectedType, nameof(expectedType));

            if (param != expectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsOfType_Failed.Inject(expectedType.FullName, param.FullName), paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotOfType<T>([NotNull, ValidatedNotNull]T param, Type nonExpectedType, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(param, paramName);

            IsNotOfType(param.GetType(), nonExpectedType, paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotOfType([NotNull, ValidatedNotNull]Type param, Type nonExpectedType, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(param, paramName);
            IsNotNull(nonExpectedType, nameof(nonExpectedType));

            if (param == nonExpectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsNotOfType_Failed.Inject(nonExpectedType.FullName), paramName);
        }

        [DebuggerStepThrough]
        public static void IsClass<T>([NotNull, ValidatedNotNull]T param, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (param == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Types_IsClass_Failed_Null);

            IsClass(param.GetType(), paramName);
        }

        [DebuggerStepThrough]
        public static void IsClass([NotNull, ValidatedNotNull]Type param, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (param == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Types_IsClass_Failed_Null);

            if (!param.GetTypeInfo().IsClass)
                throw new ArgumentException(ExceptionMessages.Types_IsClass_Failed.Inject(param.FullName), paramName);
        }
    }
}