using System;

namespace EnsureThat
{
    internal static class ExceptionFactory
    {
         internal static ArgumentException CreateForParamValidation(string paramName, string message)
         {
             return new ArgumentException(message, paramName);
         }

         internal static ArgumentNullException CreateForParamNullValidation(string paramName, string message)
         {
             return new ArgumentNullException(paramName, message);
         }
    }
}