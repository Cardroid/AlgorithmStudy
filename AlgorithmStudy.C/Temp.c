#pragma	warning(disable:4996)

#include <stdio.h>

int Sum_odd(int start, int end);

int main()
{
	int start, end;

	printf("���� ���� �Է��ϼ���: ");
	scanf("%d", &start);
	printf("�� ���� �Է��ϼ���: ");
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