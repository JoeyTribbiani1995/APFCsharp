using System;
using System.Collections.Generic;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> selector = str => str.ToUpper();

            string[] words =
            {
                "oragne",
                "apple",
                "article",
                "elephant"
            };

            IEnumerable<String> aWords = words.Select(selector);

            foreach (String word in aWords)
                Console.WriteLine(word);

            //praticing

            Func<int, int, string> totalSum = SumNumber;
            Console.WriteLine(totalSum(1, 2));



            Console.ReadKey();
        }

        private static string SumNumber(int number, int number2)
        {
            return $"Total {(number + number2)}";
        }
    }
}
