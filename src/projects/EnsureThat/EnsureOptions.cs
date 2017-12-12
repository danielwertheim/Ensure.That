using System;

namespace EnsureThat
{
    public struct EnsureOptions
    {
        /// <summary>
        /// If defined, this exception will be thrown instead of the
        /// standard exceptions for the particular ensure method.
        /// </summary>
        public Exception CustomException;

        /// <summary>
        /// If defined, and no <see cref="CustomException"/> has been defined,
        /// this message will be used instead of the standard message for the
        /// particular ensure method.
        /// </summary>
        public string CustomMessage;

        public EnsureOptions WithMessage(string message)
        {
            CustomMessage = message;

            return this;
        }

        public EnsureOptions WithException(Exception ex)
        {
            CustomException = ex;

            return this;
        }
    }
}