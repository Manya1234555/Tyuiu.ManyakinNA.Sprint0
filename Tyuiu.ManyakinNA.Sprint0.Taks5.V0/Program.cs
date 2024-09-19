
using Tyuiu.ManyakinNA.Sprint0.Taks5.V0.Lib;

namespace Tyuiu.ManyakinNA.Sprint0.Taks5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substraction(5, 15));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(5, 5));
            Console.ReadKey();







        }

    }
}
