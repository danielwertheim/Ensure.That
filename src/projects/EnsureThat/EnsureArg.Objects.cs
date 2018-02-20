using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        public static T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
            => Ensure.Any.IsNotNull(value, paramName, optsFn);
    }
}