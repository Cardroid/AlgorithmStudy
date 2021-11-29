#include <stdio.h>
#include <string.h>


typedef	struct Kind {
	char Name[16];
	int Price;
} Kind;


int main()
{
	int testCase;

	scanf("%d", &testCase);

	Kind kind[10];

	while (testCase--)
	{
		int menu, people, selectCount;
		int total = 0;
		char buffer[16];

		scanf("%d", &menu);

		for (int i = 0; i < menu; i++)
		{
			scanf("%s %d", kind[i].Name, &kind[i].Price);
		}

		scanf("%d", &people);

		for (int i = 0; i < people; i++)
		{
			scanf("%s %d", buffer, &selectCount);

			for (int j = 0; j < menu; j++)
			{
				if (strcmp(buffer, kind[j].Name) == 0) {
					total += kind[j].Price * selectCount;
					break;
				}
			}
		}

		printf("%d\n", total);
	}

	return 0;
}
