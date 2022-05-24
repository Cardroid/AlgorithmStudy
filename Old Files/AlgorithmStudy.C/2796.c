#include <stdio.h>

int main(void) {
	int t, i, j, k, l, d;
	int list[7];
	int tmp = 0, sum;
	scanf("%d", &t);

	for (i = 0; i < t; i++) {
		sum = 0;
		scanf("%d %d %d %d %d %d %d", &list[0], &list[1], &list[2], &list[3], &list[4], &list[5], &list[6]);

		for (j = 0; j < 7; j++) {
			for (k = 0; k < 6; k++) {
				if (list[k] > list[k + 1]) {

					tmp = list[k];
					list[k] = list[k + 1];
					list[k + 1] = tmp;
				}
			}
		}

		if (list[5] - list[1])
		{
			d = 3;
			for (l = 2; l < 5; l++)
				sum += list[l];
		}
		else
		{
			d = 5;
			for (l = 1; l < 6; l++)
				sum += list[l];
		}

		printf("%d\n", sum / d);
	}

	return 0;
}