#include<stdio.h>

int main(void) {
	int testcase;
	scanf("%d", &testcase);
	char tr[26];
	int h;

	for (int i = 0; i < 26; i++)
		tr[i] = 'A' + i;

	for (int i = 0; i < testcase; i++) {
		scanf("%d", &h);

		for (int k = 0; k < h; k++)
		{
			for (int j = 0; j < h - 1 - k; j++) // �ﰢ���� ���� ����κ��� �������ش�.
				printf(" ");

			int f = k * 2 + 1;

			for (int j = 0; j < f; j++) // �ﰢ���� ������ش�.
			{
				printf("%c", tr[j > k ? f - j - 1 : j]);
			}

			printf("\n");
		}

	}
	return 0;
}