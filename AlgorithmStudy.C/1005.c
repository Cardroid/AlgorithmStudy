#include <stdio.h>

int main()
{
    int temp;
    char sen[101];
    char pwd[5];
    pwd[4] = '\0';

    scanf("%s", sen);

    for (int i = 0; i < 4; i++) {
        scanf("%d", &temp);
        pwd[i] = sen[temp];
    }

    printf("%s\n", pwd);

    return 0;
}