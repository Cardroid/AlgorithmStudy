#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <string.h>
#include <math.h>

int calc(char num, int base) {
	int temp = (num - '0') * pow(2, base);
	return temp;
}

int main() {

	int testCase;
	char base2[21];
	scanf("%d", &testCase);

	while (testCase--)
	{
		scanf("%s", base2);

		int result = 0;

		int len = strlen(base2);

		for (int i = 0; i < len; i++)
		{
			result += calc(base2[len - i - 1], i);
		}

		printf("%d\n", result);
	}

	return 0;
}