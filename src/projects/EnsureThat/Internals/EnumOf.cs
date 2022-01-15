using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EnsureThat.Internals
{
    internal static class EnumOf<T> where T : struct, Enum
    {
        internal static readonly Type EnumType;
        private static readonly bool _hasFlags;
        private static readonly List<ulong> _values;

        static EnumOf()
        {
            EnumType = typeof(T);

            _hasFlags = EnumType.GetTypeInfo().GetCustomAttributes<FlagsAttribute>(false).Any();

            var enumValues = Enum.GetValues(EnumType);
            _values = new List<ulong>(enumValues.Length);
            foreach (var v in enumValues)
                _values.Add(Convert.ToUInt64(v, null));
        }

        internal static bool Contains(T value)
        {
            if (!_hasFlags)
                return Enum.IsDefined(EnumType, value);

            var raw = Convert.ToUInt64(value, null);
            if (raw == 0)
                return Enum.IsDefined(EnumType, value);

            ulong sum = 0;

            foreach (var val in _values)
            {
                if ((raw & val) == val)
                    sum |= val;
            }

            return sum == raw;
        }
    }
}
