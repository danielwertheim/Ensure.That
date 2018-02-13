namespace EnsureThat.Enforcers
{
    internal class DummyBoolArg : IBoolArg
    {
        public bool IsTrue(bool value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;

        public bool IsFalse(bool value, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => value;
    }
}