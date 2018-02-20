using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IBoolArg
    {
        bool IsTrue(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
        bool IsFalse(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null);
    }
}