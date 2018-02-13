namespace EnsureThat.Enforcers
{
    internal class DummyAnyArg : IAnyArg
    {
        public T IsNotNull<T>(T value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public T? IsNotNull<T>(T? value, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
            => value;

        public T IsNotDefault<T>(T value, string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
            => value;
    }
}