using System;
using System.Collections.Generic;
using EnsureThat;
using EnsureThat.Internals;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
    public class DefaultExceptionFactoryTests : UnitTestBase
    {
        private const string DefaultMessage = "54a170d6997c400487c177768f72aa7a";
        private const string CustomMessage = "3b3e6082d4c1482fbc775abc11a2e415";
        private const string DummyValue = "61927e885db34e08b9a7211c7eb74c36";
        private readonly Exception _exceptionFactoryException = new KeyNotFoundException();
        private readonly Exception _customException = new("036859e6693848b199575feffe17bd46");
        private readonly DefaultExceptionFactory _sut = new();

        [Fact]
        public void ArgumentException_UsesDefaults_WhenNoOptionsAreProvided()
            => _sut.ArgumentException(
                    DefaultMessage,
                    ParamName)
                .Should()
                .BeEquivalentTo(new ArgumentException(DefaultMessage, ParamName));

        [Fact]
        public void ArgumentException_UsesExceptionFactory_WhenOptionsAlsoContainsCustomExceptionAndCustomMessage()
            => _sut.ArgumentException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException)
                        .WithExceptionFactory((_, __) => _exceptionFactoryException))
                .Should()
                .Be(_exceptionFactoryException);

        [Fact]
        public void ArgumentException_UsesCustomException_WhenOptionsAlsoContainsCustomMessage()
            => _sut.ArgumentException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException))
                .Should()
                .Be(_customException);

        [Fact]
        public void ArgumentException_UsesCustomMessage_WhenOptionsHasNoOtherConfig()
            => _sut.ArgumentException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage))
                .Should()
                .BeEquivalentTo(new ArgumentException(CustomMessage, ParamName));

        [Fact]
        public void ArgumentNullException_UsesDefaults_WhenNoOptionsAreProvided()
            => _sut.ArgumentNullException(
                    DefaultMessage,
                    ParamName)
                .Should()
                .BeEquivalentTo(new ArgumentNullException(ParamName, DefaultMessage));

        [Fact]
        public void ArgumentNullException_UsesExceptionFactory_WhenOptionsAlsoContainsCustomExceptionAndCustomMessage()
            => _sut.ArgumentNullException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException)
                        .WithExceptionFactory((_, __) => _exceptionFactoryException))
                .Should()
                .Be(_exceptionFactoryException);

        [Fact]
        public void ArgumentNullException_UsesCustomException_WhenOptionsAlsoContainsCustomMessage()
            => _sut.ArgumentNullException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException))
                .Should()
                .Be(_customException);

        [Fact]
        public void ArgumentNullException_UsesCustomMessage_WhenOptionsHasNoOtherConfig()
            => _sut.ArgumentNullException(
                    DefaultMessage,
                    ParamName,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage))
                .Should()
                .BeEquivalentTo(new ArgumentNullException(ParamName, CustomMessage));

        [Fact]
        public void ArgumentOutOfRangeException_UsesDefaults_WhenNoOptionsAreProvided()
            => _sut.ArgumentOutOfRangeException(
                    DefaultMessage,
                    ParamName,
                    DummyValue)
                .Should()
                .BeEquivalentTo(new ArgumentOutOfRangeException(ParamName, DummyValue, DefaultMessage));

        [Fact]
        public void ArgumentOutOfRangeException_UsesExceptionFactory_WhenOptionsAlsoContainsCustomExceptionAndCustomMessage()
            => _sut.ArgumentOutOfRangeException(
                    DefaultMessage,
                    ParamName,
                    DummyValue,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException)
                        .WithExceptionFactory((_, __) => _exceptionFactoryException))
                .Should()
                .Be(_exceptionFactoryException);

        [Fact]
        public void ArgumentOutOfRangeException_UsesCustomException_WhenOptionsAlsoContainsCustomMessage()
            => _sut.ArgumentOutOfRangeException(
                    DefaultMessage,
                    ParamName,
                    DummyValue,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage)
                        .WithException(_customException))
                .Should()
                .Be(_customException);

        [Fact]
        public void ArgumentOutOfRangeException_UsesCustomMessage_WhenOptionsHasNoOtherConfig()
            => _sut.ArgumentOutOfRangeException(
                    DefaultMessage,
                    ParamName,
                    DummyValue,
                    (in EnsureOptions o) => o
                        .WithMessage(CustomMessage))
                .Should()
                .BeEquivalentTo(new ArgumentOutOfRangeException(ParamName, DummyValue, CustomMessage));
    }
}
