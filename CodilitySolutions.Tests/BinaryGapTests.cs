using Xunit;

namespace CodilitySolutions.Tests
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(145, 3)]
        [InlineData(72, 2)]
        [InlineData(18517, 4)]
        [InlineData(129, 6)]
        [InlineData(15, 0)]
        public void ValidateBinaryGap(int number, int longestGap)
        {
            //Arrange
            var binaryGap = new BinaryGap();

            //Act
            var result = BinaryGap.GetLongestBinaryGap(number);

            //Assert
            Assert.Equal(longestGap, result);
        }
    }
}