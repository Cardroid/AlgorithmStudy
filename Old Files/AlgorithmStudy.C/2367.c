#include <stdio.h>

#define LENGTH 35
#define MINE '@'

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
				if (board[i][j] == MINE)
				{
					mineCount++;
					result[i][j] = MINE;
					marker(i - 1, j - 1, 3);
				}
			}
		}

		printf("%d %d\n", width * height, mineCount);

		if (mineCount > 0) {
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (result[i][j] == MINE)
						printf("%c", result[i][j]);
					else
						printf("%d", result[i][j]);
				}
				printf("\n");
			}
		}
		else
		{
			printf("No Mine\n");
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

			if (result[i][j] != MINE)
				result[i][j]++;
		}
	}
}