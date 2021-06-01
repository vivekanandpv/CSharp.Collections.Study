using System;
using System.Collections.Generic;

namespace CSharp.Collections.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 14, 85, 74, 56 };   //  collection initializer

            //  This is the iterator pattern
            //  https://en.wikipedia.org/wiki/Iterator_pattern#C#
            IEnumerator<int> enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


            //  this is a syntactical sugar
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
