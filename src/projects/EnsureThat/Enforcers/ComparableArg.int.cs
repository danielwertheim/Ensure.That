using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed partial class ComparableArg
    {
        public int Is(int value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_Is_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public int IsNot(int value, int expected, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value == expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(ExceptionMessages.Comp_IsNot_Failed, value, expected), paramName, optsFn);

            return value;
        }

        public int IsLt(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLt, value, limit), paramName, value, optsFn);

            return value;
        }

        public int IsLte(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value > limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotLte, value, limit), paramName, value, optsFn);

            return value;
        }

        public int IsGt(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value <= limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGt, value, limit), paramName, value, optsFn);

            return value;
        }

        public int IsGte(int value, int limit, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < limit)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotGte, value, limit), paramName, value, optsFn);

            return value;
        }

        public int IsInRange(int value, int min, int max, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < min)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToLow, value, min), paramName, value, optsFn);

            if (value > max)
                throw Ensure.ExceptionFactory.ArgumentOutOfRangeException(
                    string.Format(ExceptionMessages.Comp_IsNotInRange_ToHigh, value, max), paramName, value, optsFn);

            return value;
        }

        public int IsPositive(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if(value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsNotNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsApproximately(int value, int target, int accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }
    }
}