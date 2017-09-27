using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using EnsureThat.Extensions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsNotNullOrWhiteSpace([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotNullOrEmpty([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotEmpty(string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (string.Empty.Equals(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName);
        }

        [DebuggerStepThrough]
        public static void HasLengthBetween([NotNull, ValidatedNotNull]string value, int minLength, int maxLength, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            var length = value.Length;

            if (length < minLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length), paramName);

            if (length > maxLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length), paramName);
        }

        [DebuggerStepThrough]
        public static void Matches([NotNull, ValidatedNotNull]string value, string match, string paramName = Param.DefaultName)
            => Matches(value, new Regex(match), paramName);

        [DebuggerStepThrough]
        public static void Matches([NotNull, ValidatedNotNull]string value, Regex match, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (!match.IsMatch(value))
                throw new ArgumentException(ExceptionMessages.Strings_Matches_Failed.Inject(value, match), paramName);
        }

        [DebuggerStepThrough]
        public static void SizeIs([NotNull, ValidatedNotNull]string value, int expected, string paramName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, value.Length), paramName);
        }

        [DebuggerStepThrough]
        public static void IsEqualTo(string value, string expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotEqualTo(string value, string expected, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsNotEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public static void IsGuid([NotNull, ValidatedNotNull]string value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!Guid.TryParse(value, out _))
                throw new ArgumentException(ExceptionMessages.Strings_IsGuid_Failed.Inject(value), paramName);
        }

        private static bool StringEquals(string x, string y, StringComparison? comparison = null) => comparison.HasValue
            ? string.Equals(x, y, comparison.Value)
            : string.Equals(x, y);
    }
}