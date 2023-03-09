using Xunit;
using System;
using FluentAssertions;

namespace diagonalsum.Test;

public class UnitTest1
{
[Theory]
[InlineData(new int[] { 1, 2, 3, 4 })]
public void TestArrayInlineData(int[] intArrayEntry)
{
    for (int i=0; i < intArrayEntry.Length; i++) 
    {
        Console.WriteLine(intArrayEntry[i]);

    }
}
}