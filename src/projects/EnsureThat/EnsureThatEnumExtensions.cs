namespace EnsureThat
{
    public static class EnsureThatEnumExtensions
    {
        /// <summary>
        /// Confirms that the <paramref name="param.Value"/> is defined in the enum <typeparamref name="T"/>.
        /// </summary>
        public static void IsDefined<T>(this in Param<T> param) where T : struct, System.Enum
            => Ensure.Enum.IsDefined(param.Value, param.Name, param.OptsFn);
    }
}