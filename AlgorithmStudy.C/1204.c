#include<stdio.h>

int main()
{
	int testCase;
	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		//���� �ϴ�: 40000 �ָ�: 80000
		//������ 200000+160000 = 360000 14��:720000 5��:200000+1�� 8���� 20��
		int price, pay = 0, day = 0;
		//ascode  1204��

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