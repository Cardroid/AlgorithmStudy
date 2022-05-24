#include <stdio.h>
#include <string.h>

int main()
{
	char a[21];
	char b[21];
	int num1, num2;

	scanf("%s %s", a, b);

	num1 = strlen(a);
	num2 = strlen(b);
	if (num1 > num2)
	{
		printf("%s", a);
	}
	else if (num1 < num2)
	{
		printf("%s", b);
	}
	else if (num1 == num2)
	{
		if (strcmp(a, b) < 0) {
			printf("%s", a);
		}
		else
			printf("%s", b);

	}
	return 0;
}