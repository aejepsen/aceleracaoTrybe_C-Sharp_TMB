using System;
using Xunit;
using FluentAssertions;

namespace divisaoException.Test;

public class UnitTest1
{
   
[Theory(DisplayName = "Teste para lançamento de exceção em divisão entre dois números inteiros.")]
[InlineData(2013, 0)]
[InlineData(5, 4)]
[InlineData(5, 0)]
[InlineData(10, 2)]
public void Test1(int numberOne, int numberTwo)
{

    Action act = () => Program.DivideNumbers(numberOne, numberTwo);
    if (numberTwo == 0)
    {
        act.Should().Throw<DivideByZeroException>().WithMessage("Não pode dividir um número por zero!");
    }
    else
    {
        act.Should().NotThrow<DivideByZeroException>();
    }
}
[Theory(DisplayName = "Teste divisão entre dois números inteiros.")]
[InlineData(5, 4, 1)]
[InlineData(10, 2, 5)]

public void Test2(int numberOne, int numberTwo, int expected)
{

    var result = Program.DivideNumbers(numberOne, numberTwo);
    result.Should().Be(expected);
}
}
