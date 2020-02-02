using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Mentee
{
    class Extra1
    /*
 * Scrieti un program care primeste la intrare (declarati voi ca variabila) un numar de secunde 
 * si afiseaza maximul de ore, minute, secunde care este echivant ca timp cu numarul initial de secunde. 
 * De exemplu: 7384 secunde este echivalent cu 2 ore 3 minute si 4 secunde.
 */
    {
        static void Main(string[] args) {
            int sec = 7384;
            int s, m, h;

            m = sec / 60;
            s = sec % 60;
            h = m / 60;
            m = m % 60;

            Console.WriteLine(sec + " secunde reprezinta " + h + "ore " +
             +m + "minute " + s + "secunde ");
        }
    }
}
