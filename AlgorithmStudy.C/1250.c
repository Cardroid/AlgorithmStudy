#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int toReverse(int num) {
	int reverse = 0;
	while (num != 0) {
		reverse *= 10;
		reverse += num % 10;
		num /= 10;
	}
	return reverse;
}

int main() {

	int testCase;
	scanf("%d", &testCase);

	while (testCase--)
	{
		int N;

		scanf("%d", &N);

		int reverse = toReverse(N);

		int total_reverse = N + reverse;

		int reverse_total_reverse = toReverse(total_reverse);

		printf("%s\n", total_reverse == reverse_total_reverse ? "YES" : "NO");
	}

	return 0;
}