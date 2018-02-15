namespace EnsureThat
{
    public static class EnsureBoolExtensions
    {
        public static void IsTrue(this Param<bool> param)
            => Ensure.Bool.IsTrue(param.Value, param.Name, param.OptsFn);

        public static void IsFalse(this Param<bool> param)
            => Ensure.Bool.IsFalse(param.Value, param.Name, param.OptsFn);
    }
}