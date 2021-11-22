#include <stdio.h>
#include <string.h>

int main()
{
	int testCase, result;
	char buffer[20];

	scanf("%d", &testCase);

	while (testCase--)
	{
		result = 0;

		while (1)
		{
			scanf("%s", &buffer);

			if (buffer[0] == '.')
				break;

			int count = strlen(buffer);

			for (int i = 0; i < count; i++)
			{
				switch (buffer[i])
				{
				case 'W':
				case 'w':
				case 'X':
				case 'x':
				case 'Y':
				case 'y':
				case 'Z':
				case 'z':
					result += 29;
					break;
				case 'B':
				case 'b':
				case 'D':
				case 'd':
				case 'F':
				case 'f':
				case 'P':
				case 'p':
					result += 15;
					break;
				case 'A':
				case 'a':
				case 'E':
				case 'e':
				case 'I':
				case 'i':
				case 'O':
				case 'o':
				case 'U':
				case 'u':
					result += 8;
					break;
				case 'R':
				case 'r':
				case 'S':
				case 's':
				case 'T':
				case 't':
					result -= 7;
					break;
				}
			}
		}

		printf("%d\n", result);
	}

	return 0;
}