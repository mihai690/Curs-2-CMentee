using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Mentee
{
    class Exercitiu8
    /*
     * Folosind instructiunea switch scrieti un program care sa afiseze ziua saptamanii in functie de numarul acesteia. 
     * De exemplu : ziua 1 este echivalenta zilei “Luni”, ziua 2 este “Marti” etc.
     */
    {
        static void Main(string[] args)
        {
            int x = 1;
            switch (1)
            {
                case 1:
                    Console.WriteLine("LUNI"); break;
                case 2:
                    Console.WriteLine("MARTI"); break;
                case 3:
                    Console.WriteLine("MIERCURI"); break;
                case 4:
                    Console.WriteLine("JOI"); break;
                case 5:
                    Console.WriteLine("VINERI"); break;
                case 6:
                    Console.WriteLine("SAMBATA"); break;
                case 7:
                    Console.WriteLine("DUMINICA"); break;
                default:
                    Console.WriteLine("Comanda invalida"); 
            }
        }
    }
}
