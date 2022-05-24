#include <stdio.h>
#include <string.h>

typedef	struct Job
{
	char Name[17];
	int Score;
} Job;

int main()
{
	int inputCase, testCase;
	int sumScore;
	char buffer[17];

	scanf("%d %d", &inputCase, &testCase);

	Job jobs[1000];

	for (int i = 0; i < inputCase; i++)
	{
		scanf("%s %d", jobs[i].Name, &jobs[i].Score);
	}

	for (int i = 0; i < testCase; i++)
	{
		sumScore = 0;

		while (1)
		{
			scanf("%s", buffer);

			if (strcmp(buffer, ".") == 0)
				break;

			for (int j = 0; j < inputCase; j++)
			{
				if (strcmp(buffer, jobs[j].Name) == 0)
				{
					sumScore += jobs[j].Score;
					break;
				}
			}
		}

		printf("%d\n", sumScore);
	}

	return 0;
}