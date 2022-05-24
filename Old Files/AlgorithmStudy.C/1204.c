#include<stdio.h>

int main()
{
	int testCase;
	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		//乞老 老寸: 40000 林富: 80000
		//老林老 200000+160000 = 360000 14老:720000 5老:200000+1老 8父盔 20老
		int price, pay = 0, day = 0;
		//ascode  1204锅

		scanf("%d", &price);

		while (1)
		{
			for (int i = 0; i < 7; i++)
			{
				switch (i)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					pay += 40000;
					break;
				case 5:
				case 6:
					pay += 80000;
					break;
				}

				day++;

				if (price <= pay)
					break;
			}

			if (price <= pay)
				break;
		}

		printf("%d\n", day);
	}

	return 0;
}