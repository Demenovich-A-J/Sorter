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
 
                // Находим разделительный элемент в середине массива
                mid = list[(a + b) / 2];
 
                // Обходим массив
                while (A <= B)
                {
                    /* Находим элемент, который больше или равен
                    * разделительному элементу от левого индекса.
                    */
                    while ((A < b) && (comparer.Compare(list[A] , mid) < 0)) ++A;
 
                    /* Находим элемент, который меньше или равен
                     * разделительному элементу от правого индекса.
                     */
                    while ((B > a) && (comparer.Compare(list[B], mid) > 0)) --B;
 
                    // Если индексы не пересекаются, меняем
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
 
                /* Если правый индекс не достиг левой границы массива,
                 * нужно повторить сортировку левой части.
                 */
                if (a < B) QuickSort1(list, a, B, comparer);
 
                /* Если левый индекс не достиг правой границы массива,
                 * нужно повторить сортировку правой части.
                 */
                if (A < b) QuickSort1(list, A, b, comparer);
 
            }
        }

        public void Sort(IList<T> list, Comparer<T> comparer)
        {
            QuickSort1(list, 0, list.Count - 1, comparer);
        }
    }
}
