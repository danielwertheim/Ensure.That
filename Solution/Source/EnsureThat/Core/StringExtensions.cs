using System.Diagnostics;

namespace EnsureThat.Core
{
    internal static class StringExtensions
    {
        [DebuggerStepThrough]
        internal static string Inject(this string format, params object[] formattingArgs)
        {
            return string.Format(format, formattingArgs);
        }

        [DebuggerStepThrough]
        internal static string Inject(this string format, params string[] formattingArgs)
        {
            return string.Format(format, formattingArgs);
        }
    }
}