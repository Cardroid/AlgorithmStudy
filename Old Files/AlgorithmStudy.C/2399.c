#include <stdio.h>

int min(int n1, int n2);

char Dictionary[] = { 'A', 'B', 'C', 'D', 'G', 'K', 'M', 'P', 'S', 'W' };

int main()
{
	int test, num;
	int i, j, max, lineMax, maxH;
	scanf("%d", &test);

	for (int t = 0; t < test; t++)
	{
		scanf("%d", &num);

		max = (num - 1) / 2 + 1;

		for (i = 1; i <= num; i++) {
			if (max > i)
				lineMax = i;
			else
				lineMax = num - i + 1;

			for (j = 1; j <= num; j++)
			{
				if (max >= j)
					printf("%c", Dictionary[max - min(j, lineMax)]);
				else
					printf("%c", Dictionary[max - min(num - j + 1, lineMax)]);
			}
			printf("\n");
		}
		printf("\n");
	}

	return 0;
}

int min(int n1, int n2)
{
	return n1 < n2 ? n1 : n2;
}