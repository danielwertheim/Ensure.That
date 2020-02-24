using System;

namespace EnsureThat
{
    public struct EnsureOptions
    {
        /// <summary>
        /// If defined, this exception will be thrown instead of the
        /// standard exceptions for the particular ensure method.
        /// Assign using <see cref="WithException"/>.
        /// </summary>
        public Exception CustomException { get; private set; }

        /// <summary>
        /// If defined, and no <see cref="CustomException"/> has been defined,
        /// this message will be used instead of the standard message for the
        /// particular ensure method.
        /// Assign using <see cref="WithMessage"/>.
        /// </summary>
        public string CustomMessage { get; private set; }

        public EnsureOptions WithException(Exception ex)
        {
            CustomException = ex;

            return this;
        }

        public EnsureOptions WithMessage(string message)
        {
            CustomMessage = message;

            return this;
        }
    }
}