using Xunit;

namespace CodilitySolutions.Tests
{
    public class MissingItemTests
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 5}, 4)]
        [InlineData(new[] {1, 12, 3}, 2)]
        [InlineData(new[] {1, 1, 2, 2, 3, 3, 5, 5}, 4)]
        [InlineData(new[] {5, 1, 3, 3, 5, 5}, 2)]
        public void ShouldReturnMissingValue(int[] numberArray, int missingNumber)
        {
            //Arrange
            var missingItem = new MissingItem();

            //Act
            var result = missingItem.GetMissingItem(numberArray);

            //Assert
            Assert.Equal(missingNumber, result);
        }
    }
}