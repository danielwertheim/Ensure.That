using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace EnsureThat
{
    public static class EnsureStringExtensions
    {
        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrWhiteSpace(this Param<string> param, Throws<string>.ExceptionFnConfig exceptionFn = null)
        {
            if (!Ensure.IsActive)
                return param;

            if (string.IsNullOrWhiteSpace(param.Value))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<string>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrEmpty(this Param<string> param, Throws<string>.ExceptionFnConfig exceptionFn = null)
        {
            if (!Ensure.IsActive)
                return param;

            if (string.IsNullOrEmpty(param.Value))
            {
                if (exceptionFn != null)
                    throw exceptionFn(Throws<string>.Instance)(param);

                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);
            }

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> HasLengthBetween(this Param<string> param, int minLength, int maxLength)
        {
            EnsureArg.HasLengthBetween(param.Value, minLength, maxLength, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> Matches(this Param<string> param, string match)
        {
            EnsureArg.Matches(param.Value, match, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> Matches(this Param<string> param, Regex match)
        {
            EnsureArg.Matches(param.Value, match, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> SizeIs(this Param<string> param, int expected)
        {
            EnsureArg.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
            EnsureArg.IsEqualTo(param.Value, expected, comparison, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsNotEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
            EnsureArg.IsNotEqualTo(param.Value, expected, comparison, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsGuid(this Param<string> param)
        {
            EnsureArg.IsGuid(param.Value, param.Name);

            return param;
        }
    }
}
