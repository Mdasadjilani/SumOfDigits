using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Int32.Parse(Console.ReadLine());

            int backupvalue = number;
            int sum = 0;
            int result = 0;
            while (number != 0)
            {
                result = number % 10;
                sum = sum + result;
                number = number / 10;
            }
            Console.WriteLine("sum of digits {0} is {1}", backupvalue, sum);
            Console.ReadLine();
        }
    }
}
