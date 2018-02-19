using System;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public class StringArg : IStringArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public StringArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

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
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        public string IsNotNullOrEmpty([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrEmpty(value))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName, optsFn);

            return value;
        }

        public string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value?.Length == 0)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        public string HasLengthBetween([ValidatedNotNull]string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            var length = value.Length;

            if (length < minLength)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length), paramName, optsFn);

            if (length > maxLength)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length), paramName, optsFn);

            return value;
        }

        [NotNull]
        public string Matches(string value, [RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Matches(value, new Regex(match), paramName, optsFn);

        [NotNull]
        public string Matches(string value, Regex match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!match.IsMatch(value))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_Matches_Failed.Inject(value, match), paramName, optsFn);

            return value;
        }

        [NotNull]
        public string SizeIs([ValidatedNotNull]string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (value.Length != expected)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, value.Length), paramName, optsFn);

            return value;
        }

        public string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        public string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!StringEquals(value, expected, comparison))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        public string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (StringEquals(value, expected))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        public string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (StringEquals(value, expected, comparison))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        public string IsGuid([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Guid.TryParse(value, out _))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Strings_IsGuid_Failed.Inject(value), paramName, optsFn);

            return value;
        }

        private static bool StringEquals(string x, string y, StringComparison comparison) => string.Equals(x, y, comparison);

        private static bool StringEquals(string x, string y) => string.Equals(x, y);
    }
}