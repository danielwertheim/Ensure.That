using System;

namespace EnsureThat
{
    public delegate Exception CustomExceptionFactory(string message, string paramName);

    public readonly struct EnsureOptions
    {
        public static readonly EnsureOptions Default = new();

        /// <summary>
        /// If defined, this factory will be used to produce the exception that
        /// will be thrown instead of the standard exceptions for the particular
        /// ensure method.
        /// Assign using <see cref="WithExceptionFactory"/>.
        /// </summary>
        public CustomExceptionFactory CustomExceptionFactory { get; }

        /// <summary>
        /// If defined, and no <see cref="CustomExceptionFactory"/> has been defined,
        /// this exception will be thrown instead of the standard exceptions for the
        /// particular ensure method.
        /// Assign using <see cref="WithException"/>.
        /// </summary>
        public Exception CustomException { get; }

        /// <summary>
        /// If defined, and neither <see cref="CustomExceptionFactory"/>
        /// nor <see cref="CustomException"/> has been defined,
        /// this message will be used instead of the standard message for the
        /// particular ensure method.
        /// Assign using <see cref="WithMessage"/>.
        /// </summary>
        public string CustomMessage { get; }

        private EnsureOptions(
            CustomExceptionFactory customExceptionFactory,
            Exception customException,
            string customMessage)
        {
            CustomExceptionFactory = customExceptionFactory;
            CustomException = customException;
            CustomMessage = customMessage;
        }

        public EnsureOptions WithExceptionFactory(CustomExceptionFactory factory) =>
            new(factory,
                CustomException,
                CustomMessage);

        public EnsureOptions WithException(Exception ex)=>
            new(CustomExceptionFactory,
                ex,
                CustomMessage);

        public EnsureOptions WithMessage(string message)=>
            new(CustomExceptionFactory,
                CustomException,
                message);
    }
}
