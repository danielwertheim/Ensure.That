namespace EnsureThat
{
    public delegate EnsureOptions OptsFn(EnsureOptions options, string defaultMessage = null, string paramName = null);
}