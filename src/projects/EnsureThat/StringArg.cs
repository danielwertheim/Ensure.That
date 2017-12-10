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
        public void IsNotNullOrWhiteSpace([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(value, paramName);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrWhiteSpace_Failed, paramName);
        }

        [DebuggerStepThrough]
        public void IsNotNullOrEmpty([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(value, paramName);

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotNullOrEmpty_Failed, paramName);
        }

        [DebuggerStepThrough]
        public void IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (value?.Length == 0)
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEmpty_Failed, paramName);
        }

        [DebuggerStepThrough]
        public void HasLengthBetween([ValidatedNotNull]string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(value, paramName);

            var length = value.Length;

            if (length < minLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToShort.Inject(minLength, maxLength, length), paramName);

            if (length > maxLength)
                throw new ArgumentException(ExceptionMessages.Strings_HasLengthBetween_Failed_ToLong.Inject(minLength, maxLength, length), paramName);
        }

        [DebuggerStepThrough]
        public void Matches([NotNull] string value, [NotNull, RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Matches(value, new Regex(match), paramName);

        [DebuggerStepThrough]
        public void Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!match.IsMatch(value))
                throw new ArgumentException(ExceptionMessages.Strings_Matches_Failed.Inject(value, match), paramName);
        }

        [DebuggerStepThrough]
        public void SizeIs([ValidatedNotNull]string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw new ArgumentException(ExceptionMessages.Strings_SizeIs_Failed.Inject(expected, value.Length), paramName);
        }

        [DebuggerStepThrough]
        public void IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public void IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public void IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (StringEquals(value, expected))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public void IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (StringEquals(value, expected, comparison))
                throw new ArgumentException(ExceptionMessages.Strings_IsNotEqualTo_Failed.Inject(value, expected), paramName);
        }

        [DebuggerStepThrough]
        public void IsGuid([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName)
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