#include <stdio.h>

int main() {

	int m1[10][10], mXLen, mYLen, temp;

	scanf("%d %d", &mXLen, &mYLen);

	for (int i = 0; i < mYLen; i++)
	{
		for (int j = 0; j < mXLen; j++)
		{
			scanf("%d", &m1[i][j]);
		}
	}

	scanf("%d %d", &mXLen, &mYLen);

	for (int i = 0; i < mYLen; i++)
	{
		for (int j = 0; j < mXLen; j++)
		{
			scanf("%d", &temp);

			m1[i][j] += temp;
		}
	}

	for (int i = 0; i < mYLen; i++)
	{
		for (int j = 0; j < mXLen; j++)
		{
			if (j == mXLen - 1)
				printf("%d", m1[i][j]);
			else
				printf("%d ", m1[i][j]);
		}
		printf("\n");
	}

	return 0;
}