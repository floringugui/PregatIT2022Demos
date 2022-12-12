// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DoSomethingOptionalParam(1, "2");
DoSomethingOptionalParam(1, "2", true);

DoSomethingNamedParams(1, "2");
DoSomethingNamedParams(1, "2", param3: 5);
DoSomethingNamedParams(param1: 1, param2: "2", param3: 5);



void DoSomethingOptionalParam(int param1, string param2, bool flag = false)
{
    Console.WriteLine("DoSomething");
    Console.WriteLine($"Flag value: {flag}");
}


void DoSomethingNamedParams(int param1, string param2, bool flag = false, int param3 = 0, string param4 = "")
{
    Console.WriteLine("DoSomething");
    Console.WriteLine($"Flag value: {flag}");
    Console.WriteLine($"Param3 value: {param3}");
    Console.WriteLine($"Param4 value: {param4}");
}