using Xunit;

namespace CodilitySolutions.Tests
{
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new[] {145, 3}, 1, new int[] {3, 145})]
        [InlineData(new[] {1, 2, 3, 4}, 6, new int[] {3, 4, 1, 2})]
        [InlineData(new[] {1, 2, 3, 4}, 0, new int[] {1, 2, 3, 4})]
        [InlineData(new[] {1, 2, 3, 4}, 4, new int[] {1, 2, 3, 4})]
        [InlineData(new[] {45, 1, 41, 3, 5}, 8, new int[] {41, 3, 5, 45, 1})]
        public void ValidateBinaryGap(int[] array, int shift, int[] expectedResult)
        {
            //Arrange
            var cyclicRotation = new CyclicRotation();

            //Act
            var result = cyclicRotation.RotateArray(array, shift);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}