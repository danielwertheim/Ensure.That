using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class EnsureStringExtensions
    {
        public static void IsNotNullOrWhiteSpace(this Param<string> param)
            => Ensure.String.IsNotNullOrWhiteSpace(param.Value, param.Name, param.OptsFn);

        public static void IsNotNullOrEmpty(this Param<string> param)
            => Ensure.String.IsNotNullOrEmpty(param.Value, param.Name, param.OptsFn);

        public static void IsNotEmpty(this Param<string> param)
            => Ensure.String.IsNotEmpty(param.Value, param.Name, param.OptsFn);

        public static void HasLengthBetween(this Param<string> param, int minLength, int maxLength)
            => Ensure.String.HasLengthBetween(param.Value, minLength, maxLength, param.Name, param.OptsFn);

        public static void Matches(this Param<string> param, [RegexPattern] string match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        public static void Matches(this Param<string> param, [NotNull] Regex match)
            => Ensure.String.Matches(param.Value, match, param.Name, param.OptsFn);

        public static void SizeIs(this Param<string> param, int expected)
            => Ensure.String.SizeIs(param.Value, expected, param.Name, param.OptsFn);

        public static void IsEqualTo(this Param<string> param, string expected)
            => Ensure.String.IsEqualTo(param.Value, expected, param.Name, param.OptsFn);

        public static void IsEqualTo(this Param<string> param, string expected, StringComparison comparison)
            => Ensure.String.IsEqualTo(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this Param<string> param, string expected)
            => Ensure.String.IsNotEqualTo(param.Value, expected, param.Name, param.OptsFn);

        public static void IsNotEqualTo(this Param<string> param, string expected, StringComparison comparison)
            => Ensure.String.IsNotEqualTo(param.Value, expected, comparison, param.Name, param.OptsFn);

        public static void IsGuid(this Param<string> param)
            => Ensure.String.IsGuid(param.Value, param.Name, param.OptsFn);
    }
}