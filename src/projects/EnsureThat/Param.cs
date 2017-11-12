using System;

namespace EnsureThat
{
    public static class Param
    {
        public const string DefaultName = "";
    }

    public sealed class Param<T>
    {
        public readonly string Name;
        public readonly T Value;
        public Func<Param<T>, string> ExtraMessageFn;
        public Func<Param<T>, Exception> ExceptionFn;

        public Param(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}