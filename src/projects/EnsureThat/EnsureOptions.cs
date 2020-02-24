using System;

namespace EnsureThat
{
    public struct EnsureOptions
    {
        /// <summary>
        /// If <see cref="CustomExceptionFactory"/> is defined, this exception will be thrown instead of the
        /// standard exceptions for the particular ensure method.
        /// Assign using <see cref="WithException(Exception)"/>.
        /// </summary>
        public Exception CustomException => CustomExceptionFactory(string.Empty);

        /// <summary>
        /// If defined, this exception will be thrown instead of the
        /// standard exceptions for the particular ensure method.
        /// Assign using <see cref="WithException(Func&lt;string,Exception&gt;)"/>.
        /// </summary>
        public Func<string, Exception> CustomExceptionFactory { get; private set; }

        /// <summary>
        /// If defined, and no <see cref="CustomExceptionFactory"/> has been defined,
        /// this message will be used instead of the standard message for the
        /// particular ensure method.
        /// Assign using <see cref="WithMessage"/>.
        /// </summary>
        public string CustomMessage { get; private set; }

        public EnsureOptions WithException(Exception ex)
        {
            CustomExceptionFactory = x => ex;

            return this;
        }

        public EnsureOptions WithException(Func<string, Exception> factory)
        {
            CustomExceptionFactory = factory;

            return this;
        }

        public EnsureOptions WithMessage(string message)
        {
            CustomMessage = message;

            return this;
        }
    }
}