using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class StringArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public string IsNotNullOrWhiteSpace([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrWhiteSpace(value))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public string IsNotNullOrEmpty([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (string.IsNullOrEmpty(value))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (value?.Length == 0)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName, optsFn);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public string HasLengthBetween([ValidatedNotNull]string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName, optsFn);

            var length = value.Length;

            if (length < minLength)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length), paramName, optsFn);

            if (length > maxLength)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length), paramName, optsFn);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public string Matches([NotNull] string value, [NotNull, RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Matches(value, new Regex(match), paramName, optsFn);

        [NotNull]
        [DebuggerStepThrough]
        public string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (!match.IsMatch(value))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_Matches_Failed.Inject(value, match), paramName, optsFn);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public string SizeIs([ValidatedNotNull]string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName, optsFn);

            if (value.Length != expected)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, value.Length), paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        public string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (!StringEquals(value, expected))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        public string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (!StringEquals(value, expected, comparison))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (StringEquals(value, expected))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (StringEquals(value, expected, comparison))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName, optsFn);

            return value;
        }

        [NotNull]
        [DebuggerStepThrough]
        public string IsGuid([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (!Guid.TryParse(value, out _))
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Strings_IsGuid_Failed.Inject(value), paramName, optsFn);

            return value;
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null) => comparison.HasValue
            ? string.Equals(x, y, comparison.Value)
            : string.Equals(x, y);
    }
}