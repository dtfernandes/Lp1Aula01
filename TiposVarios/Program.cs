using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Integer vars 
            int inteiro;
            uint unsignedInt = 9u;
            byte test = 0b00000010;

            inteiro = 0;

            //Print Integer vars 
            Console.WriteLine(test);
            Console.WriteLine(unsignedInt);
            Console.WriteLine(inteiro);

            //Declare Real vars 
            float myFloat = 99.9999f;
            double myDouble = 1e-20;

            //Print Real vars 
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);


        }
    }
}
