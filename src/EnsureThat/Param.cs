using System;

namespace EnsureThat
{
    public abstract class Param
    {
        public const string DefaultName = "";
        public Func<string> ExtraMessageFn;

        public readonly string Name;

        protected Param(string name, Func<string> extraMessageFn = null)
        {
            Name = name;
            ExtraMessageFn = extraMessageFn;
        }
    }

    public class Param<T> : Param
    {
        public readonly T Value;

        public Param(string name, T value, Func<string> extraMessageFn = null)
            : base(name, extraMessageFn)
        {
            Value = value;
        }
    }
}