using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void IsNotNullOrWhiteSpace([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName);

        [DebuggerStepThrough]
        public static void IsNotNullOrEmpty([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrEmpty(value, paramName);

        [DebuggerStepThrough]
        public static void IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEmpty(value, paramName);

        [DebuggerStepThrough]
        public static void HasLengthBetween([ValidatedNotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName);

        [DebuggerStepThrough]
        public static void Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [DebuggerStepThrough]
        public static void Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [DebuggerStepThrough]
        public static void SizeIs([ValidatedNotNull] string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static void IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsEqualTo(value, expected, paramName);

        [DebuggerStepThrough]
        public static void IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsEqualTo(value, expected, comparison, paramName);

        [DebuggerStepThrough]
        public static void IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEqualTo(value, expected, paramName);

        [DebuggerStepThrough]
        public static void IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEqualTo(value, expected, comparison, paramName);

        [DebuggerStepThrough]
        public static void IsGuid([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsGuid(value, paramName);
    }
}