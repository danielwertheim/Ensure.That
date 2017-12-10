using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class BoolArg
    {
        [DebuggerStepThrough]
        [ContractAnnotation("value:false=>halt; value:true=>void")]
        public void IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (!value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsTrueFailed,
                    paramName);
        }

        [DebuggerStepThrough]
        [ContractAnnotation("value:true=>halt; value:false=>void")]
        public void IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            if (value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsFalseFailed,
                    paramName);
        }
    }
}