using System;
using System.Text.RegularExpressions;

namespace EnsureThat.Enforcers
{
    internal class DummyStringArg : IStringArg
    {
        public string IsNotNull(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsNotNullOrWhiteSpace(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsNotNullOrEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsNotEmpty(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string HasLengthBetween(string value, int minLength, int maxLength, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string Matches(string value, string match, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string Matches(string value, Regex match, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string SizeIs(string value, int expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsNotEqualTo(string value, string expected, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsNotEqualTo(string value, string expected, StringComparison comparison, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public string IsGuid(string value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}