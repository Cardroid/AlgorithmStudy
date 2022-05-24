#include <stdio.h>
#include <string.h>


typedef	struct Kind {
	char Name[21];
	int Price;
} Kind;


int main()
{
	int testCase;

	scanf("%d", &testCase);

	Kind kind[10];

	while (testCase--)
	{
		int menu, people;
		int total = 0;
		char buffer[21];

		scanf("%d %d", &menu, &people);

		for (int i = 0; i < menu; i++)
		{
			scanf("%s %d", kind[i].Name, &kind[i].Price);
		}

		for (int i = 0; i < people; i++)
		{
			scanf("%s", buffer);

			for (int j = 0; j < menu; j++)
			{
				if (strcmp(buffer, kind[j].Name) == 0) {
					total += kind[j].Price;
					break;
				}
			}
		}

		printf("%d\n", total);
	}

	return 0;
}
