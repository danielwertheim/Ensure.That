using System;

namespace EnsureThat
{
    public class TypeParam : Param
    {
        public readonly Type Type;

        public TypeParam(string name, Type type)
            : base(name)
        {
            Type = type;
        }
    }
}