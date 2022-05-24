#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int main()
{
	int score;

	scanf("%d", &score);

	if (score == 100)
		printf("A++");
	else if (score <= 60)
		printf("F");
	else {
		printf("%c", 74 - score / 10);

		int num1 = score % 10;
		if (num1 >= 7)
			printf("+");
		else if (num1 <= 2)
			printf("-");
	}

	return 0;
}