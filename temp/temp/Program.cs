// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("input a number:");
string input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{
    float celsius = float.Parse(input);
    float kelvin = celsius + 273.15f;
    Console.WriteLine(kelvin);
}