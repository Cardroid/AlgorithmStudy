#include <stdio.h>

int main()
{
	int test;
	scanf("%d", &test);

	int garo, sero;
	for (int i = 0; i < test; i++) {

		scanf("%d %d", &garo, &sero);

		for (int i = 0; i < sero; i++)                    // �� �ݺ� (����)
		{
			if (i == 0 || (i == sero - 1 && sero != 1)) { // (ù ��° �� �� ���) �Ǵ� (������ �� �̰� ���ΰ� 1�� �ƴ� ���)
				for (int j = 0; j < garo; j++)            // ���� �ݺ� (����)
					printf("*");                          // * ���
			}
			else {
				for (int j = 0; j < garo; j++)            // ���� �ݺ� (����)
				{
					if (j == 0 || j == garo - 1)          // ù ��° ���� �Ǵ� ������ ������ ���
						printf("*");                      // * ���
					else                                  // �ƴҰ��
						printf(" ");                      // ���� ���
				}
			}
			printf("\n");                                 // �� �� ���� (�������� �ڵ����� ���� ó���� ��)
		}
	}
}