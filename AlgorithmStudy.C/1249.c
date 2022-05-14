#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int main() {

	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int N;

		scanf("%d", &N);

		int temp = N, reverse = 0;

		while (temp != 0) {
			reverse *= 10;
			reverse += temp % 10;
			temp /= 10;
		}

		printf("%d\n", N > reverse ? N : reverse);
	}

	return 0;
}