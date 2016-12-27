using System;

namespace LetnaSkola
{
    class Nenajvecsi
    {
        static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            var aLine = sLine.Split(' ', ',');

            int max = int.Parse(aLine[0]);
            int iSucet = 0;

            for (int i = 0; i != aLine.Length; i++)
            {
                iSucet += int.Parse(aLine[i]);
                if (int.Parse(aLine[i]) > max) max = int.Parse(aLine[i]);
            }

            Console.WriteLine(iSucet - max);
            //Console.ReadLine();
        }
    }
}
