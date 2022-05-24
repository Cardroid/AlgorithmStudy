#include <stdio.h>

int main()
{
	int test, num;
	scanf("%d", &test);

	for (int t = 0; t < test; t++)
	{
		int i, j, counter;

		scanf("%d", &num);

		for (i = 1; i < num; i++) {
			for (j = num; j > i; j--)
				printf(" ");
			counter = 1;
			for (j = 0; j < i * 2 - 1; j++)
			{
				if (i > j + 1)
					printf("%d", counter++);
				else
					printf("%d", counter--);
			}
			printf("\n");
		}

		for (; i > 0; i--) {
			for (j = num; j > i; j--)
				printf(" ");
			counter = 1;
			for (j = 0; j < i * 2 - 1; j++)
			{
				if (i > j + 1)
					printf("%d", counter++);
				else
					printf("%d", counter--);
			}

			printf("\n");
		}
	}

	return 0;
}