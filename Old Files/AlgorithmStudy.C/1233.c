#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <math.h>

int main() {
	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int n;

		scanf("%d", &n);

		if (isPrime(n))
			printf("Prime\n");
		else
			printf("Not Prime\n");
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