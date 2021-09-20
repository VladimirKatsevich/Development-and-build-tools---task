using System;

namespace SequenceOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxKolElementov = 0;
            int kolElementov;
            Console.WriteLine("Введите последовательность символов в строку");
            string vvod = Console.ReadLine();
            char[] vvodstroki = vvod.ToCharArray();
            if (vvod == String.Empty) {
                kolElementov = 0;
            }else
                kolElementov = 1;
            for (int i = 0; i < vvodstroki.Length - 1; i++) {
                if (vvodstroki[i] != vvodstroki[i + 1])
                {
                    kolElementov++;
                }
                else if (vvodstroki[i] == vvodstroki[i + 1]) {

                    maxKolElementov += kolElementov;
                    kolElementov = 0;
                }
            }
            if (kolElementov > maxKolElementov)
            {
                Console.WriteLine($"Колличество неодинаковых символов в строке {kolElementov}");

            }
            else
                Console.WriteLine($"Колличество неодинаковых символов в строке {maxKolElementov}");

            Console.ReadLine();


        }

    }
}
