#pragma	warning(disable:4996)

#include <stdio.h>

int Sum_odd(int start, int end);

int main()
{
	int start, end;

	printf("시작 값을 입력하세요: ");
	scanf("%d", &start);
	printf("끝 값을 입력하세요: ");
	scanf("%d", &end);

	int rValue = Sum_odd(start, end);

	printf("%d", rValue);

	return 0;
}

int Sum_odd(int start, int end) {
	int result = 0;

	for (int i = start; i <= end; i++)
	{
		if (i % 2 == 1)
			result += i;
	}

	return result;
}+