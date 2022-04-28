#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>

int array[10000];

int compare(const void* a, const void* b)
{
	return *(int*)a < *(int*)b;
}

int main() {
	int testCase, inputLen;
	scanf("%d", &testCase);

	while (testCase--) {
		int max = 0;

		scanf("%d", &inputLen);

		for (int i = 0; i < inputLen; i++)
			scanf("%d", array + i);

		qsort(array, inputLen, sizeof(array[0]), compare);

		for (int i = 0; i < inputLen - 2; i++) {

			int j = i + 1, k = i + 2;

			if (array[i] < array[j] + array[k])
			{
				max = array[i] + array[j] + array[k];
				break;
			}
		}

		printf("%d\n", max);
	}

	return 0;
}