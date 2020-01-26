namespace EnsureThat
{
    public static class EnsureThatObjectExtensions
    {
        public static void IsNotNull<T>(this in Param<T> param) where T : class
            => Ensure.Any.IsNotNull(param.Value, param.Name, param.OptsFn);
    }
}