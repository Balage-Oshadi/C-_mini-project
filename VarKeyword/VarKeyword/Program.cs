using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Initialize the variable
            var age = 23;
            Console.WriteLine(age);

            Console.WriteLine();

            var bigNumber = 90L;
            Console.WriteLine(bigNumber);

            Console.WriteLine();

            var negative = -55.2D;
            Console.WriteLine(negative);

            Console.WriteLine();

            var precision = 5.000001F;
            Console.WriteLine(precision);

            Console.WriteLine();

            var money = 14.99M;
            Console.WriteLine(money);

            Console.WriteLine();

            var name = "Oshadi";
            Console.WriteLine(name);

            Console.WriteLine();

            var letter = 'Y';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
