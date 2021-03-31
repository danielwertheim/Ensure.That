using System;
using System.Reflection;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

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

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsInt([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.IntType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsInt([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.IntType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsShort([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.ShortType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsShort([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.ShortType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsDecimal([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DecimalType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsDecimal([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DecimalType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsDouble([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DoubleType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsDouble([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DoubleType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsFloat([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.FloatType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsFloat([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.FloatType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsBool([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.BoolType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsBool([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.BoolType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsDateTime([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DateTimeType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsDateTime([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.DateTimeType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsString([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.StringType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public object IsString([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => IsOfType(param, Types.StringType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public T IsOfType<T>([ValidatedNotNull, NotNull]T param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsOfType(param.GetType(), expectedType, paramName, optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsOfType([ValidatedNotNull, NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public T IsNotOfType<T>([ValidatedNotNull, NotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsNotOfType(param.GetType(), nonExpectedType, paramName, optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsNotOfType([ValidatedNotNull, NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public T IsAssignableToType<T>([ValidatedNotNull, NotNull]T param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsAssignableToType(param.GetType(), expectedType, paramName, optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsAssignableToType([ValidatedNotNull, NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);
            Ensure.Any.IsNotNull(expectedType, nameof(expectedType));

#if NETSTANDARD1_1
	        // According to: https://devblogs.microsoft.com/dotnet/porting-to-net-core/.
	        if (!expectedType.GetTypeInfo().IsAssignableFrom(param.GetTypeInfo()))
#else
            if (!expectedType.IsAssignableFrom(param))
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Types_IsAssignableToType_Failed, expectedType.FullName, param.FullName),
                    paramName,
                    optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public T IsNotAssignableToType<T>([ValidatedNotNull, NotNull]T param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);

            IsNotAssignableToType(param.GetType(), nonExpectedType, paramName, optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsNotAssignableToType([ValidatedNotNull, NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(param, paramName, optsFn);
            Ensure.Any.IsNotNull(nonExpectedType, nameof(nonExpectedType));

#if NETSTANDARD1_1
            // According to: https://devblogs.microsoft.com/dotnet/porting-to-net-core/.
	        if (nonExpectedType.GetTypeInfo().IsAssignableFrom(param.GetTypeInfo()))
#else
            if (nonExpectedType.IsAssignableFrom(param))
#endif
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Types_IsNotAssignableToType_Failed, nonExpectedType.FullName),
                    paramName,
                    optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public T IsClass<T>([ValidatedNotNull, NotNull]T param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (param == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(
                    ExceptionMessages.Types_IsClass_Failed_Null,
                    paramName,
                    optsFn);

            IsClass(param.GetType(), paramName, optsFn);

            return param;
        }

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public Type IsClass([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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
