using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsInt([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsInt([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsShort([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsShort([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDecimal([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDecimal([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDouble([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDouble([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsFloat([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsFloat([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsBool([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsBool([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDateTime([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDateTime([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsString([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsString([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsOfType([ValidatedNotNull, NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsOfType([ValidatedNotNull, NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsNotOfType([ValidatedNotNull, NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsNotOfType([ValidatedNotNull, NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsAssignableToType([ValidatedNotNull, NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
	        => Ensure.Type.IsAssignableToType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsAssignableToType([ValidatedNotNull, NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
	        => Ensure.Type.IsAssignableToType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsNotAssignableToType([ValidatedNotNull, NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
	        => Ensure.Type.IsNotAssignableToType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsNotAssignableToType([ValidatedNotNull, NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
	        => Ensure.Type.IsNotAssignableToType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsClass([ValidatedNotNull, NotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsClass([ValidatedNotNull, NotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);
    }
}
