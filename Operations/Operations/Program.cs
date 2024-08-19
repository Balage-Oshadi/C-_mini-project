using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            // increment age by 1 
            age++;
            // increment age by 10 (both ways)
            //age = age + 10;
            // + * /
            //age += 10;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            string name = "Oshadi";
            name += " is Programming";
            Console.WriteLine(name);


            //Display the unicode value 
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            //first increment, then display
            Console.WriteLine(++i);
            //first display, then increment
            Console.WriteLine(i++);
            Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
