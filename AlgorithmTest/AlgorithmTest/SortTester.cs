using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class SortTester
    {
        public SortTester(List<IAlgorithm<int>> algoList, int arrayLength)
        {
            AlgoList = algoList;
            ArrayLength = arrayLength;
            _nonSortedList = new List<int>(ArrayLength);

            for (int i = 0; i < ArrayLength; i++)
            {
                _nonSortedList.Add(new Random().Next(0,10000));
            }
        }

        public List<IAlgorithm<int>> AlgoList { get; set; }
        public int ArrayLength { get; set; }
        private List<int> _nonSortedList;

        public void TestAlgorithm()
        {
            Stopwatch timer = new Stopwatch();

            foreach (var algo in AlgoList)
            {
                List<int> list = new List<int>(_nonSortedList.AsReadOnly());

                timer.Reset();
                timer.Start();
                algo.Sort(list, Comparer<int>.Default);
                timer.Stop();
                Console.WriteLine(timer.Elapsed);
            }


        }

    }
}
