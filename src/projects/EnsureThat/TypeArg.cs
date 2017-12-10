using System;
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

        [DebuggerStepThrough]
        public void IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.IntType, paramName);

        [DebuggerStepThrough]
        public void IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.IntType, paramName);

        [DebuggerStepThrough]
        public void IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.ShortType, paramName);

        [DebuggerStepThrough]
        public void IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.ShortType, paramName);

        [DebuggerStepThrough]
        public void IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DecimalType, paramName);

        [DebuggerStepThrough]
        public void IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DecimalType, paramName);

        [DebuggerStepThrough]
        public void IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DoubleType, paramName);

        [DebuggerStepThrough]
        public void IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DoubleType, paramName);

        [DebuggerStepThrough]
        public void IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.FloatType, paramName);

        [DebuggerStepThrough]
        public void IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.FloatType, paramName);

        [DebuggerStepThrough]
        public void IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.BoolType, paramName);

        [DebuggerStepThrough]
        public void IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.BoolType, paramName);

        [DebuggerStepThrough]
        public void IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DateTimeType, paramName);

        [DebuggerStepThrough]
        public void IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.DateTimeType, paramName);

        [DebuggerStepThrough]
        public void IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.StringType, paramName);

        [DebuggerStepThrough]
        public void IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
            => IsOfType(param, Types.StringType, paramName);

        [DebuggerStepThrough]
        public void IsOfType<T>([ValidatedNotNull]T param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(param, paramName);

            IsOfType(param.GetType(), expectedType, paramName);
        }

        [DebuggerStepThrough]
        public void IsOfType([ValidatedNotNull]Type param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(param, paramName);
            Ensure.Any.IsNotNull(expectedType, nameof(expectedType));

            if (param != expectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsOfType_Failed.Inject(expectedType.FullName, param.FullName), paramName);
        }

        [DebuggerStepThrough]
        public void IsNotOfType<T>([ValidatedNotNull]T param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(param, paramName);

            IsNotOfType(param.GetType(), nonExpectedType, paramName);
        }

        [DebuggerStepThrough]
        public void IsNotOfType([ValidatedNotNull]Type param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(param, paramName);
            Ensure.Any.IsNotNull(nonExpectedType, nameof(nonExpectedType));

            if (param == nonExpectedType)
                throw new ArgumentException(ExceptionMessages.Types_IsNotOfType_Failed.Inject(nonExpectedType.FullName), paramName);
        }

        [DebuggerStepThrough]
        public void IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (param == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Types_IsClass_Failed_Null);

            IsClass(param.GetType(), paramName);
        }

        [DebuggerStepThrough]
        public void IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName)
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