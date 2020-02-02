using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Mentee
{
    class Exercitiu1
            {
        static void Main(string[] args)
        {
            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a =" +a + ", b =" +b + ", c =" +c);
            //se va afisa: a = 2; b = 5; c = 20;
        }
    }
}
