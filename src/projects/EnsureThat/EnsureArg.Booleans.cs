using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        [ContractAnnotation("value:false=>halt; value:true=>void")]
        public static void IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Bool.IsTrue(value, paramName);

        [DebuggerStepThrough]
        [ContractAnnotation("value:false=>halt; value:true=>void")]
        public static void IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
            => Ensure.Bool.IsFalse(value, paramName);
    }
}