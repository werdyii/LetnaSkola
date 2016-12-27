using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sLine = Console.ReadLine().Trim();
            var aLine = sLine.Split(' ', ',');
            string sVysledok = "";

            for (int i = (aLine.Length - 1) ; i >= 0 ; i--)            
            {
                sVysledok += aLine[i]+" ";        
            }
            Console.WriteLine(sVysledok.Trim());
        }
    }
}
