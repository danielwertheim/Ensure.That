using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNull([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotNull(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrWhiteSpace([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrEmpty([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotNullOrEmpty(value, paramName);

        public static string IsNotEmptyOrWhiteSpace(string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotEmptyOrWhiteSpace(value, paramName);

        public static string IsNotEmpty(string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotEmpty(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string HasLength([ValidatedNotNull, NotNull] string value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.HasLength(value, expected, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string HasLengthBetween([ValidatedNotNull, NotNull] string value, int minLength, int maxLength, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName);

        [return: NotNull]
        public static string Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.Matches(value, match, paramName);

        [return: NotNull]
        public static string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.Matches(value, match, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        [Obsolete("Use 'HasLength' instead. This will be removed in an upcoming version.")]
        public static string SizeIs([ValidatedNotNull, NotNull] string value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.SizeIs(value, expected, paramName);

        public static string Is(string value, string expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.Is(value, expected, paramName);

        public static string Is(string value, string expected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.Is(value, expected, comparison, paramName);

        public static string IsEqualTo(string value, string expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsEqualTo(value, expected, paramName);

        public static string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsEqualTo(value, expected, comparison, paramName);

        public static string IsNot(string value, string notExpected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNot(value, notExpected, paramName);

        public static string IsNot(string value, string notExpected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNot(value, notExpected, comparison, paramName);

        public static string IsNotEqualTo(string value, string notExpected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotEqualTo(value, notExpected, paramName);

        public static string IsNotEqualTo(string value, string notExpected, StringComparison comparison, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsNotEqualTo(value, notExpected, comparison, paramName);

        [ContractAnnotation("value:null => halt")]
        public static Guid IsGuid([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsGuid(value, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull, NotNull] string value, [NotNull] string expectedStartsWith, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull, NotNull] string value, [NotNull] string expectedStartsWith, StringComparison comparisonType, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, comparisonType, paramName);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsAllLettersOrDigits([ValidatedNotNull, NotNull] string value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
            => Ensure.String.IsAllLettersOrDigits(value, paramName);
    }
}
