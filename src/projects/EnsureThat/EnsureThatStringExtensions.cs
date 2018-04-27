using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class EnsureThatStringExtensions
    {
        public static void IsNotNull(this StringParam param)
            => Ensure.String.IsNotNull(param.Value, param.Name, param.OptsFn);

        public static void IsNotNullOrWhiteSpace(this StringParam param)
            => Ensure.String.IsNotNullOrWhiteSpace(param.Value, param.Name, param.OptsFn);

        public static void IsNotNullOrEmpty(this StringParam param)
            => Ensure.String.IsNotNullOrEmpty(param.Value, param.Name, param.OptsFn);

        public static void IsNotEmpty(this StringParam param)
            => Ensure.String.IsNotEmpty(param.Value, param.Name, param.OptsFn);

        public static void HasLengthBetween(this StringParam param, int minLength, int maxLength)
            => Ensure.String.HasLengthBetween(param.Value, minLength, maxLength, param.Name, param.OptsFn);

        public static void Matches(this StringParam param, [RegexPattern] string match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        public static void Matches(this StringParam param, [NotNull] Regex match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        public static void SizeIs(this StringParam param, int expected)
            => Ensure.String.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void IsEqualTo(this StringParam param, string expected)
            => Ensure.String.IsEqualTo(param.Value, expected, param.Name, param.OptsFn);

        public static void IsEqualTo(this StringParam param, string expected, StringComparison comparison)
            => Ensure.String.IsEqualTo(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this StringParam param, string expected)
            => Ensure.String.IsNotEqualTo(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this StringParam param, string expected, StringComparison comparison)
            => Ensure.String.IsNotEqualTo(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsGuid(this StringParam param)
            => Ensure.String.IsGuid(param.Value, param.Name, param.OptsFn);

        public static void StartsWith(this StringParam param, [NotNull] string expectedStartsWith)
            => Ensure.String.StartsWith(param.Value, expectedStartsWith, param.Name, param.OptsFn);

        public static void StartsWith(this StringParam param, [NotNull] string expectedStartsWith, StringComparison comparison)
            => Ensure.String.StartsWith(param.Value, expectedStartsWith, comparison, param.Name, param.OptsFn);

        public static void IsLt(this StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsLt(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsLte(this StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsLte(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsGt(this StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsGt(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsGte(this StringParam param, string limit, StringComparison comparison)
            => Ensure.String.IsGte(param.Value, limit, comparison, param.Name, param.OptsFn);

        public static void IsInRange(this StringParam param, string min, string max, StringComparison comparison)
            => Ensure.String.IsInRange(param.Value, min, max, comparison, param.Name, param.OptsFn);
    }
}