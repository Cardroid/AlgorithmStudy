using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.Problems._2108
{
    class _2064
    {
        static void Main()
        {
            // 초기화
            int testCaseCount = int.Parse(Console.ReadLine());
            byte[][] ipAddressArray = new byte[testCaseCount][];
            byte[] networkMask = new byte[4] { 0, 0, 0, 0 };
            byte[] networkAddr = new byte[4] { 0, 0, 0, 0 };

            for (int t = 0; t < testCaseCount; t++)
            {
                ipAddressArray[t] = new byte[4];
                string[] ipStr = Console.ReadLine().Split('.');

                for (int i = 0; i < 4; i++)
                {
                    ipAddressArray[t][i] = byte.Parse(ipStr[i]);
                }
            }

            // 각 IP 간 다른 비트를 가질 경우 글자 'E'로 마킹
            char[] maskFillter = null;
            for (int t = 0; t < testCaseCount; t++)
            {
                string temp = "";
                for (int i = 0; i < 4; i++)
                {
                    temp += Convert.ToString(ipAddressArray[t][i], 2).PadLeft(8, '0');
                }

                char[] ipBit = temp.ToCharArray();

                if (t == 0)
                    maskFillter = ipBit;
                else
                {
                    for (int j = 0; j < 32; j++)
                    {
                        if (maskFillter[j] != ipBit[j])
                            maskFillter[j] = 'E';
                    }
                }
            }
            for (int i = 1; i < 32; i++)
            {
                if (maskFillter[i - 1] == 'E')
                    maskFillter[i] = 'E';
            }

            // 네트워크 마스크 생성
            for (int i = 0; i < 4; i++)
            {
                networkMask[i] = Convert.ToByte(new string(maskFillter[(i * 8)..((i + 1) * 8)]).Replace('0', '1').Replace('E', '0'), 2);
            }
            
            // AND 연산으로 네트워크 주소 계산
            for (int i = 0; i < 4; i++)
            {
                networkAddr[i] = (byte)(networkMask[i] & ipAddressArray[0][i]);
            }

            Console.WriteLine(string.Join('.', networkAddr));
            Console.WriteLine(string.Join('.', networkMask));
        }
    }
}
