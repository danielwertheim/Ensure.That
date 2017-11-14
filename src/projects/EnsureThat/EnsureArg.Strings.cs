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
        public static string IsNotNullOrWhiteSpace([NotNull, ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName);

        [DebuggerStepThrough]
        public static string IsNotNullOrEmpty([NotNull, ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotNullOrEmpty(value, paramName);

        [DebuggerStepThrough]
        public static string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsNotEmpty(value, paramName);

        [DebuggerStepThrough]
        public static string HasLengthBetween([NotNull, ValidatedNotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName);

        [DebuggerStepThrough]
        public static string Matches(string value, string match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [DebuggerStepThrough]
        public static string Matches(string value, Regex match, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.Matches(value, match, paramName);

        [DebuggerStepThrough]
        public static string SizeIs([NotNull, ValidatedNotNull] string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName)
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

        [DebuggerStepThrough]
        public static string IsGuid([NotNull, ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.String.IsGuid(value, paramName);
    }
}