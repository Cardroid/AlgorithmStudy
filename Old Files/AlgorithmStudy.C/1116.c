#include <stdio.h>


int main() {
	int test, m, min, max;
	int temp[50];

	scanf("%d", &test);

	while (test--) {
		scanf("%d", &m);

		for (int i = 0; i < m; i++) {
			scanf("%d", &temp[i]);
		}

		min = temp[0];
		max = temp[0];

		for (int i = 1; i < m; i++) {
			if (temp[i] < min)
				min = temp[i];
		}

		for (int i = 1; i < m; i++) {
			if (temp[i] > max)
				max = temp[i];
		}

		if (max < 0 || min < 0)
			printf("HMM!\n");
		else if (min + max == 0)
			printf("ZERO\n");
		else if ((min + max) % 7 == 0)
			printf("YES\n");
		else
			printf("NO\n");
	}

	return 0;
}