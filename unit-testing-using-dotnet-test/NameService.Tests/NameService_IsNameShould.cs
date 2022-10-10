using Xunit;
using Name.Services;

namespace Name.UnitTests.Services
{
    public class NameService_IsNameShould
    {
        private readonly NameService _nameService;

        public NameService_IsNameShould()
        {
            _nameService = new NameService();
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsName_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _nameService.IsName(value);

            Assert.False(result, $"{value} is not a name");
        }
    }
}