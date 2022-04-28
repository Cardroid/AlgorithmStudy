#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>

int _gcd(int a, int b)
{
    int c;
    while (b)
    {
        c = a % b;
        a = b;
        b = c;
    }
    return a;
}

int gcd(int a, int b)
{
    return b ? _gcd(b, a % b) : a;
}

int main() {
    int testCase;
    scanf("%d", &testCase);

    while (testCase--)
    {
        int head, tail;

        scanf("%d %d", &head, &tail);

        int div = gcd(head, tail);

        tail /= div;

        if (tail % 5 == 0 || tail % 2 == 0)
            printf("Limited\n");
        else
            printf("Unlimited\n");
    }

    return 0;
}

int isPrime(int n) {
    int k = (int)sqrt(n);
    for (int i = 2; i <= k; i++) {
        if (n % i == 0)
            return 0;
    }
    return 1;
}
