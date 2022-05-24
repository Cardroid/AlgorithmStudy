#include <stdio.h>
#include <math.h>
#include <string.h>

int main() {
	int testCase, result;
	char name1[31], name2[31];
	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		for (int i = 0; i < 31; i++)
		{
			name1[i] = 0;
			name2[i] = 0;
		}

		result = 0;
		scanf("%s", name1);
		scanf("%s", name2);

		int temp1 = strlen(name1);
		int temp2 = strlen(name2);
		int maxLen = temp1 > temp2 ? temp1 : temp2;

		for (int i = 0; i < maxLen; i++)
		{
			result += abs((name1[i] != 0 ? name1[i] : 'A' - 1) - (name2[i] != 0 ? name2[i] : 'A' - 1));
		}

		printf("%d\n", result);
	}

	return 0;
}