using System;
using System.Diagnostics;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T IsNotNull<T>([NoEnumeration, NotNull, ValidatedNotNull] T value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return value;

            if (value == null)
                throw new ArgumentNullException(paramName, ExceptionMessages.Common_IsNotNull_Failed);

            return value;
        }
    }
}