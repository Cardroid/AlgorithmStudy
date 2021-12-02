#include<stdio.h>


int main() {
	int test, n, count, n_;
	scanf("%d", &test);

	while (test--) {
		count = 1;
		n_ = 0;
		scanf("%d", &n);

		while (n > 1) {
			count++;

			if (n % 2 == 1)
			{
				n = 3 * n + 1;
			}
			else
			{
				n = n / 2;
				n_++;
			}
		}
		printf("%d %d\n", count, n_);
	}
	return 0;
}