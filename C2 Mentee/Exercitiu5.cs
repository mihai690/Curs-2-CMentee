using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Mentee
{
    class Exercitiu5
        /*
         * Scrieti un program care sa returneze n! (adica n = 1 * 2 * 3 * … * n), 
         * unde n < 13 este un numar natural.
         */
    {
        static void Main(string[] args) {
            int fact = 1;
            for (int i = 1; i < 13; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("n! = " + fact);
        }
    }
}
