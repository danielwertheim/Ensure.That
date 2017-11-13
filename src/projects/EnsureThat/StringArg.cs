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
        [DebuggerStepThrough]
        public string IsNotNullOrWhiteSpace([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotNullOrEmpty([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEmpty(string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;
            
            // !null && (null || empty) == !null && empty
            if (value != null && string.IsNullOrEmpty(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string HasLengthBetween([NotNull, ValidatedNotNull]string value, int minLength, int maxLength, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            var length = value.Length;

            if (length < minLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length), paramName);

            if (length > maxLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string Matches(string value, string match, string paramName = Param.DefaultName)
            => Matches(value, new Regex(match), paramName);

        [DebuggerStepThrough]
        public string Matches(string value, Regex match, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!match.IsMatch(value))
                throw new ArgumentException(ExceptionMessages.Strings_Matches_Failed.Inject(value, match), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string SizeIs([NotNull, ValidatedNotNull]string value, int expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, value.Length), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsEqualTo(string value, string expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEqualTo(string value, string expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsNotEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);

            return value;
        }

        [DebuggerStepThrough]
        public string IsGuid([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!Guid.TryParse(value, out _))
                throw new ArgumentException(ExceptionMessages.Strings_IsGuid_Failed.Inject(value), paramName);

            return value;
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null) => comparison.HasValue
            ? string.Equals(x, y, comparison.Value)
            : string.Equals(x, y);
    }
}