using JetBrains.Annotations;

namespace EnsureThat
{
    public interface IBoolArg
    {
        bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
    }
}