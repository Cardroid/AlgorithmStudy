#pragma	warning(disable:4996)

#include <stdio.h>

#define LENGTH 5

int Sumeven(int array[], int size);

int main()
{
	int array[LENGTH];

	printf("���Ұ� %d���� ������ �Է��ϼ���: ", LENGTH);

	for (int i = 0; i < LENGTH; i++)
	{
		scanf("%d", &array[i]);
	}

	int rValue = Sumeven(array, LENGTH);

	printf("%d", rValue);

	return 0;
}

int Sumeven(int array[], int size)
{
	int i, result = 0;
	for (i = 0; i < size; i++)
		if (array[i] % 2 == 0)
			result += array[i];

	return result;
}