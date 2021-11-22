#include <stdio.h>

typedef	struct Player
{
	char Name[16];
	int Age;
	char Position[16];
} Player;

int main()
{
	int testCase, sum = 0;
	int min = 50, max = 0, minIndex, maxIndex;

	scanf("%d", &testCase);

	Player players[15];

	for (int i = 0; i < testCase; i++)
	{
		scanf("%s %d %s", players[i].Name, &players[i].Age, players[i].Position);

		sum += players[i].Age;

		if (min > players[i].Age)
		{
			min = players[i].Age;
			minIndex = i;
		}

		if (max < players[i].Age)
		{
			max = players[i].Age;
			maxIndex = i;
		}
	}

	printf("average age : %d\n", sum / testCase);
	printf("the oldest : %s %s\n", players[maxIndex].Name, players[maxIndex].Position);
	printf("the youngest : %s %s\n", players[minIndex].Name, players[minIndex].Position);
}