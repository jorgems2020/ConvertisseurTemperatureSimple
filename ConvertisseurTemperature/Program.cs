using System;

class Programme
{
    static void Main()
    {
        // Variable pour stocker la température en Celsius
        double temperatureCelsius;

        Console.Write("Entrez la température en Celsius : ");
        temperatureCelsius = Convert.ToDouble(Console.ReadLine());

        // Conversion en Fahrenheit
        double temperatureFahrenheit = (temperatureCelsius * 9 / 5) + 32;

        // Conversion en Kelvin
        double temperatureKelvin = temperatureCelsius + 273.15;

        Console.WriteLine($"Température en Fahrenheit : {temperatureFahrenheit} °F");
        Console.WriteLine($"Température en Kelvin : {temperatureKelvin} K");
    }
}
