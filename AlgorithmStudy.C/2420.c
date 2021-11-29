#include <stdio.h>
#include <string.h>


typedef	struct Kind {
	char Name[21];
	int Price;
} Kind;


int main()
{
	int testCase;

	scanf("%d", &testCase);

	Kind kind[10];

	while (testCase--)
	{
		int menu, people;
		int total = 0;
		char buffer[21];

		scanf("%d %d", &menu, &people);

		for (int i = 0; i < menu; i++)
		{
			scanf("%s %d", kind[i].Name, &kind[i].Price);
		}

		for (int i = 0; i < people; i++)
		{
			scanf("%s", buffer);

			for (int j = 0; j < menu; j++)
			{
				if (strcmp(buffer, kind[j].Name) == 0) {
					total += kind[j].Price;
					break;
				}
			}
		}

		int temp = total;

		int input50000Price = temp / 50000;
		temp = temp % 50000;
		int input10000Price = temp / 10000;
		temp = temp % 10000;
		int input5000Price = temp / 5000;
		temp = temp % 5000;
		int input1000Price = temp / 1000;
		temp = temp % 1000;

		if (temp > 0)
			input1000Price++;

		int totalInputPrice = input50000Price * 50000 + input10000Price * 10000 + input5000Price * 5000 + input1000Price * 1000;

		int minusPrice = totalInputPrice - total;

		temp = minusPrice;
		int output500Price = temp / 500;
		temp = temp % 500;
		int output100Price = temp / 100;
		temp = temp % 100;
		int output50Price = temp / 50;
		temp = temp % 50;
		int output10Price = temp / 10;

		int totalOutputPrice = minusPrice;
		int totalOutputPriceCount = output500Price + output100Price + output50Price + output10Price;

		printf("%d %d %d %d\n", total, totalInputPrice, totalOutputPrice, totalOutputPriceCount);
	}

	return 0;
}
