using JetBrains.Annotations;

namespace EnsureThat
{
    using System;

    public static partial class EnsureArg
    {
        /* Possible alternative names:
         * - [ ] IsValidEnum (we have the type constraint, but it's new as of C# 7.3 so reiterating the type in the name might not be bad
         * - [ ] IsValid
         * - [ ] IsDefined (matches Enum.IsDefined -- copy/ref its xmldoc :-P)
         * - [ ] HasEnumName (under the argument that some enums may have specific NAMES but all values are valid - if int back the type for instance)
         */
        public static T IsValidEnum<T>(T value, [InvokerParameterName] string paramName = null, OptsFn optsFn = null) where T : struct, Enum
            => Ensure.Enum.IsValidEnum(value, paramName, optsFn);
    }
}