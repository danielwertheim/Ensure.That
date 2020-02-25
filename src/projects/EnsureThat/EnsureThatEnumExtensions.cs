namespace EnsureThat
{
    public static class EnsureThatEnumExtensions
    {
        /// <summary>
        /// Confirms that the <paramref name="param.Value"/> is defined in the enum <typeparamref name="T"/>.
        /// Note that just like <see cref="System.Enum.IsDefined(System.Type, object)"/>,
        /// <see cref="System.FlagsAttribute"/> based enums may be valid combination of defined values, but if the combined value
        /// itself is not named an error will be raised. Avoid usage with <see cref="System.FlagsAttribute"/> enums.
        /// </summary>
        /// <example>
        /// Flags example:
        /// 
        /// [Flags]
        /// enum Abc{
        ///   A = 1,
        ///   B = 2,
        ///   C = 4,
        ///   AB = 3
        /// }
        ///
        /// Abc.A | Abc.B IsDefined=true (due to Abc.AB)
        /// Abc.A | Abc.C IsDefined=false (A and C are both valid, the composite is valid due to `<see cref="System.FlagsAttribute"/> attribute, but the composite is not a named enum value
        /// </example>
        public static void IsStrictlyDefined<T>(this in Param<T> param) where T : struct, System.Enum
            => Ensure.Enum.IsStrictlyDefined(param.Value, param.Name, param.OptsFn);

        /// <summary>
        /// Confirms that the <paramref name="param.Value"/> is defined in the enum <typeparamref name="T"/>.
        /// Supports <see cref="System.FlagsAttribute"/> attribute.
        /// </summary>
        public static void IsDefined<T>(this in Param<T> param) where T : struct, System.Enum
            => Ensure.Enum.IsDefined(param.Value, param.Name, param.OptsFn);
    }
}