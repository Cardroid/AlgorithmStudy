#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int main() {

	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int N, count = 0;

		scanf("%d", &N);

		while (N != 1)
		{
			if (N % 2 == 0)
				N /= 2;
			else
				N = N * 3 + 1;

			count++;
		}

		printf("%d\n", count);
	}

	return 0;
}