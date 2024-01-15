using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed partial class ComparableArg
    {
        public decimal Is(decimal value, decimal expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public decimal IsNot(decimal value, decimal expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public decimal IsLt(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public decimal IsLte(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public decimal IsGt(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public decimal IsGte(decimal value, decimal limit, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public decimal IsInRange(decimal value, decimal min, decimal max, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
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
