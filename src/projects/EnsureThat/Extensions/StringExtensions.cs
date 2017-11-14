using System.Linq;
using JetBrains.Annotations;

namespace EnsureThat.Extensions
{
    internal static class StringExtensions
    {
        internal static string Inject(this string format, params object[] formattingArgs)
        {
            return string.Format(format, formattingArgs);
        }

        internal static string Inject(this string format, [NotNull] params string[] formattingArgs)
        {
            return string.Format(format, formattingArgs.Select(a => a as object).ToArray());
        }
    }
}