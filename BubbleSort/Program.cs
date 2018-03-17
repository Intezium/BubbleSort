using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = list.Count - 1; j > i; j--)
                    if (comparer.Compare(list[j], list[j - 1]) == -1)
                    {
                        T temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
        }

        static void Main(string[] args)
        {

        }
    }
}
