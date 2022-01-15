using System.Diagnostics.CodeAnalysis;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed partial class ComparableArg
    {
        public int Is(int value, int expected, [InvokerParameterName] string paramName = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public int IsNot(int value, int expected, [InvokerParameterName] string paramName = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public int IsLt(int value, int limit, [InvokerParameterName] string paramName = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public int IsLte(int value, int limit, [InvokerParameterName] string paramName = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public int IsGt(int value, int limit, [InvokerParameterName] string paramName = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public int IsGte(int value, int limit, [InvokerParameterName] string paramName = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public int IsInRange(int value, int min, int max, [InvokerParameterName] string paramName = null)
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
