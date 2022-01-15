using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class EnsureThatStringExtensions
    {
        public static StringParam IsNotNull(this in StringParam param)
        {
            Ensure.String.IsNotNull(param.Value, param.Name);

            return param;
        }

        public static StringParam IsNotNullOrWhiteSpace(this in StringParam param)
        {
            Ensure.String.IsNotNullOrWhiteSpace(param.Value, param.Name);

            return param;
        }

        public static StringParam IsNotNullOrEmpty(this in StringParam param)
        {
            Ensure.String.IsNotNullOrEmpty(param.Value, param.Name);

            return param;
        }

        public static StringParam IsNotEmptyOrWhiteSpace(this in StringParam param)
        {
            Ensure.String.IsNotEmptyOrWhiteSpace(param.Value, param.Name);

            return param;
        }

        public static StringParam IsNotEmpty(this in StringParam param)
        {
            Ensure.String.IsNotEmpty(param.Value, param.Name);

            return param;
        }

        public static StringParam HasLength(this in StringParam param, int expected)
        {
            Ensure.String.HasLength(param.Value, expected, param.Name);

            return param;
        }

        public static StringParam HasLengthBetween(this in StringParam param, int minLength, int maxLength)
        {
            Ensure.String.HasLengthBetween(param.Value, minLength, maxLength, param.Name);

            return param;
        }

        public static StringParam Matches(this in StringParam param, [RegexPattern] string match)
        {
            Ensure.String.Matches(param.Value, match, param.Name);

            return param;
        }

        public static StringParam Matches(this in StringParam param, [NotNull] Regex match)
        {
            Ensure.String.Matches(param.Value, match, param.Name);

            return param;
        }

        [Obsolete("Use 'HasLength' instead. This will be removed in an upcoming version.")]
        public static StringParam SizeIs(this in StringParam param, int expected)
        {
            Ensure.String.SizeIs(param.Value, expected, param.Name);

            return param;
        }

        public static StringParam Is(this in StringParam param, string expected)
        {
            Ensure.String.Is(param.Value, expected, param.Name);

            return param;
        }

        public static StringParam Is(this in StringParam param, string expected, StringComparison comparison)
        {
            Ensure.String.Is(param.Value, expected, comparison, param.Name);

            return param;
        }

        public static StringParam IsEqualTo(this in StringParam param, string expected)
        {
            Ensure.String.IsEqualTo(param.Value, expected, param.Name);

            return param;
        }

        public static StringParam IsEqualTo(this in StringParam param, string expected, StringComparison comparison)
        {
            Ensure.String.IsEqualTo(param.Value, expected, comparison, param.Name);

            return param;
        }

        public static StringParam IsNot(this in StringParam param, string notExpected)
        {
            Ensure.String.IsNot(param.Value, notExpected, param.Name);

            return param;
        }

        public static StringParam IsNot(this in StringParam param, string notExpected, StringComparison comparison)
        {
            Ensure.String.IsNot(param.Value, notExpected, comparison, param.Name);

            return param;
        }

        public static StringParam IsNotEqualTo(this in StringParam param, string notExpected)
        {
            Ensure.String.IsNotEqualTo(param.Value, notExpected, param.Name);

            return param;
        }

        public static StringParam IsNotEqualTo(this in StringParam param, string notExpected, StringComparison comparison)
        {
            Ensure.String.IsNotEqualTo(param.Value, notExpected, comparison, param.Name);

            return param;
        }

        public static StringParam IsGuid(this in StringParam param)
        {
            Ensure.String.IsGuid(param.Value, param.Name);

            return param;
        }

        public static StringParam StartsWith(this in StringParam param, [NotNull] string expectedStartsWith)
        {
            Ensure.String.StartsWith(param.Value, expectedStartsWith, param.Name);

            return param;
        }

        public static StringParam StartsWith(this in StringParam param, [NotNull] string expectedStartsWith, StringComparison comparison)
        {
            Ensure.String.StartsWith(param.Value, expectedStartsWith, comparison, param.Name);

            return param;
        }

        public static StringParam IsLt(this in StringParam param, string limit, StringComparison comparison)
        {
            Ensure.String.IsLt(param.Value, limit, comparison, param.Name);

            return param;
        }

        public static StringParam IsLte(this in StringParam param, string limit, StringComparison comparison)
        {
            Ensure.String.IsLte(param.Value, limit, comparison, param.Name);

            return param;
        }

        public static StringParam IsGt(this in StringParam param, string limit, StringComparison comparison)
        {
            Ensure.String.IsGt(param.Value, limit, comparison, param.Name);

            return param;
        }

        public static StringParam IsGte(this in StringParam param, string limit, StringComparison comparison)
        {
            Ensure.String.IsGte(param.Value, limit, comparison, param.Name);

            return param;
        }

        public static StringParam IsInRange(this in StringParam param, string min, string max, StringComparison comparison)
        {
            Ensure.String.IsInRange(param.Value, min, max, comparison, param.Name);

            return param;
        }

        public static StringParam IsAllLettersOrDigits(this in StringParam param)
        {
            Ensure.String.IsAllLettersOrDigits(param.Value, param.Name);

            return param;
        }
    }
}
