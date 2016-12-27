using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetnaSkola
{
    class Pyramida
    {
        static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            int n = int.Parse(sLine);

            for(int i = 1; i <= n ; i++)
            {
                for (int j = 0; j < (n - i); j++) Console.Write(" ");
                for (int j = 0; j < ((2*i)-1); j++) Console.Write("*");
                for (int j = 0; j < (n - i); j++) Console.Write(" ");
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
