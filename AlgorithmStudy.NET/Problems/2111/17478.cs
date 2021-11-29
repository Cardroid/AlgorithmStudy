using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _17478
    {
        static void Main()
        {
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");

            Func(0, max);
        }

        const string q1 = "\"재귀함수가 뭔가요?\"";
        const string q2 = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
        const string q3 = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
        const string q4 = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
        const string m = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
        const string a = "라고 답변하였지.";

        static void Func(int depth, int max)
        {
            string padding = new('_', depth * 4);

            if (depth == max)
            {
                Console.WriteLine(padding + q1);
                Console.WriteLine(padding + m);
                Console.WriteLine(padding + a);
            }
            else
            {
                Console.WriteLine(padding + q1);
                Console.WriteLine(padding + q2);
                Console.WriteLine(padding + q3);
                Console.WriteLine(padding + q4);
                Func(depth + 1, max);
                Console.WriteLine(padding + a);
            }
        }
    }
}
