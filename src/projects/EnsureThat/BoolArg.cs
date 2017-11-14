using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class BoolArg
    {
        [DebuggerStepThrough]
        [ContractAnnotation("value:false=>halt; value:true=>true")]
        public bool IsTrue(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (!value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsTrueFailed,
                    paramName);

            return value;
        }

        [DebuggerStepThrough]
        [ContractAnnotation("value:true=>halt; value:false=>false")]
        public bool IsFalse(bool value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value)
                throw new ArgumentException(
                    ExceptionMessages.Booleans_IsFalseFailed,
                    paramName);

            return value;
        }
    }
}