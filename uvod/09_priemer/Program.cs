using System;

namespace LetnaSkola
{
    class Priemer
    {
        static void Main(string[] sArgs)
        {
            string sLine = Console.ReadLine();
            var aLine = sLine.Split(' ', ',');
            int iSucet = 0;

            for (int i = 0; i != aLine.Length; i++)
            {
                iSucet += int.Parse(aLine[i]); 
            }

            float fPriemer = iSucet / aLine.Length;
            Console.WriteLine(fPriemer);
        }
    }
}
