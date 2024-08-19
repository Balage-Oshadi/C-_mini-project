using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConvertion
{
     class Program
    {
        static void Main(string[] args)
        {

            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            
            Console.WriteLine();

            string textBigNumber = "-90000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            Console.WriteLine();

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            Console.WriteLine();

            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            Console.WriteLine();

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            
            Console.ReadLine();
        }
    }
}
