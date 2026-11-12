using Xunit;

public class CalculatorTests
{
    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(0, 0, 0)]
    [InlineData(-1,-2,-3)]
    [InlineData(1.5, 2.5, 4.0)]
    [InlineData(-10,5,-5)]

// Test for Addition
    public void Add_ReturnsSum(double a, double b, double expected)
    {
        double result = Calculator.Add(a,b);
        Assert.Equal(expected, result);
    }


    // Test for Subtraction
    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(0, 0, 0)]
    [InlineData(-1,-2,-3)]
    [InlineData(1.5, 2.5, 4.0)]
    [InlineData(-10,5,-5)]
    public void Subtract_ReturnsDifference(double a, double b, double expected)
    {
        double result = Calculator.Subtract(a,b);
        Assert.Equal(expected, result);
    }


    //Test for Multiplication
    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(0, 0, 0)]
    [InlineData(-1,-2,-3)]
    [InlineData(-1.5, 2.0, 3.0)]
    [InlineData(-3,4,-12)]

    public void Multiply_ReturnsProduct(double a , double b, double expected)
    {
        double result = Calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }

        // test for division
[Theory]
    [InlineData(10, 2, 15)]
    [InlineData(0, 5, 0)]
    [InlineData(-1,-2,-3)]
    [InlineData(1.5, 0.5, 3.0)]
    [InlineData(-9,3,3)]

    public void Divide_ReturnsQuotient(double a , double b, double expected)
    {
        double result = Calculator.Divide(a,b);
        Assert.Equal(expected,result);
    }

}