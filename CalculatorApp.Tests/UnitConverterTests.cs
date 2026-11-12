using System.Reflection;
using xUnit;

public class UnitConverterTests
{

    //Test for Kilometers to  Miles
    [Theory]
    [InlineData(1.609344, 1.0)]
    [InlineData(0.0,0.0)]
    [InlineData(3.218688,2.0)]

    public void KilometersToMiles_ConvertsCorrectly(double kilometres, double expectedMiles)
    {
        double result = UnitConverter.KilometersToMiles(kilometres);
        Asssert.Equal(expectedMiles,result,precision: 6);
    }


//Test for Miles to Kilometers
    [Theory]
    [InlineData( 1.0 , 1.609344)]
    [InlineData(0.0 , 0.0)]
    [InlineData(2.0 , 3.218688)]
    
    public void MilesToKilometers_ConvertsCorrectly(double miles, double expectedKilometres)
    {
        double result = UnitConverter.MilesToKilometers(miles);
        Assert.Equal(expectedKilometres, result, precision: 6);
    }

    //Test for Celsius to Fahrenheit
    [Theory]
    [InlineData( 0.0 , 32.0)]
    [InlineData(100.0 , 212.0)]
    [InlineData(-40.0 , -40.0 )]

    public void CelsiusToFahrenheit_ConvertsCorrectly(double celsius, double expectedFahrenheit)
    {
        double result = UnitConvert.CelsiusToFahrenheit(celsius);
        Assert.Equal(expectedFahrenheit, result);
    }


// Test for Fahrenheit to celsius
    [Theory]
    [InlineData(32.0, 0.0  )]
    [InlineData(212.0 ,100.0  )]
    [InlineData(-40.0 , -40.0 )]
    public void FahrenheitToCelsius_ConvertCorrectly(double fahrenheit, double expectedCelsius)
    {
        double result = unitConverter.FahrenheitToCelsius(fahrenheit);
        Assert.Equal(expectedCelsius,  result);
    }


    // test to convert ghs to usd
    [Theory]
    [InlineData(600,15,400)]
    [InlineData(0,15,0)]
    [InlineData(300,10,30)]
    [InlineData(150,7.5,20)]

    public void GhsToUsd_ConvertCorrectly(decimal ghs, decimal rate, decimal expectedUsd)
    {
        double result = UnitConverter.GhsToUsd(ghs, rate);
        Assert.Equal(expectedUsd, result);
    }

    [Fact]
    public void GhsToUsd_ZeroRate_ThrowsArgumentOutOfRangeException()
    {
        AAssert.Throws<ArgumentOutOfRangeException>(() =>UnitConverter.GhsToUsd(100,0));
    }

    [Fact]
    public void GhsToUsd_NegativeRate_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=> UnitConverter.GhsToUsd(100, -5));
    }
}