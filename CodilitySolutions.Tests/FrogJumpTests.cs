using Xunit;

namespace CodilitySolutions.Tests
{
    public class FrogJumpTests
    {
        [Theory]
        [InlineData(2, 10, 5, 2)]
        [InlineData(1, 10, 1, 9)]
        [InlineData(30, 80, 15, 4)]
        public void ValidateFrogJump_ShouldReturnOK(int start, int end, int leap, int expectedResult)
        {
            //Arrange
            var frogJump = new FrogJump();

            //Act
            var result = frogJump.CalculateJumps(start, end, leap);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}