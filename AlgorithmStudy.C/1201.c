#include <stdio.h>

int main() {
	int testCase, price;
	scanf("%d", &testCase);

	for (int i = 0; i < testCase; i++)
	{
		scanf("%d", &price);
		float temp1 = (float)price / 57000;
		int temp2 = (int)temp1;

		if (temp1 > temp2)
			printf("%d\n", temp2 + 1);
		else
			printf("%d\n", temp2);
	}

	return 0;
}