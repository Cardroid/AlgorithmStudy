#include <stdio.h>
#include <string.h>

int toLor(int value);
int toUpr(int value);
void toLorStr(char value[]);
void toUprStr(char value[]);

typedef	struct Dictionary
{
	char Text[26];
	int Score;
} Dictionary;

int main()
{
	int inputCase, testCase;
	int sumScore;
	int isFlag;
	char buffer[26];

	Dictionary dic[10];

	scanf("%d %d", &inputCase, &testCase);

	for (int j = 0; j < inputCase; j++)
	{
		scanf("%s %d", dic[j].Text, &dic[j].Score);

		toLorStr(dic[j].Text);
	}

	for (int k = 0; k < testCase; k++)
	{
		sumScore = 0;

		while (1)
		{
			scanf("%s", buffer);

			if (strcmp(buffer, ".") == 0)
				break;

			isFlag = 0;
			toLorStr(buffer);

			for (int j = 0; j < inputCase; j++)
			{
				if (strcmp(buffer, dic[j].Text) == 0)
				{
					isFlag = 1;
					sumScore += dic[j].Score;
					break;
				}
			}

			if (isFlag == 0)
				sumScore += strlen(buffer) * 2;
		}

		printf("%d\n", sumScore);
	}

	return 0;
}

int toLor(int value) {

	if (value >= 'A' && value <= 'Z')
		return value + 32;

	return value;
}

int toUpr(int value) {

	if (value >= 'a' && value <= 'z')
		return value - 32;

	return value;
}

void toLorStr(char value[]) {
	int len = strlen(value);

	for (int i = 0; i < len; i++)
		value[i] = toLor(value[i]);
}

void toUprStr(char value[]) {
	int len = strlen(value);

	for (int i = 0; i < len; i++)
		value[i] = toUpr(value[i]);
}