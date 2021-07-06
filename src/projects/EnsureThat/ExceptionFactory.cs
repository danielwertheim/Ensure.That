using EnsureThat.Internals;

namespace EnsureThat
{
    public static class ExceptionFactory
    {
        public static IExceptionFactory Default { get; } = new DefaultExceptionFactory();
    }
}
