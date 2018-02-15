using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    //public abstract class Param
    //{
    //    public const string DefaultName = "";

    //    public readonly string Name;
    //    public readonly OptsFn OptsFn;

    //    protected Param(string name = null, OptsFn optsFn = null)
    //    {
    //        Name = name ?? DefaultName;
    //        OptsFn = optsFn;
    //    }
    //}

    //public sealed class Param<T> : Param
    //{
    //    public readonly T Value;

    //    public Param(string name, T value, OptsFn optsFn = null)
    //        : base(name, optsFn)
    //    {
    //        Value = value;
    //    }
    //}

    //public sealed class TypeParam : Param
    //{
    //    [NotNull]
    //    public readonly Type Type;

    //    public TypeParam(string name, [NotNull] Type type)
    //        : base(name)
    //    {
    //        Type = type;
    //    }
    //}

    public static class Param
    {
        public const string DefaultName = "";
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