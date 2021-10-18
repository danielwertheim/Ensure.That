using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    public static class EnsureThatTypeExtensions
    {
        public static TypeParam IsInt(this in TypeParam param)
        {
            Ensure.Type.IsInt(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsShort(this in TypeParam param)
        {
            Ensure.Type.IsShort(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsDecimal(this in TypeParam param)
        {
            Ensure.Type.IsDecimal(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsDouble(this in TypeParam param)
        {
            Ensure.Type.IsDouble(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsFloat(this in TypeParam param)
        {
            Ensure.Type.IsFloat(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsBool(this in TypeParam param)
        {
            Ensure.Type.IsBool(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsDateTime(this in TypeParam param)
        {
            Ensure.Type.IsDateTime(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsString(this in TypeParam param)
        {
            Ensure.Type.IsString(param.Type, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsOfType(this in TypeParam param, [NotNull] Type expectedType)
        {
            Ensure.Type.IsOfType(param.Type, expectedType, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsNotOfType(this in TypeParam param, Type expectedType)
        {
            Ensure.Type.IsNotOfType(param.Type, expectedType, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsAssignableToType(this in TypeParam param, [NotNull] Type expectedType)
        {
            Ensure.Type.IsAssignableToType(param.Type, expectedType, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsNotAssignableToType(this in TypeParam param, Type expectedType)
        {
            Ensure.Type.IsNotAssignableToType(param.Type, expectedType, param.Name, param.OptsFn);

            return param;
        }

        public static Param<T> IsClass<T>(this in Param<T> param)
        {
            Ensure.Type.IsClass(param.Value, param.Name, param.OptsFn);

            return param;
        }

        public static TypeParam IsClass(this in TypeParam param)
        {
            Ensure.Type.IsClass(param.Type, param.Name, param.OptsFn);

            return param;
        }
    }
}
