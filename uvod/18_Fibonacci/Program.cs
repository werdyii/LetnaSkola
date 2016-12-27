using System;
using System.Collections.Generic;

namespace LetnaSkola
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            int n = int.Parse(sLine);

            var generator = new FibonacciGenerator();
            foreach (var digit in generator.Generate(n))
            {
                if (digit > 0) Console.Write(" ");
                Console.Write(digit);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class FibonacciGenerator
    {
        private Dictionary<int, int> _cache = new Dictionary<int, int>();

        //private int Fib(int n) => n < 2 ? n : FibValue(n - 1) + FibValue(n - 2);
        private int Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else {
                return FibValue(n - 1) + FibValue(n - 2);
            }
        }

        public int FibValue(int n)
        {
            if (!_cache.ContainsKey(n))
            {
                _cache.Add(n, Fib(n));
                //Console.Write(n + " ");
            }

            return _cache[n];
        }

        public IEnumerable<int> Generate(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return FibValue(i);
            }
        }
    }

}
