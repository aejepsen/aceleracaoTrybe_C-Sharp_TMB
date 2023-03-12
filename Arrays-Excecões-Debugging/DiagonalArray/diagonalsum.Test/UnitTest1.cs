using Xunit;
using System;
using FluentAssertions;

namespace diagonalsum.Test;

public class UnitTest1
{

[Theory]
[InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 3, 15)]
[InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, 3, 16)]


public void fromArrayToTwoDimensionalArray(int[] intArrayEntry, int lines, int colums, int expected)
{
    int[,] multDimArray = Program.fromArrayToTwoDimensionalArrayOp1(intArrayEntry, lines, colums);

    int sum = Program.getSumDiagonal(multDimArray);

    sum.Should().Be(expected);
}


// [Theory]
// [InlineData(new int[] { 1, 2, 3, 4 })]
// public void TestArrayInlineData(int[] intArrayEntry)
// {
//     for (int i=0; i < intArrayEntry.Length; i++) 
//     {
//         Console.WriteLine(intArrayEntry[i]);

//     }
// }

}