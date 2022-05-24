#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MIN(a, b) (a) < (b) ? (a) : (b)
#define MAX(a, b) (a) > (b) ? (a) : (b)

int Calc(char value);

int main()
{
	int testCase;
	char str1[51], str2[51];

	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		scanf("%s %s", str1, str2);

		int sum = 0;

		int str1Len = strlen(str1);
		int str2Len = strlen(str2);

		int minLen = MIN(str1Len, str2Len);
		int maxLen = MAX(str1Len, str2Len);

		for (int i = 0; i < maxLen; i++)
		{
			if (i < str1Len)
				str1[i] = Calc(str1[i]);
			else
				str1[i] = 0;

			if (i < str2Len)
				str2[i] = Calc(str2[i]);
			else
				str2[i] = 0;

			sum += abs(str1[i] - str2[i]);
		}

		printf("%d\n", sum / minLen);
	}

	return 0;
}

int Calc(char value) {
	return (value - 'A' + 1) * 2;
}