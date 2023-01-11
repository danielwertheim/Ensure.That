using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed partial class ComparableArg
    {
        public double Is(double value, double expected, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public double IsNot(double value, double expected, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public double IsLt(double value, double limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public double IsLte(double value, double limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public double IsGt(double value, double limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public double IsGte(double value, double limit, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public double IsInRange(double value, double min, double max, [InvokerParameterName, CallerArgumentExpression("value")] string paramName = null)
        {
            if (value < min)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value);

            if (value > max)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value);

            return value;
        }
    }
}
