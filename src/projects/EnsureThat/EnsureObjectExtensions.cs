namespace EnsureThat
{
    public static class EnsureObjectExtensions
    {
        public static void IsNotNull<T>(this Param<T> param)
            => Ensure.Any.IsNotNull(param.Value, param.Name, param.OptsFn);
    }
}