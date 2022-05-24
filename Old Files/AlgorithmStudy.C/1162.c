#include <stdio.h>
#include <string.h>

int main() {
	int testCase, x, y;
	char move[81];
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
			case '1':
				y++;
				break;
			case '2':
				x++;
				y++;
				break;
			case '3':
				x++;
				break;
			case '4':
				x++;
				y--;
				break;
			case '5':
				y--;
				break;
			case '6':
				x--;
				y--;
				break;
			case '7':
				x--;
				break;
			case '8':
				x--;
				y++;
				break;
			}
		}

		printf("%d %d\n", x, y);
	}

	return 0;
}