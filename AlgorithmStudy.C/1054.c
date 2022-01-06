#include <stdio.h>

int main()
{
	int test;
	scanf("%d", &test);

	int garo, sero;
	for (int i = 0; i < test; i++) {

		scanf("%d %d", &garo, &sero);

		for (int i = 0; i < sero; i++)                    // 줄 반복 (세로)
		{
			if (i == 0 || (i == sero - 1 && sero != 1)) { // (첫 번째 줄 일 경우) 또는 (마지막 줄 이고 세로가 1이 아닐 경우)
				for (int j = 0; j < garo; j++)            // 글자 반복 (가로)
					printf("*");                          // * 출력
			}
			else {
				for (int j = 0; j < garo; j++)            // 글자 반복 (가로)
				{
					if (j == 0 || j == garo - 1)          // 첫 번째 글자 또는 마지막 글자일 경우
						printf("*");                      // * 출력
					else                                  // 아닐경우
						printf(" ");                      // 공백 출력
				}
			}
			printf("\n");                                 // 한 줄 엔터 (마지막에 자동으로 엔터 처리도 됨)
		}
	}
}