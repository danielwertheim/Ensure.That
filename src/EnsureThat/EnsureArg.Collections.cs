using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static void HasItems<T>(T value, string paramName = Param.DefaultName) where T : class, ICollection
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(Collection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(ICollection<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(T[] value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Length < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(List<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<T>(IList<T> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }

        [DebuggerStepThrough]
        public static void HasItems<TKey, TValue>(IDictionary<TKey, TValue> value, string paramName = Param.DefaultName)
        {
            if (!Ensure.IsActive)
                return;

            IsNotNull(value, paramName);

            if (value.Count < 1)
                throw new ArgumentException(
                    ExceptionMessages.EnsureExtensions_IsEmptyCollection,
                    paramName);
        }
    }
}