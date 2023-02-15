using Xunit;
using FluentAssertions;

namespace greet.Test;


public class UnitTest1
{
    [Theory(DisplayName = "Deve retornar \"Olá, Mundo!\"")]
    [InlineData("Olá, Mundo!")]
    public void Test1(string expected)
    {
        var actual = Class1.Greet();
        actual.Should().Be(expected);
    }
}