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

        [Test]
        public void WhenThat_IsCalledWithLambdaForStringVariable_ThenParamCouldBeCreated()
        {
            var theString = "My string";

            var param = Ensure.That(() => theString);
            
            Assert.AreEqual("theString", param.Name);
            Assert.AreEqual("My string", param.Value);
        }

        [Test]
        public void WhenThat_IsCalledWithLambdaForStringField_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.StringField);

            Assert.AreEqual("item.StringField", param.Name);
            Assert.AreEqual(item.StringField, param.Value);
        }

        [Test]
        public void WhenThat_IsCalledWithLambdaForStringProp_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.StringProp);

            Assert.AreEqual("item.StringProp", param.Name);
            Assert.AreEqual(item.StringProp, param.Value);
        }

        [Test]
        public void WhenThat_IsCalledWithLambdaForNestedString_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.Nested.StringProp);

            Assert.AreEqual("item.Nested.StringProp", param.Name);
            Assert.AreEqual(item.Nested.StringProp, param.Value);
        }

        private class Dummy
        {
            public string StringField = "The String field";

            public string StringProp
            {
                get { return "The String prop."; }
            }

            public Nested Nested
            {
                get { return new Nested(); }
            }
        }

        private class Nested
        {
            public string StringProp
            {
                get { return "The Nested string prop."; }
            }
        }
    }
}