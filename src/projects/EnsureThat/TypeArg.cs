﻿using System;
using System.Diagnostics;
using System.Reflection;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class TypeArg
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

        [NotNull]
        [DebuggerStepThrough]
        public Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.IntType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.IntType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.ShortType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.ShortType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DecimalType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DecimalType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DoubleType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DoubleType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.FloatType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.FloatType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.BoolType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.BoolType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DateTimeType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.DateTimeType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.StringType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName) => IsOfType(param, Types.StringType, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public T IsOfType<T>([ValidatedNotNull]T param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            Ensure.Any.IsNotNull(param, paramName);

            IsOfType(param.GetType(), expectedType, paramName);

            return param;
        }

        [NotNull]
        [DebuggerStepThrough]
        public Type IsOfType([ValidatedNotNull]Type param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            Ensure.Any.IsNotNull(param, paramName);
            Ensure.Any.IsNotNull(expectedType, nameof(expectedType));

            if (param != expectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsOfType_Failed.Inject(expectedType.FullName, param.FullName), paramName);

            return param;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsNotOfType<T>([ValidatedNotNull]T param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            Ensure.Any.IsNotNull(param, paramName);

            IsNotOfType(param.GetType(), nonExpectedType, paramName);

            return param;
        }

        [NotNull]
        [DebuggerStepThrough]
        public Type IsNotOfType([ValidatedNotNull]Type param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            Ensure.Any.IsNotNull(param, paramName);
            Ensure.Any.IsNotNull(nonExpectedType, nameof(nonExpectedType));

            if (param == nonExpectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsNotOfType_Failed.Inject(nonExpectedType.FullName), paramName);

            return param;
        }

        [NotNull]
        [DebuggerStepThrough]
        public T IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            if (param == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Types_IsClass_Failed_Null);

            IsClass(param.GetType(), paramName);

            return param;
        }

        [NotNull]
        [DebuggerStepThrough]
        public Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return param;

            if (param == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Types_IsClass_Failed_Null);

            if (!param.GetTypeInfo().IsClass)
                throw new ArgumentException(ExceptionMessages.Types_IsClass_Failed.Inject(param.FullName), paramName);

            return param;
        }
    }
}