using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IAnyArg
    {
        T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct;
        T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct;
    }
}