using EnsureThat;
using Xunit;

namespace UnitTests
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
            Assert.Equal(typeof(string), param.Value);
        }

        [Fact]
        public void WhenThatTypeFor_IsCalledWithTypeAndName_ThenParamCouldBeCreated()
        {
            var param = Ensure.ThatTypeFor("My string", "theString");

            Assert.Equal("theString", param.Name);
            Assert.Equal(typeof(string), param.Value);
        }

        [Fact]
        public void WhenThat_IsCalledWithLambdaForStringVariable_ThenParamCouldBeCreated()
        {
            var theString = "My string";

            var param = Ensure.That(() => theString);

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal("My string", param.Value);
        }

        [Fact]
        public void WhenThat_IsCalledWithLambdaForStringField_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.StringField);

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal(item.StringField, param.Value);
        }

        [Fact]
        public void WhenThat_IsCalledWithLambdaForStringProp_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.StringProp);

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal(item.StringProp, param.Value);
        }

        [Fact]
        public void WhenThat_IsCalledWithLambdaForNestedString_ThenParamCouldBeCreated()
        {
            var item = new Dummy();

            var param = Ensure.That(() => item.Nested.StringProp);

            Assert.Equal(Param.DefaultName, param.Name);
            Assert.Equal(item.Nested.StringProp, param.Value);
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