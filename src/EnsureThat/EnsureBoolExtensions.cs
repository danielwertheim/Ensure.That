using System.Diagnostics;

namespace EnsureThat
{
    public static class EnsureBoolExtensions
    {
        [DebuggerStepThrough]
        public static Param<bool> IsTrue(this Param<bool> param)
        {
            EnsureArg.IsTrue(param.Value, param.Name);

            return param;
        }

        [DebuggerStepThrough]
        public static Param<bool> IsFalse(this Param<bool> param)
        {
            EnsureArg.IsFalse(param.Value, param.Name);

            return param;
        }
    }
}