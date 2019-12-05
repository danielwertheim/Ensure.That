using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsureThat.Enforcers
{
    public sealed class NumberArg
    {

        #region IsPositive
        public sbyte IsPositive(sbyte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if(value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public byte IsPositive(byte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public short IsPositive(short value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public ushort IsPositive(ushort value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsPositive(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public uint IsPositive(uint value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        public ulong IsPositive(ulong value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsPositive_Failed, value), paramName, optsFn);

            return value;
        }

        public float IsPositive(float value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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
        public sbyte IsNegative(sbyte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public byte IsNegative(byte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public short IsNegative(short value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public ushort IsNegative(ushort value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public uint IsNegative(uint value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        public ulong IsNegative(ulong value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value >= 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public float IsNegative(float value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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
        public sbyte IsNotNegative(sbyte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
           if(value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public byte IsNotNegative(byte value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public short IsNotNegative(short value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public ushort IsNotNegative(ushort value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public int IsNotNegative(int value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public uint IsNotNegative(uint value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        public ulong IsNotNegative(ulong value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            if (value < 0)
                throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsNotNegative_Failed, value), paramName, optsFn);

            return value;
        }

        public float IsNotNegative(float value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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
        public sbyte IsApproximately(sbyte value, sbyte target, sbyte accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public byte IsApproximately(byte value, byte target, byte accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public short IsApproximately(short value, short target, short accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public ushort IsApproximately(ushort value, ushort target, ushort accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public int IsApproximately(int value, int target, int accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

             throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target ), paramName, optsFn);
        }

        public uint IsApproximately(uint value, uint target, uint accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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

        public ulong IsApproximately(ulong value, ulong target, ulong accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
        {
            var min = target - accuracy;
            var max = target + accuracy;
            if (value >= min && value <= max)
                return value;

            throw Ensure.ExceptionFactory.ArgumentException(string.Format(ExceptionMessages.Numbers_IsApproximately_Failed, value, accuracy, target), paramName, optsFn);
        }

        public float IsApproximately(float value, float target, float accuracy, [InvokerParameterName] string paramName = null, OptsFn optsFn = null)
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