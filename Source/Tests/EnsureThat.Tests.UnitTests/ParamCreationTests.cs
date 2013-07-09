using NUnit.Framework;

namespace EnsureThat.Tests.UnitTests
{
    [TestFixture]
    public class ParamCreationTests : UnitTestBase
    {
        [Test]
        public void WhenThat_IsCalledWithValue_ThenParamCouldBeCreated()
        {
            var param = Ensure.That("My string");

            Assert.AreEqual(Param.DefaultName, param.Name);
            Assert.AreEqual("My string", param.Value);
        }

        [Test]
        public void WhenThat_IsCalledWithValueAndName_ThenParamCouldBeCreated()
        {
            var param = Ensure.That("My string", "theString");

            Assert.AreEqual("theString", param.Name);
            Assert.AreEqual("My string", param.Value);
        }

        [Test]
        public void WhenThatTypeFor_IsCalledWithType_ThenParamCouldBeCreated()
        {
            var param = Ensure.ThatTypeFor("My string");

            Assert.AreEqual(Param.DefaultName, param.Name);
            Assert.AreEqual(typeof(string), param.Type);
        }

        [Test]
        public void WhenThatTypeFor_IsCalledWithTypeAndName_ThenParamCouldBeCreated()
        {
            var param = Ensure.ThatTypeFor("My string", "theString");

            Assert.AreEqual("theString", param.Name);
            Assert.AreEqual(typeof(string), param.Type);
        }
    }
}