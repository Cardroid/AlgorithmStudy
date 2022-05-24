#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

#define MAX(a, b) ((a) > (b) ? (a) : (b))

int array[501];

int main() {
	int testCase, n, temp;
	scanf("%d", &testCase);

	while (testCase--)
	{
		scanf("%d", &n);

		scanf("%d", array);

		int minIndex = 1, maxIndex = 1, max = array[0], sum = array[0];

		for (int i = 1; i < n; i++)
		{
			scanf("%d", &temp);

			sum += temp;
			sum = MAX(sum, temp);
			max = MAX(sum, max);

			array[i] = sum;

			if (array[i] == max)
			{
				array[i] = max;
				maxIndex = i + 1;
			}
		}

		for (int i = maxIndex - 1; i > 0; i--)
		{
			if (array[i - 1] <= 0)
			{
				minIndex = i + 1;
				break;
			}
		}

		printf("%d %d %d\n", minIndex, maxIndex, max);
	}

	return 0;
}