using Xunit;

namespace diagonalsum.test;

public class UnitTest1
{
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void Test1(int [] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Assert.Equal(array[i], Program.fromArrayToTwoDimensionalArrayOp1(array, 3, 3)[i / 3, i % 3]);
        }

    }
}