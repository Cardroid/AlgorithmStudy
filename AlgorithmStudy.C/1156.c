#include<stdio.h>

int main()
{
	int num, price, pay, day;

	//ascode 1156
	scanf("%d", &num);

	for (int i = 0; i < num; i++)
	{
		scanf("%d", &price);

		day = 0;
		pay = 0;

		while (pay < price)
		{
			pay += 63000 + (day / 7) * 1400;
			day++;
		}

		printf("%d\n", day);
	}

	return 0;
}