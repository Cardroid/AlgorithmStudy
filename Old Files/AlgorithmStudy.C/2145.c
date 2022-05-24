#include <stdio.h>

int min(int n1, int n2);

int main()
{
	int test, num;
	scanf("%d", &test);

	for (int t = 0; t < test; t++)
	{
		int i, j, max, lineMax;

		scanf("%d", &num);

		max = num / 2 + 1;

		for (i = 1; i <= num; i++) {
			if (max > i)
				lineMax = i;
			else
				lineMax = num - i + 1;
			for (j = 1; j <= num; j++)
			{
				if (max >= j)
					printf("%d", min(j, lineMax));
				else
					printf("%d", min(num - j + 1, lineMax));
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