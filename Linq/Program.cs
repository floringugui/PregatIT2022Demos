using System.Linq;

namespace Linq
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenIntsLinqExpression = from x in intList
                                         where x % 2 == 0
                                         select x;

            foreach (var evenInt in evenIntsLinqExpression)
            {
                Console.WriteLine(evenInt);
            }

            var evenIntsLinqMethod = intList
                .Where(x => x % 2 == 0)
                .Select(x => x);

            foreach (var evenInt in evenIntsLinqMethod)
            {
                Console.WriteLine(evenInt);
            }
        }
    }
}