using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T IsNotNull<T>([NoEnumeration, ValidatedNotNull, NotNull] T value, [InvokerParameterName] string paramName = null) where T : class
            => Ensure.Any.IsNotNull(value, paramName);
    }
}
