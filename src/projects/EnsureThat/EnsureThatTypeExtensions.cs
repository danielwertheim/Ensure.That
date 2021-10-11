using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    public static class EnsureThatTypeExtensions
    {
        public static void IsInt(this in TypeParam param)
            => Ensure.Type.IsInt(param.Type, param.Name, param.OptsFn);

        public static void IsShort(this in TypeParam param)
            => Ensure.Type.IsShort(param.Type, param.Name, param.OptsFn);

        public static void IsDecimal(this in TypeParam param)
            => Ensure.Type.IsDecimal(param.Type, param.Name, param.OptsFn);

        public static void IsDouble(this in TypeParam param)
            => Ensure.Type.IsDouble(param.Type, param.Name, param.OptsFn);

        public static void IsFloat(this in TypeParam param)
            => Ensure.Type.IsFloat(param.Type, param.Name, param.OptsFn);

        public static void IsBool(this in TypeParam param)
            => Ensure.Type.IsBool(param.Type, param.Name, param.OptsFn);

        public static void IsDateTime(this in TypeParam param)
            => Ensure.Type.IsDateTime(param.Type, param.Name, param.OptsFn);

        public static void IsString(this in TypeParam param)
            => Ensure.Type.IsString(param.Type, param.Name, param.OptsFn);

        public static void IsOfType(this in TypeParam param, [NotNull] Type expectedType)
            => Ensure.Type.IsOfType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsNotOfType(this in TypeParam param, Type expectedType)
            => Ensure.Type.IsNotOfType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsAssignableToType(this in TypeParam param, [NotNull] Type expectedType)
	        => Ensure.Type.IsAssignableToType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsNotAssignableToType(this in TypeParam param, Type expectedType)
	        => Ensure.Type.IsNotAssignableToType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsClass<T>(this in Param<T> param)
            => Ensure.Type.IsClass(param.Value, param.Name, param.OptsFn);

        public static void IsClass(this in TypeParam param)
            => Ensure.Type.IsClass(param.Type, param.Name, param.OptsFn);
    }
}
