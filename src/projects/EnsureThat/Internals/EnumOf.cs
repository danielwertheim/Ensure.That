using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
// ReSharper disable StaticMemberInGenericType

namespace EnsureThat.Internals
{
    [SuppressMessage("Minor Code Smell", "S3963:\"static\" fields should be initialized inline")]
    [SuppressMessage("Major Code Smell", "S2743:Static fields should not be used in generic types")]
    internal static class EnumOf<T> where T : struct, Enum
    {
        internal static readonly Type EnumType;
        private static readonly bool HasFlags;
        private static readonly List<ulong> Values;

        static EnumOf()
        {
            EnumType = typeof(T);

            HasFlags = EnumType.GetTypeInfo().GetCustomAttributes<FlagsAttribute>(false).Any();

            var enumValues = Enum.GetValues(EnumType);
            Values = new List<ulong>(enumValues.Length);
            foreach (var v in enumValues)
                Values.Add(Convert.ToUInt64(v, null));
        }

        internal static bool Contains(T value)
        {
            if (!HasFlags)
                return Enum.IsDefined(EnumType, value);

            var raw = Convert.ToUInt64(value, null);
            if (raw == 0)
                return Enum.IsDefined(EnumType, value);

            ulong sum = 0;

            foreach (var val in Values)
            {
                if ((raw & val) == val)
                    sum |= val;
            }

            return sum == raw;
        }
    }
}
