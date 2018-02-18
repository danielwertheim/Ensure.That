using System;
using System.Reflection;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class TypeArg
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
        public Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.IntType, paramName, optsFn);

        [NotNull]
        public T IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.IntType, paramName, optsFn);

        [NotNull]
        public Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.ShortType, paramName, optsFn);

        [NotNull]
        public T IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.ShortType, paramName, optsFn);

        [NotNull]
        public Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DecimalType, paramName, optsFn);

        [NotNull]
        public T IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DecimalType, paramName, optsFn);

        [NotNull]
        public Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DoubleType, paramName, optsFn);

        [NotNull]
        public T IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DoubleType, paramName, optsFn);

        [NotNull]
        public Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.FloatType, paramName, optsFn);

        [NotNull]
        public T IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.FloatType, paramName, optsFn);

        [NotNull]
        public Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.BoolType, paramName, optsFn);

        [NotNull]
        public T IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.BoolType, paramName, optsFn);

        [NotNull]
        public Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DateTimeType, paramName, optsFn);

        [NotNull]
        public T IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.DateTimeType, paramName, optsFn);

        [NotNull]
        public Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.StringType, paramName, optsFn);

        [NotNull]
        public T IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => IsOfType(param, Types.StringType, paramName, optsFn);

        [NotNull]
        public T IsOfType<T>([ValidatedNotNull]T param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsOfType(param.GetType(), expectedType, paramName, optsFn);

            return param;
        }

        [NotNull]
        public Type IsOfType([ValidatedNotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);
            Ensure.Any.IsNotNull(expectedType, nameof(expectedType));

            if (param != expectedType)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Types_IsOfType_Failed, expectedType.FullName, param.FullName),
                    paramName,
                    optsFn);

            return param;
        }

        [NotNull]
        public T IsNotOfType<T>([ValidatedNotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsNotOfType(param.GetType(), nonExpectedType, paramName, optsFn);

            return param;
        }

        [NotNull]
        public Type IsNotOfType([ValidatedNotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);
            Ensure.Any.IsNotNull(nonExpectedType, nameof(nonExpectedType));

            if (param == nonExpectedType)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Types_IsNotOfType_Failed, nonExpectedType.FullName),
                    paramName,
                    optsFn);

            return param;
        }

        [NotNull]
        public T IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (param == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(
                    ExceptionMessages.Types_IsClass_Failed_Null,
                    paramName,
                    optsFn);

            IsClass(param.GetType(), paramName, optsFn);

            return param;
        }

        [NotNull]
        public Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (param == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(
                    ExceptionMessages.Types_IsClass_Failed_Null,
                    paramName,
                    optsFn);

            if (!param.GetTypeInfo().IsClass)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Types_IsClass_Failed, param.FullName),
                    paramName,
                    optsFn);

            return param;
        }
    }
}