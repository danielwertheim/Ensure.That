namespace EnsureThat.Enforcers
{
    internal class DummyBoolArg : IBoolArg
    {
        public bool IsTrue(bool value, string paramName = null, OptsFn optsFn = null)
            => value;

        public bool IsFalse(bool value, string paramName = null, OptsFn optsFn = null)
            => value;
    }
}