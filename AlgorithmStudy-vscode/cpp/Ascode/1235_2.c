#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <math.h>

int isPrime(int n);

int main()
{
	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int m, n, count = 0;

		scanf("%d %d", &m, &n);

		if (m > n)
		{
			int temp = n;
			n = m;
			m = temp;
		}

		for (int i = m; i <= n; i++)
		{
			if (isPrime(i))
				count++;
		}

		printf("%d\n", count);
	}

	return 0;
}

int isPrime(int n)
{
	if (n == 0 || n == 1)
		return 0;

	int k = (int)sqrt(n);
	for (int i = 2; i <= k; i++)
	{
		if (n % i == 0)
			return 0;
	}
	return 1;
}