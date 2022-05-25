using System;

namespace BAEKJOON.Problems._2103_2w._1063
{
    class Program
    {
        // K = 1, S = -1

        static int[,] Board = new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0 },// A
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },// H
                // 1                   8
            };

        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int lineLength = int.Parse(s[2]);

            // 보드의 킹과 돌의 초기위치 설정
            BoardInit(s[0], s[1]);

            for (int line = 0; line < lineLength; line++)
                Move(Console.ReadLine());

            Console.WriteLine(PosEncode(GetPos(1)));
            Console.WriteLine(PosEncode(GetPos(-1)));
        }

        static void Move(string value)
        {
            int[] xy;
            int xM = 0;
            int yM = 0;

            switch (value)
            {
                case "R":
                    xM++;
                    break;
                case "L":
                    xM--;
                    break;
                case "B":
                    yM--;
                    break;
                case "T":
                    yM++;
                    break;
                case "RT":
                    xM++;
                    yM++;
                    break;
                case "LT":
                    xM--;
                    yM++;
                    break;
                case "RB":
                    xM++;
                    yM--;
                    break;
                case "LB":
                    xM--;
                    yM--;
                    break;
            }

            // 킹의 현재 위치 가져오기
            xy = GetPos(1);

            // 돌의 현재 위치 가져오기
            int[] sxy = GetPos(-1);

            // 킹의 이동시 돌과 곂치는 경우
            if (sxy[0] == xy[0] + xM && sxy[1] == xy[1] + yM)
            {
                // 돌이 체스보드의 밖으로 벗어나지 않을 때
                if (IsInnerCheck(sxy[0] + xM, sxy[1] + yM))
                {
                    // 킹과 돌의 위치 이동
                    Board[xy[0], xy[1]] = 0;
                    Board[sxy[0], sxy[1]] = 0;
                    Board[xy[0] + xM, xy[1] + yM] = 1;
                    Board[sxy[0] + xM, sxy[1] + yM] = -1;
                }
            }
            // 킹이 체스보드의 밖으로 벗어나지 않을 때
            else if (IsInnerCheck(xy[0] + xM, xy[1] + yM))
            {
                // 킹의 위치 이동
                Board[xy[0], xy[1]] = 0;
                Board[xy[0] + xM, xy[1] + yM] = 1;
            }
        }

        static bool IsInnerCheck(int x, int y) => 0 <= x && x < 8 && 0 <= y && y < 8;

        static int[] GetPos(int i)
        {
            for (int c = 0; c < Board.GetLength(0); c++)
            {
                for (int r = 0; r < Board.GetLength(1); r++)
                {
                    if (Board[c, r] == i)
                        return new int[] { c, r };
                }
            }
            return null;
        }

        static void BoardInit(string kPos, string sPos)
        {
            int[] temp = PosDecode(kPos);
            Board[temp[0], temp[1]] = 1;
            temp = PosDecode(sPos);
            Board[temp[0], temp[1]] = -1;
        }

        static int[] PosDecode(string value)
        {
            int col = 0;

            switch (value[0])
            {
                case 'A':
                    col = 0;
                    break;
                case 'B':
                    col = 1;
                    break;
                case 'C':
                    col = 2;
                    break;
                case 'D':
                    col = 3;
                    break;
                case 'E':
                    col = 4;
                    break;
                case 'F':
                    col = 5;
                    break;
                case 'G':
                    col = 6;
                    break;
                case 'H':
                    col = 7;
                    break;
            }

            return new int[] { col, int.Parse(value[1].ToString())-1 };
        }

        static string PosEncode(int[] xy)
        {
            char col = ' ';

            switch (xy[0])
            {
                case 0:
                    col = 'A';
                    break;
                case 1:
                    col = 'B';
                    break;
                case 2:
                    col = 'C';
                    break;
                case 3:
                    col = 'D';
                    break;
                case 4:
                    col = 'E';
                    break;
                case 5:
                    col = 'F';
                    break;
                case 6:
                    col = 'G';
                    break;
                case 7:
                    col = 'H';
                    break;
            }

            return $"{col}{xy[1] + 1}";
        }
    }
}
