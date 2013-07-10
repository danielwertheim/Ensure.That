using System;

namespace EnsureThat
{
    public class TypeParam : Param
    {
        public readonly Type Type;

        internal TypeParam(string name, Type type, Func<string> extraMessageFn = null)
            : base(name, extraMessageFn)
        {
            Type = type;
        }
    }
}