using System;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        public static string IsNotNullOrWhiteSpace([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName, optsFn);

        [NotNull]
        public static string IsNotNullOrEmpty([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrEmpty(value, paramName, optsFn);

        public static string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsNotEmpty(value, paramName, optsFn);

        [NotNull]
        public static string HasLengthBetween([ValidatedNotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName, optsFn);

        [NotNull]
        public static string Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [NotNull]
        public static string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [NotNull]
        public static string SizeIs([ValidatedNotNull] string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.SizeIs(value, expected, paramName, optsFn);

        public static string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsEqualTo(value, expected, paramName, optsFn);

        public static string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsEqualTo(value, expected, comparison, paramName, optsFn);

        public static string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsNotEqualTo(value, expected, paramName, optsFn);

        public static string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsNotEqualTo(value, expected, comparison, paramName, optsFn);

        [NotNull]
        public static string IsGuid([ValidatedNotNull] string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
            => Ensure.String.IsGuid(value, paramName, optsFn);

        [NotNull]
        public static string StartsWith([ValidatedNotNull] string value, [NotNull] string expectedStartsWith, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, paramName, optsFn);

        [NotNull]
        public static string StartsWith([ValidatedNotNull] string value, [NotNull] string expectedStartsWith, StringComparison comparisonType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, comparisonType, paramName, optsFn);
    }
}