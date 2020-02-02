using System;

namespace C2_Mentee
{
    class Exercitiu3
    {
        static void Main(string[] args)
        {
            int a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);
            //Ce se va afisa si de ce?
            //Nu se va afisa nimic. Din cauza lipsei acoladelor, se va executa doar primul if?
        }
    }
}
