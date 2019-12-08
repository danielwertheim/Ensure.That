using System;

namespace EnsureThat
{
    public static class EnsureThatValueTypeExtensions
    {
        public static void IsTrue(this in Param<bool> param)
            => Ensure.Bool.IsTrue(param.Value, param.Name, param.OptsFn);

        public static void IsFalse(this in Param<bool> param)
            => Ensure.Bool.IsFalse(param.Value, param.Name, param.OptsFn);

        public static void IsNotDefault<T>(this in Param<T> param) where T : struct
            => Ensure.Any.IsNotDefault(param.Value, param.Name, param.OptsFn);

        public static void IsNotNull<T>(this in Param<T?> param) where T : struct
            => Ensure.Any.IsNotNull(param.Value, param.Name, param.OptsFn);

        public static void IsNotEmpty(this in Param<Guid> param)
            => Ensure.Guid.IsNotEmpty(param.Value, param.Name, param.OptsFn);
    }
}