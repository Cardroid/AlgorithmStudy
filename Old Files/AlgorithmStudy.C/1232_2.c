#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <math.h>

int isPrime(int n);
int isEmirp(int n);

int main() {
	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int m, n, max = 0, min = 100001, count = 0;

		scanf("%d %d", &m, &n);

		if (m > n)
		{
			int temp = n;
			n = m;
			m = temp;
		}

		for (int i = m; i <= n; i++)
		{
			if (isEmirp(i))
			{
				count++;

				if (i > max)
					max = i;

				if (i < min)
					min = i;
			}
		}

		if (min == 100001)
			min = 0;

		printf("%d %d %d\n", max, min, count);
	}

	return 0;
}

int isPrime(int n) {
	int k = (int)sqrt(n);
	for (int i = 2; i <= k; i++) {
		if (n % i == 0)
			return 0;
	}
	return 1;
}

int isEmirp(int n) {
	if (!isPrime(n))
		return 0;

	int temp = n, reverse = 0;

	while (temp != 0) {
		reverse *= 10;
		reverse += temp % 10;
		temp /= 10;
	}

	if (reverse == n || !isPrime(reverse)) {
		return 0;
	}
	return 1;
}