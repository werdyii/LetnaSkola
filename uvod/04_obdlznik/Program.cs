using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            var aLine = sLine.Split(' ', ',');
            int n = int.Parse(aLine[0]);
            int m = int.Parse(aLine[1]);
            int iObvod = 2*(m+n);
            int iObsah = m * n;
            Console.WriteLine(iObvod);
            Console.WriteLine(iObsah);
        }
    }
}
