using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the max is ");
            GetMax(number1, number2);
            Console.Read();
        }
        static void GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }

            else
            {
                Console.Write(num2);
            }
        }
    }
}
