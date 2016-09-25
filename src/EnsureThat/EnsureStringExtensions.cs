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
            if (string.IsNullOrEmpty(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);

            var length = param.Value.Length;

            if (length < minLength)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToShort.Inject(minLength, maxLength, length));

            if (length > maxLength)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLong.Inject(minLength, maxLength, length));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> Matches(this Param<string> param, string match)
        {
            return Matches(param, new Regex(match));
        }

        [DebuggerStepThrough]
        public static Param<string> Matches(this Param<string> param, Regex match)
        {
            if (!match.IsMatch(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_NoMatch.Inject(param.Value, match));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> SizeIs(this Param<string> param, int expected)
        {
            if (param.Value.Length != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_SizeIs_Wrong.Inject(expected, param.Value.Length));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
           if (!StringEquals(param.Value, expected, comparison))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_Is_Failed.Inject(param.Value, expected));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsNotEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
            if (StringEquals(param.Value, expected, comparison))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNot_Failed.Inject(param.Value, expected));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsGuid(this Param<string> param)
        {
            Guid guid;
            if (!Guid.TryParse(param.Value, out guid))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGuid.Inject(param.Value));

            return param;
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null)
        {
            return comparison.HasValue
                ? string.Equals(x, y, comparison.Value)
                : string.Equals(x, y);
        }
    }
}
