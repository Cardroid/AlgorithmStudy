#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int array[100001] = { 0, };

int main() {
	for (int i = 2; i * i <= 100001; i++) {
		for (int j = i + i; j <= 100001; j += i) {
			array[j] = 1;
		}
	}

	for (int i = 1; i <= 100001; i++) {
		if (!array[i]) {
			int temp = i, reverse = 0;

			while (temp != 0) {
				reverse *= 10;
				reverse += temp % 10;
				temp /= 10;
			}

			if (reverse == i || array[reverse]) {
				array[i] = 1;
			}
		}
	}

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
			if (!array[i])
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