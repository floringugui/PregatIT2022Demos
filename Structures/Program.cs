// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MathCalculation mathCalculation = new MathCalculation(3, 5);

//mathCalculation.FirstValue = 3;
//mathCalculation.SecondValue = 5;

var result = mathCalculation.Average();
Console.WriteLine(result);


readonly struct MathCalculation
{
    private readonly double FirstValue;
    private readonly double SecondValue;

    public MathCalculation(double firstValue, double secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }

    public double Average()
    {
        var average = (FirstValue + SecondValue) / 2;

        return average;
    }    
}