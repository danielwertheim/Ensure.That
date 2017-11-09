using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T IsNotNull<T>([NoEnumeration, NotNull, ValidatedNotNull] T value, string paramName = Param.DefaultName)
            => Ensure.Any.IsNotNull(value, paramName);
    }
}