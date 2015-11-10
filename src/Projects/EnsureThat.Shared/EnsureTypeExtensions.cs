using System;
using System.Diagnostics;
using System.Reflection;

namespace EnsureThat
{
    public static class EnsureTypeExtensions
    {
        private static class Types
        {
            internal static readonly Type IntType = typeof (int);

            internal static readonly Type ShortType = typeof(short);

            internal static readonly Type DecimalType = typeof(decimal);

            internal static readonly Type DoubleType = typeof(double);

            internal static readonly Type FloatType = typeof(float);

            internal static readonly Type BoolType = typeof(bool);

            internal static readonly Type DateTimeType = typeof(DateTime);

            internal static readonly Type StringType = typeof(string);
        }

        [DebuggerStepThrough]
        public static TypeParam IsInt(this TypeParam param)
        {
            return IsOfType(param, Types.IntType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsShort(this TypeParam param)
        {
            return IsOfType(param, Types.ShortType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsDecimal(this TypeParam param)
        {
            return IsOfType(param, Types.DecimalType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsDouble(this TypeParam param)
        {
            return IsOfType(param, Types.DoubleType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsFloat(this TypeParam param)
        {
            return IsOfType(param, Types.FloatType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsBool(this TypeParam param)
        {
            return IsOfType(param, Types.BoolType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsDateTime(this TypeParam param)
        {
            return IsOfType(param, Types.DateTimeType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsString(this TypeParam param)
        {
            return IsOfType(param, Types.StringType);
        }

        [DebuggerStepThrough]
        public static TypeParam IsOfType(this TypeParam param, Type type)
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Type != type)
                throw ExceptionFactory.CreateForParamValidation(param,
                    ExceptionMessages.EnsureExtensions_IsNotOfType.Inject(param.Type.FullName));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<Type> IsClass(this Param<Type> param)
        {
            if (!Ensure.IsActive)
                return param;

            if (param.Value == null)
                throw ExceptionFactory.CreateForParamValidation(param,
                    ExceptionMessages.EnsureExtensions_IsNotClass_WasNull);

#if vDinasour
            if (!param.Value.IsClass)
                throw ExceptionFactory.CreateForParamValidation(param,
                    ExceptionMessages.EnsureExtensions_IsNotClass.Inject(param.Value.FullName));
#elif vNext
            if (!param.Value.GetTypeInfo().IsClass)
                throw ExceptionFactory.CreateForParamValidation(param,
                    ExceptionMessages.EnsureExtensions_IsNotClass.Inject(param.Value.FullName));
#else
            throw new NotSupportedException("Hmm. Looks like I don't support this framework of yours.");
#endif

            return param;
        }
    }
}