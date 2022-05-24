#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int main() {
	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		long long n, m;

		scanf("%lld %lld", &n, &m);

		printf("%lld\n", (n + m) * (m - n + 1) / 2);
	}

	return 0;
}