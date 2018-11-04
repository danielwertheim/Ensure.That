using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : class
            => Ensure.Any.IsNotNull(value, paramName, optsFn);
    }
}