#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int main() {
	int i, j, count;

	while (scanf("%d %d", &i, &j) != EOF)
	{
		count = 0;
		int printI = i, printJ = j;

		if (i > j) {
			int temp = i;
			i = j;
			j = temp;
		}

		for (int k = i; k <= j; k++)
		{
			int n = k;
			int innerCount = 0;

			while (n != 1)
			{
				if (n % 2 == 0)
					n /= 2;
				else
					n = n * 3 + 1;

				innerCount++;
			}

			if (count < innerCount)
				count = innerCount;
		}

		printf("%d %d %d\n", printI, printJ, ++count);
	}

	return 0;
}