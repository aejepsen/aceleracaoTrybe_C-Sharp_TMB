using Xunit;
using comission;
using FluentAssertions;
using System;

namespace comission.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Teste de sucesso para calculo de comisão")]
    [InlineData(100, 10)]
    [InlineData(27, 2.7)]
    [InlineData(30, 3.0)]
    public void Test1(decimal orderPrice, decimal expected)
    {
        var comission = new Comission();
        var result = comission.Calculate(orderPrice);
        result.Should().Be(expected);
        
    }
    [Theory(DisplayName = "Teste de falha para calculo de comisão")]
    [InlineData(-100)]
    [InlineData(-27)]
    [InlineData(-30)]

    public void Test2(decimal orderPrice)
    {
        var comission = new Comission();
        Action act = () => comission.Calculate(orderPrice);
        act.Should().Throw<Exception>().WithMessage("Order price cannot be negative");
    }
}