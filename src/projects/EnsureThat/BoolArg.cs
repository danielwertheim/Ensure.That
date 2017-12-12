using System.Diagnostics;
using JetBrains.Annotations;
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace EnsureThat
{
    public class BoolArg
    {
        [DebuggerStepThrough]
        [ContractAnnotation("value:false=>halt; value:true=>true")]
        public bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsTrueFailed, paramName, optsFn);

            return value;
        }

        [DebuggerStepThrough]
        [ContractAnnotation("value:true=>halt; value:false=>false")]
        public bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!Ensure.IsActive)
                return value;

            if (value)
                throw ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsFalseFailed, paramName, optsFn);

            return value;
        }
    }
}