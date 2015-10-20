using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    interface IAlgorithm<T>
    {
        void Sort(IList<T> list, Comparer<T> comparer);
    }
}
