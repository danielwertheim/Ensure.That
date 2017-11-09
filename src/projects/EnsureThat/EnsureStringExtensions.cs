using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Extensions;

namespace EnsureThat
{
    public static class EnsureStringExtensions
    {
        [DebuggerStepThrough]
        public static void IsNotNullOrWhiteSpace(this Param<string> param)
        {
            if (!Ensure.IsActive)
                return;

            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.Common_IsNotNull_Failed);

            if (string.IsNullOrWhiteSpace(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed);
        }

        [DebuggerStepThrough]
        public static void IsNotNullOrEmpty(this Param<string> param)
        {
            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.Common_IsNotNull_Failed);

            if (string.IsNullOrEmpty(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsNotNullOrEmpty_Failed);
        }

        [DebuggerStepThrough]
        public static void IsNotEmpty(this Param<string> param)
        {
            if (string.Empty.Equals(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsNotEmpty_Failed);
        }

        [DebuggerStepThrough]
        public static void HasLengthBetween(this Param<string> param, int minLength, int maxLength)
        {
            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.Common_IsNotNull_Failed);

            var length = param.Value.Length;

            if (length < minLength)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length));

            if (length > maxLength)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length));
        }

        [DebuggerStepThrough]
        public static void Matches(this Param<string> param, string match) => Matches(param, new Regex(match));

        [DebuggerStepThrough]
        public static void Matches(this Param<string> param, Regex match)
        {
            if (!match.IsMatch(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_Matches_Failed.Inject(param.Value, match));
        }

        [DebuggerStepThrough]
        public static void SizeIs(this Param<string> param, int expected)
        {
            if (param.Value == null)
                throw ExceptionFactory.CreateForParamNullValidation(param, ExceptionMessages.Common_IsNotNull_Failed);

            if (param.Value.Length != expected)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, param.Value.Length));
        }

        [DebuggerStepThrough]
        public static void IsEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
            if (!StringEquals(param.Value, expected, comparison))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsEqualTo_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void IsNotEqualTo(this Param<string> param, string expected, StringComparison? comparison = null)
        {
            if (StringEquals(param.Value, expected, comparison))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(param.Value, expected));
        }

        [DebuggerStepThrough]
        public static void IsGuid(this Param<string> param)
        {
            if (!Guid.TryParse(param.Value, out _))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.Strings_IsGuid_Failed.Inject(param.Value));
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null) => comparison.HasValue
            ? string.Equals(x, y, comparison.Value)
            : string.Equals(x, y);
    }
}
