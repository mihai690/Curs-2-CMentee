using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Mentee
{
    class Exercitiu6
    /*
     * Scrieti un program care sa returneze minimum a trei numere intregi, 
     * folosind instructiunea if - else.
     */
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 2;
            b = 6;
            c = 4;

            if (a < b && a < c)
            {

                Console.WriteLine("Cel mai mic numar este: " + a);
            }
            else

        if (b < a && b < c)
            {

                Console.WriteLine("Cel mai mic numar este: " + b);
            }
            else

                Console.WriteLine("Cel mai mic numar este: " + c);

        }
    }
}
