#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

#define MAX_LENGTH 10001

int array[MAX_LENGTH] = { 0, };

int main() {
	// 에라토스테네스의 체
	for (int i = 2; i * i <= MAX_LENGTH; i++) {
		for (int j = i + i; j <= MAX_LENGTH; j += i) {
			array[j] = 1;
		}
	}

	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int a, b, count = 0;

		scanf("%d %d", &a, &b);

		for (int i = a; i <= b; i++)
		{
			if (!array[i])
				count++;
		}

		printf("%d\n", count);
	}

	return 0;
}