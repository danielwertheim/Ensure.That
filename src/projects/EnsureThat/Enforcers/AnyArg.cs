using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public class AnyArg : IAnyArg
    {
        private readonly IExceptionFactory _exceptionFactory;

        public AnyArg(IExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
        }

        [NotNull]
        public T IsNotNull<T>([NoEnumeration, ValidatedNotNull] T value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null)
        {
            if (value == null)
                throw _exceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T? IsNotNull<T>(T? value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
        {
            if (value == null)
                throw _exceptionFactory.ArgumentNullException(ExceptionMessages.Common_IsNotNull_Failed, paramName, optsFn);

            return value;
        }

        public T IsNotDefault<T>(T value, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null) where T : struct
        {
            if (default(T).Equals(value))
                throw _exceptionFactory.ArgumentException(ExceptionMessages.ValueTypes_IsNotDefault_Failed, paramName, optsFn);

            return value;
        }
    }
}