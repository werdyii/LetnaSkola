using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            int n = int.Parse(sLine);
            if ( n < 0 ) 
                Console.WriteLine("zaporne");
            else if ( n > 0 ) 
                Console.WriteLine("kladne");
            else
                Console.WriteLine("nulove"); 
        }
    }
}
