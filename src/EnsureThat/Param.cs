using System;

namespace EnsureThat
{
    public abstract class Param
    {
        public const string DefaultName = "";

        public readonly string Name;

        protected Param(string name)
        {
            Name = name ?? DefaultName;
        }
    }

    public class Param<T> : Param
    {
        public readonly T Value;
        public Func<Param<T>, string> ExtraMessageFn;

        public Param(string name, T value, Func<Param<T>, string> extraMessageFn = null) : base(name)
        {
            Value = value;
            ExtraMessageFn = extraMessageFn;
        }
    }
}