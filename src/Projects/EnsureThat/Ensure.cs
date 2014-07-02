using System.Diagnostics;

namespace EnsureThat
{
    public static class Ensure
    {
        [DebuggerStepThrough]
        public static Param<T> That<T>([JetBrains.Annotations.NoEnumeration]T value, string name = Param.DefaultName)
        {
            return new Param<T>(name, value);
        }

        [DebuggerStepThrough]
        public static TypeParam ThatTypeFor<T>(T value, string name = Param.DefaultName)
        {
            return new TypeParam(name, value.GetType());
        }
    }
}