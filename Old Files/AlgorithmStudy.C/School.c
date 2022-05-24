#pragma	warning(disable:4996)

#include <stdio.h>

int Inte(int start, int end);

int main(void)
{
    int a, b, result = 0;
    printf("두 정수를 입력하세요.");
    scanf_s("%d", &a);
    scanf_s("%d", &b);

    printf("%d부터 %d까지의 합은 %d이다.", a, b, Inte(a, b));

    return 0;
}

int Inte(int start, int end)
{
    int sum = 0, i;
    for (i = start; i <= end; i++)
    {
        sum += i;
    }

    return sum;
}