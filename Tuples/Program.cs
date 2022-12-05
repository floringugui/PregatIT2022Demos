// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var calculations = Calculate(1, 4);

Console.WriteLine($"Average: {calculations.Average}; Max: {calculations.Max}; Min: {calculations.Min}");



(double Average, double Max, double Min) Calculate(double firstValue, double secondValue)
{
    double average = (firstValue + secondValue) / 2;
    
    var max = firstValue >= secondValue
        ? firstValue
        : secondValue;

    var min = firstValue >= secondValue
        ? secondValue
        : firstValue;


    return (average, max, min);

}

//public class CalculationResults
//{
//    public double Average { get; set; }   
//    public double Max { get; set; }
//    public double Min { get; set; }
//}