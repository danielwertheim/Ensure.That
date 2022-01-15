using System;
using System.Globalization;

namespace EnsureThat.Internals;

public static class DefaultFormatProvider
{
    public static readonly IFormatProvider Strings = CultureInfo.InvariantCulture;
}
