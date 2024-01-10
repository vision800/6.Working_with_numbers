using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing a number
            Console.WriteLine(20);

            //adding two numbers
            Console.WriteLine(30 + 90);

            //subtracting two numbers
            Console.WriteLine(30 + 10);

            //multiplying two numbers
            Console.WriteLine(3*9);

            //dividing two numbers
            Console.WriteLine(30/10);

            //modulus of two numbers
            Console.WriteLine(11%5);

            //adding multiple operations
            Console.WriteLine(5+8*7);

            int num = 6;
            Console.WriteLine("before increment : "+num);
            //increment number by 1
            num++;
            //
            Console.WriteLine("After increment : " + num);

            //Math functions

            //absolte functions gets positive numbers only
            Console.WriteLine(Math.Abs(-4));

            //power functions get the value of number to the power of another number
            Console.WriteLine(Math.Pow(2, 4));


            Console.WriteLine(Math.Max(5, 6));
            Console.Read();

        }
    }
}
