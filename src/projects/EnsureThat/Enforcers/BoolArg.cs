using JetBrains.Annotations;

// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace EnsureThat.Enforcers
{
    public sealed class BoolArg
    {
        [ContractAnnotation("value:false=>halt; value:true=>true")]
        public bool IsTrue(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (!value)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsTrueFailed, paramName, optsFn);

            return value;
        }

        [ContractAnnotation("value:true=>halt; value:false=>false")]
        public bool IsFalse(bool value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsFalseFailed, paramName, optsFn);

            return value;
        }
    }
}