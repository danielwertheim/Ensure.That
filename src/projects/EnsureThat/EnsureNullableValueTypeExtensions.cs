namespace EnsureThat
{
    public static class EnsureNullableValueTypeExtensions
    {
        public static void IsNotNull<T>(this Param<T?> param) where T : struct
            => Ensure.Any.IsNotNull(param.Value, param.Name, param.OptsFn);
    }
}