using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureThat
{
    public readonly struct Param<T>
    {
        public readonly string Name;
        public readonly T Value;
        public readonly OptsFn OptsFn;

        public Param(string name, T value, OptsFn optsFn = null)
        {
            Name = name;
            Value = value;
            OptsFn = optsFn;
        }
    }

    public readonly struct StringParam
    {
        public readonly string Name;
        public readonly string Value;
        public readonly OptsFn OptsFn;

        public StringParam(string name, string value, OptsFn optsFn = null)
        {
            Name = name;
            Value = value;
            OptsFn = optsFn;
        }
    }

    public readonly struct TypeParam
    {
        public readonly string Name;
        [NotNull]
        public readonly Type Type;
        public readonly OptsFn OptsFn;

        public TypeParam(string name, [NotNull] Type type, OptsFn optsFn = null)
        {
            Name = name;
            Type = type;
            OptsFn = optsFn;
        }
    }
}
