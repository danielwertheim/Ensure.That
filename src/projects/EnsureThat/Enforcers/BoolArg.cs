using JetBrains.Annotations;

// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace EnsureThat.Enforcers
{
    public class BoolArg : IBoolArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public BoolArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

        [ContractAnnotation("value:false=>halt; value:true=>true")]
        public bool IsTrue(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (!value)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsTrueFailed, paramName, optsFn);

            return value;
        }

        [ContractAnnotation("value:true=>halt; value:false=>false")]
        public bool IsFalse(bool value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value)
                throw _exceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsFalseFailed, paramName, optsFn);

            return value;
        }
    }
}