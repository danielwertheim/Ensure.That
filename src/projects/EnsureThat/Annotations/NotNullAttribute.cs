// This IF should be 'any new targets we add that natively support NotNullAttribute'. Right now, that is only 2_1.
#if NET462
// ReSharper disable once CheckNamespace
namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// This is JUST so we can avoid having #if regions in each usage site.
    ///
    /// For non-supported frameworks, it may be ignored by CodeAnalysis, but allows the usage
    /// sites to avoid all having
    /// <code>
    /// #if NET462
    ///   [NotNull]
    /// #endif
    /// [OtherAttributes]
    /// public string SampleMethod() {}
    /// </code>
    /// </summary>
    internal sealed class NotNullAttribute : Attribute
    {
    }
}
#endif
