using System;
using System.Text.RegularExpressions;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IStringArg
    {
        string IsNotNull([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsNotNullOrWhiteSpace([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsNotNullOrEmpty([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsNotEmpty(string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string HasLengthBetween([ValidatedNotNull]string value, int minLength, int maxLength, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string Matches([NotNull] string value, [NotNull, RegexPattern] string match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string Matches([NotNull] string value, [NotNull] Regex match, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string SizeIs([ValidatedNotNull]string value, int expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsNotEqualTo(string value, string expected, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsNotEqualTo(string value, string expected, StringComparison comparison, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string IsGuid([ValidatedNotNull]string value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string StartsWith([ValidatedNotNull]string value, [NotNull] string expectedStartsWith, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        string StartsWith([ValidatedNotNull]string value, [NotNull] string expectedStartsWith, StringComparison comparisonType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
    }
}