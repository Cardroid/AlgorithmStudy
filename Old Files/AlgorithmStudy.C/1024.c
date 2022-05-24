#include <stdio.h>
#include <string.h>

int main() {

	int testCase, x, y;
	char move[51];
	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		scanf("%d %d", &x, &y);

		scanf("%s", move);
		int count = strlen(move);

		for (int i = 0; i < count; i++)
		{
			switch (move[i])
			{
			case 'U':
				y++;
				break;
			case 'D':
				y--;
				break;
			case 'L':
				x--;
				break;
			case 'R':
				x++;
				break;
			}
		}

		printf("%d %d\n", x, y);
	}

	return 0;
}