#include <stdio.h>
#include <string.h>

int main()
{
	int test;
	scanf("%d", &test);
	float num;
	char units[3];

	for (int i = 0; i < test; i++)
	{
		scanf("%f %s", &num, units);

		if (strcmp(units, "m") == 0)
			printf("%d\n", (int)(num * 1000));

		else if (strcmp(units, "km") == 0)
			printf("%d\n", (int)(num * 1000000));

		else if (strcmp(units, "cm") == 0)
			printf("%d\n", (int)(num * 10));

		else if (strcmp(units, "mm") == 0)
			printf("%d\n", (int)(num));
	}

	return 0;
}