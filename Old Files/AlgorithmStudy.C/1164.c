#include<stdio.h>

int main()
{
	int price, pay, payOffset, day;

	while (1)
	{
		scanf("%d", &price);

		if (price == 0)
			break;

		day = 1;
		pay = 5000;
		payOffset = 100;

		while (pay < price)
		{
			pay += 5000 + payOffset;
			payOffset += 100;
			day++;
		}

		printf("%d\n", day);
	}

	return 0;
}