using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 3;
            
            // 10 / 3 = 3 reminder 1
            // 3 x 3 = 9, 1 left over to get to 10

            Console.WriteLine(firstNumber / secondNumber);
            Console.WriteLine(firstNumber % secondNumber);

            Console.ReadLine();
        }
    }
}
