using Xunit;

namespace EnsureThat.Tests.UnitTests
{
    public class ParamCreationTests : UnitTestBase
    {
        [Fact]
        public void WhenThat_IsCalledWithValue_ThenParamCouldBeCreated()
        {
            var param = Ensure.That("My string");

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal("My string", param.Value);
        }

        [Fact]
        public void WhenThat_IsCalledWithValueAndName_ThenParamCouldBeCreated()
        {
            var param = Ensure.That("My string", "theString");

            Assert.Equal("theString", param.Name);
            Assert.Equal("My string", param.Value);
        }

        [Fact]
        public void WhenThatTypeFor_IsCalledWithType_ThenParamCouldBeCreated()
        {
            var param = Ensure.ThatTypeFor("My string");

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal(typeof(string), param.Type);
        }

        [Fact]
        public void WhenThatTypeFor_IsCalledWithTypeAndName_ThenParamCouldBeCreated()
        {
            var param = Ensure.ThatTypeFor("My string", "theString");

            Assert.Equal("theString", param.Name);
            Assert.Equal(typeof(string), param.Type);
        }
    }
}