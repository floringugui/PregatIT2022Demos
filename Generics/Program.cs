namespace Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1 = 5, number2 = 10;
            double number3 = 7, number4 = 7.0;

            Console.WriteLine("Hello, World!");
            Calculator calculator = new Calculator();

            if (calculator.CheckEquality<int>(number1, number2))
            {
                Console.WriteLine("Int numbers are equal");
            }
            else
            {
                Console.WriteLine("Int numbers are not equal");
            }

            if (calculator.CheckEquality<double>(number3, number4))
            {
                Console.WriteLine("Double numbers are equal");
            }
            else
            {
                Console.WriteLine("Double numbers are not equal");
            }
        }
    }

    public class Calculator
    {
        //public bool CheckEquality(int number1, int number2)
        //{
        //    return number1 == number2;
        //}

        //public bool CheckEquality(double number1, double number2)
        //{
        //    return number1 == number2;
        //}

        public bool CheckEquality<T>(T number1, T number2)
        {
            return number1.Equals(number2);
        }
    }
}