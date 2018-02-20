using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Param
    {
        public static readonly string DefaultName = string.Empty;
    }

    public struct Param<T>
    {
        public readonly string Name;
        public readonly T Value;
        public readonly OptsFn OptsFn;

        public Param(string name, T value, OptsFn optsFn = null)
        {
            Name = name ?? Param.DefaultName;
            Value = value;
            OptsFn = optsFn;
        }
    }

    public struct TypeParam
    {
        public readonly string Name;
        [NotNull]
        public readonly Type Type;
        public readonly OptsFn OptsFn;

        public TypeParam(string name, [NotNull] Type type, OptsFn optsFn = null)
        {
            Name = name ?? Param.DefaultName;
            Type = type;
            OptsFn = optsFn;
        }
    }
}