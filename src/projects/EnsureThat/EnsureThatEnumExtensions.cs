namespace EnsureThat
{
    public static class EnsureThatEnumExtensions
    {
        public static void IsValidEnum<T>(this in Param<T> param) where T : struct, System.Enum
            => Ensure.Enum.IsValidEnum(param.Value, param.Name, param.OptsFn);
    }
}