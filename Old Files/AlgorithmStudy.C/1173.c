#include <stdio.h>

int main() {

	int testCase, num;

	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		scanf("%d", &num);

		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num - i; j++)
			{
				printf("%c", 'A' + i);
			}
			printf("\n");
		}

		printf("\n");
	}

	return 0;
}