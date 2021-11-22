#pragma	warning(disable:4996)

#include <stdio.h>
#include <math.h>

#define LENGTH 35

void marker(int x, int y, int size);

char board[LENGTH][LENGTH + 1];
int result[LENGTH][LENGTH];

int main()
{
	int testCase;
	int height, width;
	int mineCount;

	scanf("%d", &testCase);

	while (testCase--)
	{
		mineCount = 0;
		scanf("%d %d", &height, &width);

		for (int i = 0; i < height; i++)
		{
			scanf("%s", board[i]);

			for (int j = 0; j < width; j++)
				result[i][j] = 0;
		}

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				if (board[i][j] == 'X')
				{
					mineCount++;
					result[i][j] = 'X';
					marker(i - 1, j - 1, 3);
				}
			}
		}

		float percentage = (float)mineCount * 100 / (height * width);
		printf("%0.1f%%\n", round(percentage * 100) / 100);

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				if (result[i][j] == 'X')
					printf("%c", result[i][j]);
				else
					printf("%d", result[i][j]);
			}
			printf("\n");
		}
	}

	return 0;
}

void marker(int x, int y, int size) {
	for (int i = x; i < size + x; i++)
	{
		if (i < 0 || i >= LENGTH)
			continue;

		for (int j = y; j < size + y; j++)
		{
			if (j < 0 || j >= LENGTH)
				continue;

			if (result[i][j] != 'X')
				result[i][j]++;
		}
	}
}