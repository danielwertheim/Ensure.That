namespace EnsureThat.Tests.UnitTests.NumericTests
{
    public class NumericParamTestSpec<T> where T : struct
    {
        public T Limit { get; set; }

        public T LowerLimit { get; set; }

        public T UpperLimit { get; set; }

        public T Value { get; set; }
    }
}