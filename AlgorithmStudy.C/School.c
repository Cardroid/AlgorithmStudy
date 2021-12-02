#pragma	warning(disable:4996)

#include <stdio.h>
#include <string.h>

int main()
{
	int test, num;
	scanf("%d", &test);

	for (int t = 0; t < test; t++)
	{
		scanf("%d", &num);

		int side = num * 2 - 1;

		for (int i = 0; i < side; i++)
		{
			if (num > i) {
				for (int j = 0; j < num - i - 1; j++)
				{
					printf(" ");
				}

				for (int j = 0; j < i + 1; j++)
				{
					printf("%d", j + 1);
				}

				for (int j = i - 1; j >= 0; j--)
				{
					printf("%d", j + 1);
				}
			}
			else
			{
				for (int j = side - i; j >= 0; j--)
				{
					printf(".");
				}

				//for (int j = 0; j < i - num ; j++)
				//{
				//	printf("%d", j + 1);
				//}

				//for (int j = i - num; j >= 0; j--)
				//{
				//	printf("%d", j + 1);
				//}
			}

			printf("\n");
		}
	}

	return 0;
}