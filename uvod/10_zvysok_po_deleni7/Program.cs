using System;

namespace LetnaSkola
{
    class Modulo7
    {
        static void Main(string[] args)
        {
            int iVstup = int.Parse(Console.ReadLine());
            if (iVstup % 7 == 0) {
                Console.WriteLine("ano");
            }
            else{
                Console.WriteLine("nie");
            }
            //Console.ReadLine();
        }
    }
}
