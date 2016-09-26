using System;

namespace EnsureThat
{
    public static class ExceptionFactory
    {
        public static ArgumentException CreateForParamValidation(Param param, string message)
            => new ArgumentException(message, param.Name);

        public static ArgumentNullException CreateForParamNullValidation(Param param, string message)
            => new ArgumentNullException(param.Name, message);

        public static InvalidOperationException CreateForInvalidOperation(Param param, string message)
            => new InvalidOperationException(string.Format(message, param.Name));

        public static ArgumentException CreateForParamValidation<T>(Param<T> param, string message)
        {
            return new ArgumentException(
                param.ExtraMessageFn == null
                    ? message
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn(param)),
                param.Name);
        }

        public static ArgumentNullException CreateForParamNullValidation<T>(Param<T> param, string message)
        {
            return new ArgumentNullException(
                param.Name,
                param.ExtraMessageFn == null
                    ? message
                    : string.Concat(message, Environment.NewLine, param.ExtraMessageFn(param)));
        }

        public static InvalidOperationException CreateForInvalidOperation<T>(Param<T> param, string message)
        {
            var msg = string.Format(message, param.Name);

            return new InvalidOperationException(
                param.ExtraMessageFn == null
                    ? msg
                    : string.Concat(msg, Environment.NewLine, param.ExtraMessageFn(param)));
        }
    }
}