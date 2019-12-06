using JetBrains.Annotations;

namespace EnsureThat.Enforcers
{
    public sealed class NumberArg
    {

        #region IsPositive
        public int IsPositive(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public long IsPositive(long value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public double IsPositive(double value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public decimal IsPositive(decimal value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }
        #endregion

        #region IsNegative
        public int IsNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public long IsNegative(long value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public double IsNegative(double value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public decimal IsNegative(decimal value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }
        #endregion

        #region IsNotNegative
        public int IsNotNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public long IsNotNegative(long value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public double IsNotNegative(double value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public decimal IsNotNegative(decimal value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }
        #endregion

        #region IsApproximately
        public int IsApproximately(int value, int target, int accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public long IsApproximately(long value, long target, long accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public double IsApproximately(double value, double target, double accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public decimal IsApproximately(decimal value, decimal target, decimal accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }
        #endregion
    }
}