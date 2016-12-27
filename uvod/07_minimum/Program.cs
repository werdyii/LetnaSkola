using System;

namespace LetnaSkola
{
    class Minimum
    {
        static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            var aLine = sLine.Split(' ', ',');
            int min = int.Parse(aLine[0]);
            for (int i = 1; i < aLine.Length; i++)
            {
                //int iTest = int.Parse(aLine[i]); 
                if (int.Parse(aLine[i]) < min) min = int.Parse(aLine[i]);
            }
            Console.WriteLine(min);
        }
    }
}
