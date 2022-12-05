// See https://aka.ms/new-console-template for more information
using Records;

Console.WriteLine("Hello, World!");

var demoRecord = new DailyTemperature(1, 2);



DailyTemperature[] data = new DailyTemperature[]
{
    new DailyTemperature(HighTemp: 57, LowTemp: 30),
    new DailyTemperature(60, 35),
    new DailyTemperature(63, 33),
    new DailyTemperature(68, 29)
};

foreach (var dataItem in data)
{
    Console.WriteLine($"HighTemp: {dataItem.HighTemp}; LowTemp: {dataItem.LowTemp}; Mean: {dataItem.Mean}");
}




