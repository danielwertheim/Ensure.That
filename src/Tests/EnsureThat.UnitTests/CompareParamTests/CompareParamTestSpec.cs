namespace EnsureThat.UnitTests.CompareParamTests
{
    public class CompareParamTestSpec<T> where T : struct
    {
        public T Limit { get; set; }

        public T LowerLimit { get; set; }

        public T UpperLimit { get; set; }

        public T Value { get; set; }
    }
}