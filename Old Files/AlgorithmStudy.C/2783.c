#include <stdio.h>

int main(void) {
	int n[4], s[4], nSum = 0, sSum = 0;

	scanf("%d %d %d %d %d %d %d %d", &n[0], &s[0], &n[1], &s[1], &n[2], &s[2], &n[3], &s[3]);

	for (int i = 0; i < 4; i++)
	{
		nSum += n[i];
		sSum += s[i];
	}

	printf("%d %d\n", sSum, nSum);

	return 0;
}