using System;
using JetBrains.Annotations;

namespace EnsureThat
{
    public class TypeParam : Param
    {
        [NotNull]
        public readonly Type Type;

        public TypeParam(string name, [NotNull] Type type)
            : base(name)
        {
            Type = type;
        }
    }
}