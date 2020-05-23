namespace EnsureThat
{
    public static class EnsureThatAnyExtensions
    {
        public static void HasValue<T>(this in Param<T> param)
            => Ensure.Any.HasValue(param.Value, param.Name, param.OptsFn);
        
        public static void IsNotNull<T>(this in Param<T> param) where T : class
            => Ensure.Any.IsNotNull(param.Value, param.Name, param.OptsFn);
    }
}