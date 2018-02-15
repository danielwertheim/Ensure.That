namespace EnsureThat
{
    public static class EnsureValueTypeExtensions
    {
        public static void IsNotDefault<T>(this Param<T> param) where T : struct
            => Ensure.Any.IsNotDefault(param.Value, param.Name, param.OptsFn);
    }
}