using System;
using System.Threading;

namespace EnsureThat
{
    public delegate EnsureOptions OptsFn(in EnsureOptions options);

    /// <summary>
    /// Provides a hierarchical scope used to provide custom exception config etc.
    /// </summary>
    public sealed class EnsureScope : IDisposable
    {
        private readonly EnsureScope _parent;
        private EnsureOptions _options = EnsureOptions.Default;

        private static readonly AsyncLocal<EnsureScope> Container = new();

        private EnsureScope(EnsureScope parent = null)
        {
            _parent = parent;
        }

        public static EnsureScope Create()
        {
            var scope = new EnsureScope(Container.Value);

            Container.Value = scope;

            return scope;
        }

        internal static EnsureOptions? GetCurrent()
            => Container.Value?._options;

        public EnsureScope With(in EnsureOptions options)
        {
            _options = options;

            return this;
        }

        public EnsureScope With(OptsFn config)
        {
            _options = config(_options);

            return this;
        }

        public void Dispose()
            => Container.Value = _parent;
    }
}
