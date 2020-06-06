using System;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNull([ValidatedNotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNull(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrWhiteSpace([ValidatedNotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrEmpty([ValidatedNotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrEmpty(value, paramName, optsFn);

        public static string IsNotEmptyOrWhiteSpace(string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEmptyOrWhiteSpace(value, paramName, optsFn);

        public static string IsNotEmpty(string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEmpty(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string HasLengthBetween([ValidatedNotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName, optsFn);

        [NotNull]
        public static string Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [NotNull]
        public static string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string SizeIs([ValidatedNotNull] string value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.SizeIs(value, expected, paramName, optsFn);

        public static string Is(string value, string expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Is(value, expected, paramName, optsFn);

        public static string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsEqualTo(value, expected, paramName, optsFn);

        public static string Is(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Is(value, expected, comparison, paramName, optsFn);

        public static string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsEqualTo(value, expected, comparison, paramName, optsFn);

        public static string IsNot(string value, string notExpected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNot(value, notExpected, paramName, optsFn);

        public static string IsNotEqualTo(string value, string notExpected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEqualTo(value, notExpected, paramName, optsFn);

        public static string IsNot(string value, string notExpected, StringComparison comparison, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNot(value, notExpected, comparison, paramName, optsFn);

        public static string IsNotEqualTo(string value, string notExpected, StringComparison comparison, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEqualTo(value, notExpected, comparison, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsGuid([ValidatedNotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsGuid(value, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull] string value, [NotNull] string expectedStartsWith, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull] string value, [NotNull] string expectedStartsWith, StringComparison comparisonType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, comparisonType, paramName, optsFn);

        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsAllLettersOrDigits([ValidatedNotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsAllLettersOrDigits(value, paramName, optsFn);
    }
}