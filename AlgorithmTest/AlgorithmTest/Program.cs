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
            SortTester tester = new SortTester(
                new List<IAlgorithm<int>>()
                {
                    new BubleSort<int>(), 
                    new QuickSort<int>(), 
                    new ShellSort<int>()
                }, 
                5000);
            tester.TestAlgorithm();
        }
    }
}
