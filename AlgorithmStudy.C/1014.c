#include <stdio.h>

int main()
{
	int sum = 0, temp;

	for (int i = 0; i < 7; i++) {
		scanf("%d", &temp);
		sum += temp;
	}

	printf("%d\n", sum / 7);

	return 0;
}