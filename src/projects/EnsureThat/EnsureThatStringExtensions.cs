using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class EnsureThatStringExtensions
    {
        public static void IsNotNull(this in StringParam param)
            => Ensure.String.IsNotNull(param.Value, param.Name, param.OptsFn);

        public static void IsNotNullOrWhiteSpace(this in StringParam param)
            => Ensure.String.IsNotNullOrWhiteSpace(param.Value, param.Name, param.OptsFn);

        public static void IsNotNullOrEmpty(this in StringParam param)
            => Ensure.String.IsNotNullOrEmpty(param.Value, param.Name, param.OptsFn);

        public static void IsNotEmptyOrWhiteSpace(this in StringParam param)
            => Ensure.String.IsNotEmptyOrWhiteSpace(param.Value, param.Name, param.OptsFn);

        public static void IsNotEmpty(this in StringParam param)
            => Ensure.String.IsNotEmpty(param.Value, param.Name, param.OptsFn);
        
        public static void HasLength(this in StringParam param, int expected)
            => Ensure.String.HasLength(param.Value, expected, param.Name, param.OptsFn);

        public static void HasLengthBetween(this in StringParam param, int minLength, int maxLength)
            => Ensure.String.HasLengthBetween(param.Value, minLength, maxLength, param.Name, param.OptsFn);

        public static void Matches(this in StringParam param, [RegexPattern] string match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        public static void Matches(this in StringParam param, [NotNull] Regex match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        [Obsolete("Use 'HasLength' instead. This will be removed in an upcoming version.")]
        public static void SizeIs(this in StringParam param, int expected)
            => Ensure.String.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void Is(this in StringParam param, string expected)
            => Ensure.String.Is(param.Value, expected, param.Name, param.OptsFn);

        public static void IsEqualTo(this in StringParam param, string expected)
            => Ensure.String.IsEqualTo(param.Value, expected, param.Name, param.OptsFn);

        public static void Is(this in StringParam param, string expected, StringComparison comparison)
            => Ensure.String.Is(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsEqualTo(this in StringParam param, string expected, StringComparison comparison)
            => Ensure.String.IsEqualTo(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsNot(this in StringParam param, string notExpected)
            => Ensure.String.IsNot(param.Value, notExpected, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this in StringParam param, string notExpected)
            => Ensure.String.IsNotEqualTo(param.Value, notExpected, param.Name, param.OptsFn);

        public static void IsNot(this in StringParam param, string notExpected, StringComparison comparison)
            => Ensure.String.IsNot(param.Value, notExpected, comparison, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this in StringParam param, string notExpected, StringComparison comparison)
            => Ensure.String.IsNotEqualTo(param.Value, notExpected, comparison, param.Name, param.OptsFn);

        public static void IsGuid(this in StringParam param)
            => Ensure.String.IsGuid(param.Value, param.Name, param.OptsFn);

        public static void StartsWith(this in StringParam param, [NotNull] string expectedStartsWith)
            => Ensure.String.StartsWith(param.Value, expectedStartsWith, param.Name, param.OptsFn);

        public static void StartsWith(this in StringParam param, [NotNull] string expectedStartsWith, StringComparison comparison)
            => Ensure.String.StartsWith(param.Value, expectedStartsWith, comparison, param.Name, param.OptsFn);

        public static void IsLt(this in StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsLt(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsLte(this in StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsLte(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsGt(this in StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsGt(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsGte(this in StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsGte(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsInRange(this in StringParam param, string min, string max, StringComparison comparison)
            => Ensure.String.IsInRange(param.Value, min, max, comparison, param.Name, param.OptsFn);

        public static void IsAllLettersOrDigits(this in StringParam param)
            => Ensure.String.IsAllLettersOrDigits(param.Value, param.Name, param.OptsFn);
    }
}