using System;
using System.Diagnostics.CodeAnalysis;
using EnsureThat.Internals;
using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed partial class ComparableArg
    {
        public DateTime Is(DateTime value, DateTime expected, [InvokerParameterName] string paramName = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_Is_Failed, value, expected), paramName);

            return value;
        }

        public DateTime IsNot(DateTime value, DateTime expected, [InvokerParameterName] string paramName = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName);

            return value;
        }

        public DateTime IsLt(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value);

            return value;
        }

        public DateTime IsLte(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value);

            return value;
        }

        public DateTime IsGt(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value);

            return value;
        }

        public DateTime IsGte(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value);

            return value;
        }

        public DateTime IsInRange(DateTime value, DateTime min, DateTime max, [InvokerParameterName] string paramName = null)
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
