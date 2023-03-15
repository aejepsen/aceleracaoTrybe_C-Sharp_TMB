namespace car.Test;

using Xunit;
using FluentAssertions;


public class CarTest
{
    [Fact]
    public void ShouldBeAbleToConvertTopSpeed()
    {
        // Arrange
        var car = new Car();
        car.TopSpeed = 100;

        // Act
        var topSpeed = car.TopSpeed;
        var topSpeedMph = car.TopSpeedMph;

        // Assert
        topSpeed.Should().Be(100);
        topSpeedMph.Should().BeApproximately(62.12, 0.01);

    }

    [Fact]

    public void ShouldBeAbleToConvertKphToMph()
    {
        // Arrange
        var kph = 100;

        // Act
        var mph = Car.KphToMph(kph);

        // Assert
        mph.Should().BeApproximately(62.12, 0.01);
    }
}