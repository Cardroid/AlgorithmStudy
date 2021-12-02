#include <stdio.h>
#include <string.h>

int main() {
	int testCase, x, y;
	char move[101];
	scanf("%d", &testCase);

	for (int t = 0; t < testCase; t++)
	{
		int isInvalid = 0;
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

			if (!(-40 <= x && x <= 40))
			{
				isInvalid = 1;
				break;
			}
		}

		if (isInvalid == 1)
			printf("NO\n");
		else
			printf("%d %d\n", x, y);
	}

	return 0;
}