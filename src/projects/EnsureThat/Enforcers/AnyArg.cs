using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using EnsureThat.Annotations;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed class AnyArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull, NotNull] T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class
        {
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T? IsNotNull<T>([ValidatedNotNull, NotNull] T? value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : struct
        {
            if (value == null)
                throw Ensure.ExceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName);

            return value;
        }

        public T IsNotDefault<T>(T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : struct
        {
            if (default(T).Equals(value))
                throw Ensure.ExceptionFactory.ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName);

            return value;
        }
    }
}
