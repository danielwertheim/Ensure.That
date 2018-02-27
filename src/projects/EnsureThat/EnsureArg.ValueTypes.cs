using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        public static T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct
            => Ensure.Any.IsNotDefault(value, paramName, optsFn);
    }
}