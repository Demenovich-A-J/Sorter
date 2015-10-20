using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class ShellSort<T> : IAlgorithm<T>
    {
        public void Sort(IList<T> list, Comparer<T> comparer)
        {
            int j;
            int step = list.Count / 2;
            while (step > 0)
            {
                for (int i = 0; i < (list.Count - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (comparer.Compare(list[j], list[j + 1]) > 0))
                    {
                        var tmp = list[j];
                        list[j] = list[j + step];
                        list[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
    }
}
