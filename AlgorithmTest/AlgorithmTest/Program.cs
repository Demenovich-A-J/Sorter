using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charList = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'a', 'd', 's', 'e' 
            };

            var algo3 = new QuickSort<char>();

            algo3.Sort(charList, Comparer<char>.Default);

            foreach (var v in charList)
            {
                Console.WriteLine(v);
            }
        }
    }
}
