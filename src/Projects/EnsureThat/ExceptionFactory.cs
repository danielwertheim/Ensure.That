using System;

namespace EnsureThat
{
    public static class ExceptionFactory
    {
        public static ArgumentException CreateForParamValidation(Param param, string message)
        {
            return new ArgumentException(
                param.ExtraMessageFn == null 
                    ? message 
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn()),
                param.Name);
        }

        public static ArgumentNullException CreateForParamNullValidation(Param param, string message)
        {
            return new ArgumentNullException(
                param.Name, 
                param.ExtraMessageFn == null 
                    ? message 
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn()));
        }
    }
}