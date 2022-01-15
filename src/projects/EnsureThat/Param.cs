using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    [SuppressMessage("Design", "CA1051:Do not declare visible instance fields")]
    public readonly struct Param<T>
    {
        public readonly string Name;
        public readonly T Value;

        public Param(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }

    [SuppressMessage("Design", "CA1051:Do not declare visible instance fields")]
    public readonly struct StringParam
    {
        public readonly string Name;
        public readonly string Value;

        public StringParam(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }

    [SuppressMessage("Design", "CA1051:Do not declare visible instance fields")]
    public readonly struct TypeParam
    {
        public readonly string Name;
        [NotNull]
        public readonly Type Type;

        public TypeParam(string name, [NotNull] Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
