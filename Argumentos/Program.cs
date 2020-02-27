﻿using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints all arguments given in the console
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            /*
            Different solution
            foreach(string o in args){
                Console.WriteLine(o);
            }
            */

        }
    }
}
