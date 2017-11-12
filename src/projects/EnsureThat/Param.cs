using System;

namespace EnsureThat
{
    public static class Param
    {
        public const string DefaultName = "";
    }

    public struct Param<T>
    {
        public readonly string Name;
        public readonly T Value;
        public readonly Func<Param<T>, string> ExtraMessageFn;
        public readonly Func<Param<T>, Exception> ExceptionFn;

        public Param(
            string name,
            T value,
            Func<Param<T>, string> extraMessageFn = null,
            Func<Param<T>, Exception> exceptionFn = null)
        {
            Name = name;
            Value = value;
            ExtraMessageFn = extraMessageFn;
            ExceptionFn = exceptionFn;
        }
    }
}