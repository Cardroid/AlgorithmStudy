#include <stdio.h>

int main() {
	int temp;
	int sum = 0;
	int num[6];
	int isError = 0;

	for (int i = 0; i < 6; i++) {
		scanf("%d", &num[i]);
		sum += num[i];

		if (0 == num[i] || num[i] > 45)
			isError = 1;
	}

	if (isError == 0) {
		for (int i = 0; i < 6; i++) {
			for (int j = 0; j < 6; j++) {
				if (i != j && num[i] == num[j])
				{
					isError = 1;
					break;
				}
			}

			if (isError == 1)
				break;
		}
	}

	if (isError == 0)
	{
		int	isNotGood = 180 >= sum && sum > 80;

		if (isNotGood == 1)
		{
			for (int i = 0; i < 6; i++) {
				for (int j = 0; j < 5; j++) {
					if (num[j] > num[j + 1])
					{
						temp = num[j];
						num[j] = num[j + 1];
						num[j + 1] = temp;
					}
				}
			}

			for (int i = 0; i < 6; i++) {
				printf("%d ", num[i]);
			}
		}
		else
			printf("YES\n");
	}
	else
		printf("BAD!\n");

	return 0;
}