#include <stdio.h>

int main()
{
	int a, j = 1;
	int test;
	long long sum;

	long long memory[20] = { 0 };
	memory[0] = 1;

	scanf("%d", &test);

	for (int i = 0; i < test; i++)
	{
		scanf("%d", &a);

		if (memory[a - 1] == 0)
		{
			sum = memory[j - 1];

			for (j++; j <= a; j++)
			{
				sum *= j;

				if (memory[j - 1] == 0)
					memory[j - 1] = sum;
			}

			j--;
		}
		else
		{
			sum = memory[a - 1];
		}

		printf("%lld\n", sum);
	}
}