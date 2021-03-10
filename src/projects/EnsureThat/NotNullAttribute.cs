// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="NotNullAttribute.cs" company="Microsoft Corporation">
// //   Copyright (c) Microsoft Corporation. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

#if !NETSTANDARD2_1
namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// This is JUST so we can avoid having #if regions in each usage site
    /// </summary>
    internal sealed class NotNullAttribute : Attribute
    {
    }
}
#endif
