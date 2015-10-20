using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class QuickSort<T>: IAlgorithm<T>
    {
        void QuickSort1(IList<T> list, int a, int b, Comparer<T> comparer)
        {
            int A = a;
            int B = b;
            T mid;
 
            if (b > a)
            {
 
                mid = list[(a + b) / 2];
 
                while (A <= B)
                {
                    while ((A < b) && (comparer.Compare(list[A] , mid) < 0)) ++A;
 
                    while ((B > a) && (comparer.Compare(list[B], mid) > 0)) --B;
 
                    if (A <= B)
                    {
                        T temp;
                        temp = list[A];
                        list[A] = list[B];
                        list[B] = temp;
 
                        ++A;
                        --B;
                    }
                }
 
                if (a < B) QuickSort1(list, a, B, comparer);
 
                if (A < b) QuickSort1(list, A, b, comparer);
 
            }
        }

        public void Sort(IList<T> list, Comparer<T> comparer)
        {
            QuickSort1(list, 0, list.Count - 1, comparer);
        }
    }
}
