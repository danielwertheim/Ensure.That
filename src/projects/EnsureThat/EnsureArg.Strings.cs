using System;
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
        public static string IsNotNull([ValidatedNotNull, NotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNull(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrWhiteSpace([ValidatedNotNull, NotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrWhiteSpace(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsNotNullOrEmpty([ValidatedNotNull, NotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotNullOrEmpty(value, paramName, optsFn);

        public static string IsNotEmptyOrWhiteSpace(string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEmptyOrWhiteSpace(value, paramName, optsFn);

        public static string IsNotEmpty(string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsNotEmpty(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string HasLength([ValidatedNotNull, NotNull] string value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.HasLength(value, expected, paramName, optsFn);
        
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string HasLengthBetween([ValidatedNotNull, NotNull] string value, int minLength, int maxLength, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.HasLengthBetween(value, minLength, maxLength, paramName, optsFn);

        [return: NotNull]
        public static string Matches([NotNull] string value, [NotNull] [RegexPattern] string match, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [return: NotNull]
        public static string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.Matches(value, match, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        [Obsolete("Use 'HasLength' instead. This will be removed in an upcoming version.")]
        public static string SizeIs([ValidatedNotNull, NotNull] string value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static Guid IsGuid([ValidatedNotNull, NotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsGuid(value, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull, NotNull] string value, [NotNull] string expectedStartsWith, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string StartsWith([ValidatedNotNull, NotNull] string value, [NotNull] string expectedStartsWith, StringComparison comparisonType, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.StartsWith(value, expectedStartsWith, comparisonType, paramName, optsFn);

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string IsAllLettersOrDigits([ValidatedNotNull, NotNull] string value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.String.IsAllLettersOrDigits(value, paramName, optsFn);
    }
}
