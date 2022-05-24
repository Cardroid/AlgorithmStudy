#include <stdio.h>

#define LINE 10

int main()
{
	int testCase, inputCase, count;
	char board[20][LINE + 1];

	scanf("%d", &testCase);

	while (testCase--)
	{
		scanf("%d", &inputCase);

		for (int i = 0; i < inputCase; i++)
			scanf("%s", board[i]);

		for (int i = 0; i < inputCase; i++)
		{
			count = 0;

			for (int j = 0; j < LINE; j++)
			{
				if (board[i][j] == '@')
					count++;
			}

			if (count != LINE)
				printf("%s\n", board[i]);
		}
	}

	return 0;
}
