#include <stdio.h>

#define LENGTH 35

void marker(int x, int y, int size);

char board[LENGTH][LENGTH + 1];
int result[LENGTH][LENGTH];

int main()
{
	int testCase;
	int height, width;

	scanf("%d", &testCase);

	while (testCase--)
	{
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
				if (board[i][j] == '*')
				{
					marker(i - 1, j - 1, 3);
					result[i][j] = '*';
				}
			}
		}

		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				if (result[i][j] == '*')
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

			if (result[i][j] != '*')
				result[i][j]++;
		}
	}
}