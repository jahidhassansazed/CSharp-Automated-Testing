using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(5, 5);

        // Assert
        Assert.Equal(10, result);
    }
}