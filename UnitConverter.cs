public static class UnitConvertor
{
    public const double KilometersPerMile = 1.609344;

    public static double KilometersToMiles (double kilometers) => kilometers / KilometersPerMile;

    public static double MilesToKilometers(double miles) => 
    miles * KilometersPerMile;

    public static double CeliusToFahrenheit(double celsius) =>
    celsius * 9.0 / 5.0 + 32.0;

    public static double FahrenheitToCelsius(double fahrenheit) =>
    (fahrenheit - 32.0) * 5.0 /9.0;

    public static decimal GhsToUsd(decimal ghs, decimal rateGhsPerUsd)
    {
        if(rateGhsPerUsd <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(rateGhsPerUsd),
                "Exhange rate must be greater than zero."
            );
        }

        return ghs / rateGhsPerUsd;
    }
}