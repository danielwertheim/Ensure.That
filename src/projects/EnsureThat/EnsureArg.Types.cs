using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsInt([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsInt(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsShort([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsShort(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDecimal([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDecimal(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDouble([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDouble(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsFloat([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsFloat(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsBool([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsBool(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDateTime([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsDateTime(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsString([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsString(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsOfType([ValidatedNotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsOfType([ValidatedNotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsNotOfType([ValidatedNotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsNotOfType([ValidatedNotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsClass([ValidatedNotNull]object param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Type.IsClass(param, paramName, optsFn);
    }
}