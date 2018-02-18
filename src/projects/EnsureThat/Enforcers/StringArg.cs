using System;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class StringArg
    {
        [NotNull]
        public string IsNotNull([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            return value;
        }

        [NotNull]
        public string IsNotNullOrWhiteSpace([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrWhiteSpace(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        public string IsNotNullOrEmpty([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrEmpty(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName, optsFn);

            return value;
        }

        public string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value?.Length == 0)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        public string HasLengthBetween([ValidatedNotNull]string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            var length = value.Length;

            if (length < minLength)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort, minLength, maxLength, length),
                    paramName,
                    optsFn);

            if (length > maxLength)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong, minLength, maxLength, length),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public string Matches(string value, [RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Matches(value, new Regex(match), paramName, optsFn);

        [NotNull]
        public string Matches(string value, Regex match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!match.IsMatch(value))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_Matches_Failed, value, match),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public string SizeIs([ValidatedNotNull]string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_SizeIs_Failed, expected, value.Length),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected, comparison))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (StringEquals(value, expected))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsNotEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        public string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (StringEquals(value, expected, comparison))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsNotEqualTo_Failed, value, expected),
                    paramName,
                    optsFn);

            return value;
        }

        [NotNull]
        public string IsGuid([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Guid.TryParse(value, out _))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Strings_IsGuid_Failed, value),
                    paramName,
                    optsFn);

            return value;
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null) => comparison.HasValue
            ? string.Equals(x, y, comparison.Value)
            : string.Equals(x, y);
    }
}