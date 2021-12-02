#include <stdio.h>

int main() {

	unsigned int num;

	scanf("%u", &num);

	if (num % 2 == 0 && (num % 7 == 0 || num % 3 == 0))
		printf("Magic\n");
	else
		printf("No Magic\n");

	return 0;
}