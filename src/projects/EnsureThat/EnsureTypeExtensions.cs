using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class EnsureTypeExtensions
    {
        public static void IsInt(this TypeParam param)
            => Ensure.Type.IsInt(param.Type, param.Name, param.OptsFn);

        public static void IsShort(this TypeParam param)
            => Ensure.Type.IsShort(param.Type, param.Name, param.OptsFn);

        public static void IsDecimal(this TypeParam param)
            => Ensure.Type.IsDecimal(param.Type, param.Name, param.OptsFn);

        public static void IsDouble(this TypeParam param)
            => Ensure.Type.IsDouble(param.Type, param.Name, param.OptsFn);

        public static void IsFloat(this TypeParam param)
            => Ensure.Type.IsFloat(param.Type, param.Name, param.OptsFn);

        public static void IsBool(this TypeParam param)
            => Ensure.Type.IsBool(param.Type, param.Name, param.OptsFn);

        public static void IsDateTime(this TypeParam param)
            => Ensure.Type.IsDateTime(param.Type, param.Name, param.OptsFn);

        public static void IsString(this TypeParam param)
            => Ensure.Type.IsString(param.Type, param.Name, param.OptsFn);

        public static void IsOfType(this TypeParam param, [NotNull] Type expectedType)
            => Ensure.Type.IsOfType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsNotOfType(this TypeParam param, Type expectedType)
            => Ensure.Type.IsNotOfType(param.Type, expectedType, param.Name, param.OptsFn);

        public static void IsClass<T>(this Param<T> param)
            => Ensure.Type.IsClass(param.Value, param.Name, param.OptsFn);

        public static void IsClass(this TypeParam param)
            => Ensure.Type.IsClass(param.Type, param.Name, param.OptsFn);
    }
}