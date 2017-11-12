using System;
using System.Diagnostics;
using System.Reflection;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static class EnsureTypeExtensions
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
        public static void IsInt(this Param<Type> param) => IsOfType(param, Types.IntType);

        [DebuggerStepThrough]
        public static void IsShort(this Param<Type> param) => IsOfType(param, Types.ShortType);

        [DebuggerStepThrough]
        public static void IsDecimal(this Param<Type> param) => IsOfType(param, Types.DecimalType);

        [DebuggerStepThrough]
        public static void IsDouble(this Param<Type> param) => IsOfType(param, Types.DoubleType);

        [DebuggerStepThrough]
        public static void IsFloat(this Param<Type> param) => IsOfType(param, Types.FloatType);

        [DebuggerStepThrough]
        public static void IsBool(this Param<Type> param) => IsOfType(param, Types.BoolType);

        [DebuggerStepThrough]
        public static void IsDateTime(this Param<Type> param) => IsOfType(param, Types.DateTimeType);

        [DebuggerStepThrough]
        public static void IsString(this Param<Type> param) => IsOfType(param, Types.StringType);

        [DebuggerStepThrough]
        public static void IsOfType(this Param<Type> param, Type type)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value != type)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Types_IsOfType_Failed.Inject(type.FullName, param.Value.FullName));
        }

        [DebuggerStepThrough]
        public static void IsNotOfType(this Param<Type> param, Type type)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value == type)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Types_IsNotOfType_Failed.Inject(type.FullName));
        }

        [DebuggerStepThrough]
        public static void IsClass(this Param<Type> param)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param,
                    ExceptionMessages.Types_IsClass_Failed_Null);

            if (!param.Value.GetTypeInfo().IsClass)
                throw ExceptionFactory.CreateForParamValidation(param,
                    ExceptionMessages.Types_IsClass_Failed.Inject(param.Value.FullName));
        }
    }
}