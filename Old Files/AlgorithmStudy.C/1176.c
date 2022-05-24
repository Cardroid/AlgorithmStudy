#include <stdio.h>

int main() {

	int nums[6], sum = 0, p = 0, s = 0, flag = 0;

	for (int i = 0; i < 6; i++)
	{
		scanf("%d", nums + i);
		p += nums[i] % 2 == 0;
		s += nums[i] % 2 == 1;
		sum += nums[i];
	}

	flag += p > 2 && s > 2;
	flag += 91 <= sum && sum <= 180;

	switch (flag)
	{
	case 0:
		printf("BAD");
		break;
	case 1:
		printf("GOOD");
		break;
	case 2:
		printf("BEST");
		break;
	}

	return 0;
}