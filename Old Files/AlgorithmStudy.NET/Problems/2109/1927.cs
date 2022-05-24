using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _1927
    {
        static void Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            MinHeap minHeap = new();
            StringBuilder result = new();

            for (int i = 0; i < testCount; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                    result.AppendLine(minHeap.RemoveOne().ToString());
                else
                    minHeap.Add(n);
            }

            Console.WriteLine(result.ToString());
        }
    }

    public class MinHeap
    {
        private List<int> baseList = new();

        public void Add(int value)
        {
            baseList.Add(value);

            int i = baseList.Count - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (baseList[parent] > baseList[i])
                {
                    Swap(parent, i);
                    i = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public int RemoveOne()
        {
            if (baseList.Count == 0)
                return 0;

            int root = baseList[0];

            baseList[0] = baseList[baseList.Count - 1];
            baseList.RemoveAt(baseList.Count - 1);

            int i = 0;
            int last = baseList.Count - 1;
            while (i < last)
            {
                int child = i * 2 + 1;

                if (child < last &&
                    baseList[child] > baseList[child + 1])
                    child = child + 1;

                if (child > last ||
                   baseList[i] <= baseList[child])
                    break;

                Swap(i, child);
                i = child;
            }

            return root;
        }

        private void Swap(int i, int j)
        {
            int t = baseList[i];
            baseList[i] = baseList[j];
            baseList[j] = t;
        }
    }
}
