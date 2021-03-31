using System;

namespace EnsureThat
{
    public delegate Exception CustomExceptionFactory(string message, string paramName);

    public struct EnsureOptions
    {
        /// <summary>
        /// If defined, this factory will be used to produce the exception that
        /// will be thrown instead of the standard exceptions for the particular
        /// ensure method.
        /// Assign using <see cref="WithExceptionFactory"/>.
        /// </summary>
        public CustomExceptionFactory CustomExceptionFactory { get; private set; }

        /// <summary>
        /// If defined, and no <see cref="CustomExceptionFactory"/> has been defined,
        /// this exception will be thrown instead of the standard exceptions for the
        /// particular ensure method.
        /// Assign using <see cref="WithException"/>.
        /// </summary>
        public Exception CustomException { get; private set; }

        /// <summary>
        /// If defined, and neither <see cref="CustomExceptionFactory"/>
        /// nor <see cref="CustomException"/> has been defined,
        /// this message will be used instead of the standard message for the
        /// particular ensure method.
        /// Assign using <see cref="WithMessage"/>.
        /// </summary>
        public string CustomMessage { get; private set; }

        public EnsureOptions WithExceptionFactory(CustomExceptionFactory factory)
        {
            CustomExceptionFactory = factory;

            return this;
        }

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
