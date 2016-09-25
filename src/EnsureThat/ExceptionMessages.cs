namespace EnsureThat
{
    public class ExceptionMessages
    {
        public static string EnsureExtensions_IsNotTrue { get; private set; } = "Expected an expression that evaluates to true.";
        public static string EnsureExtensions_IsNotFalse { get; private set; } = "Expected an expression that evaluates to false.";
        public static string EnsureExtensions_IsEmptyCollection { get; private set; } = "Empty collection is not allowed.";
        public static string EnsureExtensions_SizeIs_Wrong { get; private set; } = "Expected size '{0}' but found '{1}'.";
        public static string EnsureExtensions_Is_Failed { get; private set; } = "Value '{0}' is not '{1}'.";
        public static string EnsureExtensions_IsNot_Failed { get; private set; } ="Value '{0}' is '{1}', which was not expected.";
        public static string EnsureExtensions_IsNotLt { get; private set; } = "value '{0}' is not lower than limit '{1}'.";
        public static string EnsureExtensions_IsNotLte { get; private set; } = "value '{0}' is not lower than or equal to limit '{1}'.";
        public static string EnsureExtensions_IsNotGt { get; private set; } = "value '{0}' is not greater than limit '{1}'.";
        public static string EnsureExtensions_IsNotGte { get; private set; } = "value '{0}' is not greater than or equal to limit '{1}'.";
        public static string EnsureExtensions_IsNotInRange_ToLow { get; private set; } = "value '{0}' is < min '{1}'.";
        public static string EnsureExtensions_IsNotInRange_ToHigh { get; private set; } = "value '{0}' is > max '{1}'.";
        public static string EnsureExtensions_IsNotNull { get; private set; } = "Value can not be null.";
        public static string EnsureExtensions_IsNotNullOrWhiteSpace { get; private set; } = "The string can't be left empty, null or consist of only whitespaces.";
        public static string EnsureExtensions_IsNotNullOrEmpty { get; private set; } = "The string can't be null or empty.";
        public static string EnsureExtensions_IsNotInRange_ToShort { get; private set; } = "The string is not long enough. Must be between '{0}' and '{1}' but was '{2}' characters long.";
        public static string EnsureExtensions_IsNotInRange_ToLong { get; private set; } = "The string is too long. Must be between '{0}' and  '{1}'. Must be between '{0}' and '{1}' but was '{2}' characters long.";
        public static string EnsureExtensions_NoMatch { get; private set; } = "value '{0}' does not match '{1}'";
        public static string EnsureExtensions_IsNotOfType { get; private set; } = "The param is not of expected type: '{0}'.";
        public static string EnsureExtensions_IsNotClass_WasNull { get; private set; } = "The param was expected to be a class, but was NULL.";
        public static string EnsureExtensions_IsNotClass { get; private set; } = "The param was expected to be a class, but was type of: '{0}'.";
        public static string EnsureExtensions_InvalidOperationException { get; private set; } = "Could not perform operation due to invalid state of '{0}'.";
        public static string EnsureExtensions_IsEmptyGuid { get; private set; } = "Empty Guid is not allowed.";
        public static string EnsureExtensions_ContainsKey { get; private set; } = "Key '{0}' does not exist.";
        public static string EnsureExtensions_AnyPredicateYieldedNone { get; private set; } = "The predicate did not match any elements.";
        public static string EnsureExtensions_IsNotGuid { get; private set; } = "Value '{0}' is not a valid GUID.";
    }
}