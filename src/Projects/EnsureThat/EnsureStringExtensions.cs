using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureStringExtensions
    {
        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrWhiteSpace(this Param<string> param)
        {
            if (string.IsNullOrWhiteSpace(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotNullOrWhiteSpace);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<string> IsNotNullOrEmpty(this Param<string> param)
        {
            if (string.IsNullOrEmpty(param.Value))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotNullOrEmpty);

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
            {
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_NoMatch.Inject(param.Value, match));
            }
            return param;
        }
    }
}
