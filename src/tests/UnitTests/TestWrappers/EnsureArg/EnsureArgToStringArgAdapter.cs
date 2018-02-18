using System;
using System.Text.RegularExpressions;

using EnsureThat;

namespace UnitTests.TestWrappers
{
    /// <summary>
    /// Adapts from the <see cref="EnsureArg"/> syntax to the <see cref="IStringArg"/> syntax
    /// to reduce duplication in tests.
    /// </summary>
    internal sealed class EnsureArgToStringArgAdapter : IStringArg
    {
        public string IsNotNull(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotNull(value, paramName, optsFn);
        }

        public string IsNotNullOrWhiteSpace(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotNullOrWhiteSpace(value, paramName, optsFn);
        }

        public string IsNotNullOrEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotNullOrEmpty(value, paramName, optsFn);
        }

        public string IsNotEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotEmpty(value, paramName, optsFn);
        }

        public string HasLengthBetween(string value, int minLength, int maxLength, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.HasLengthBetween(value, minLength, maxLength, paramName, optsFn);
        }

        public string Matches(string value, string match, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.Matches(value, match, paramName, optsFn);
        }

        public string Matches(string value, Regex match, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.Matches(value, match, paramName, optsFn);
        }

        public string SizeIs(string value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.SizeIs(value, expected, paramName, optsFn);
        }

        public string IsEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsEqualTo(value, expected, paramName, optsFn);
        }

        public string IsEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsEqualTo(value, expected, comparison, paramName, optsFn);
        }

        public string IsNotEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotEqualTo(value, expected, paramName, optsFn);
        }

        public string IsNotEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsNotEqualTo(value, expected, comparison, paramName, optsFn);
        }

        public string IsGuid(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.IsGuid(value, paramName, optsFn);
        }
    }
}
