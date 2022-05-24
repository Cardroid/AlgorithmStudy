using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Problems._2106_4w_019
{
    class _17608
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Stack<int> blocks = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                blocks.Push(int.Parse(Console.ReadLine()));
            }

            int result = 0;
            int lastBlock = 0;

            while (blocks.Count > 0)
            {
                int currentBlock = blocks.Pop();

                if (lastBlock < currentBlock)
                {
                    lastBlock = currentBlock;
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
