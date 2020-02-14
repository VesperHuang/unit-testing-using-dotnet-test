using Xunit;
using PrimeService;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly Prime_Service _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new Prime_Service();
        }

        // [Fact]
        // public void IsPrime_InputIs1_ReturnFalse()
        // {
        //     var result = _primeService.IsPrime(1);

        //     Assert.False(result, "1 should not be prime");
        // }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            
            Assert.False(result, $"{value} should not be prime");
        }

    }
}