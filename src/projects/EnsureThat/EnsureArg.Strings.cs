using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [DebuggerStepThrough]
        public static string IsNotNullOrWhiteSpace([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string IsNotNullOrEmpty([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrEmpty(value, paramName);

        [DebuggerStepThrough]
        public static string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEmpty(value, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string HasLengthBetween([ValidatedNotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string SizeIs([ValidatedNotNull] string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.SizeIs(value, expected, paramName);

        [DebuggerStepThrough]
        public static string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsEqualTo(value, expected, paramName);

        [DebuggerStepThrough]
        public static string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsEqualTo(value, expected, comparison, paramName);

        [DebuggerStepThrough]
        public static string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEqualTo(value, expected, paramName);

        [DebuggerStepThrough]
        public static string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEqualTo(value, expected, comparison, paramName);

        [NotNull]
        [DebuggerStepThrough]
        public static string IsGuid([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsGuid(value, paramName);
    }
}