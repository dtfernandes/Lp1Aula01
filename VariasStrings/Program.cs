using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            double xx = 0.12345;
            int ii = 18;

            string cena1 = @"""""""""""""""""""""";
            string cenap = "abcdefghijk";
            string cena2 = $"o Marco é\t{cena1}\ttriste";

            string cena3 = "";

            char[] cena0 = cena1.ToCharArray();
            char[] cena01 = cenap.ToCharArray();

            for (int i = 0; i < cena1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    cena3 += cena0[i] + " ";
                    continue;
                }
                cena3 += cena01[i];
            }


            Console.WriteLine(cena1);
            Console.WriteLine(cena2);
            Console.WriteLine(cena3);



            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");


        }
    }
}
