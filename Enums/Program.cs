// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var state = LifecycleStatesEnum.InReview;

if(state == LifecycleStatesEnum.InProgress)
{
    // Do something
}
else if(state == LifecycleStatesEnum.InReview)
{
    Console.WriteLine(state.ToString());
    Console.WriteLine((int)state);
}
else if (state == LifecycleStatesEnum.Closed)
{
    // Do something
}

state = LifecycleStatesEnum.Closed;


Console.ReadLine();



public enum LifecycleStatesEnum
{
    None = 0,
    Created = 10,
    InProgress = 20,
    InReview = 30,
    Closed = 40
}
