using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed class BoolArg
    {
        [ContractAnnotation("value:false=>halt; value:true=>true")]
        public bool IsTrue(bool value, [InvokerParameterName] string paramName = null)
        {
            if (!value)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsTrueFailed, paramName);

            return value;
        }

        [ContractAnnotation("value:true=>halt; value:false=>false")]
        public bool IsFalse(bool value, [InvokerParameterName] string paramName = null)
        {
            if (value)
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.Booleans_IsFalseFailed, paramName);

            return value;
        }
    }
}
