using System;
using System.Text.RegularExpressions;

using EnsureThat;

namespace UnitTests.TestWrappers
{
    /// <summary>
    /// Adapts from the <see cref="Ensure.That{T}"/> syntax to the <see cref="IStringArg"/> syntax
    /// to reduce duplication in tests.
    /// </summary>
    internal sealed class EnsureThatToStringArgAdapter : IStringArg
    {
        public string IsNotNull(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotNull();
            return value;
        }

        public string IsNotNullOrWhiteSpace(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotNullOrWhiteSpace();
            return value;
        }

        public string IsNotNullOrEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotNullOrEmpty();
            return value;
        }

        public string IsNotEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotEmpty();
            return value;
        }

        public string HasLengthBetween(string value, int minLength, int maxLength, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).HasLengthBetween(minLength, maxLength);
            return value;
        }

        public string Matches(string value, string match, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).Matches(match);
            return value;
        }

        public string Matches(string value, Regex match, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).Matches(match);
            return value;
        }

        public string SizeIs(string value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            return EnsureArg.SizeIs(value, expected, paramName, optsFn);
        }

        public string IsEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsEqualTo(expected);
            return value;
        }

        public string IsEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsEqualTo(expected, comparison);
            return value;
        }

        public string IsNotEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotEqualTo(expected);
            return value;
        }

        public string IsNotEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsNotEqualTo(expected, comparison);
            return value;
        }

        public string IsGuid(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            Ensure.That(value, paramName, optsFn).IsGuid();
            return value;
        }
    }
}
