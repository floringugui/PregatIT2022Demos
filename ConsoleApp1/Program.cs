// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var objArray = new object[3];

objArray[0] = 1;
objArray[1] = "2";
objArray[2] = new object();

int[,] matrice = new int[3,4];

int[][] multidimentionalArray = new int[3][];






var array1 = new[] { 1, 2, 3 };

for (var i = 0; i< array1.Length; i++)
{
    Console.WriteLine(array1[i]);
}

Array.Clear(array1);


foreach (var item in array1)
{
    Console.WriteLine(item);
}

Console.ReadLine();