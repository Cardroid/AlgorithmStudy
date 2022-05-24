#include <iostream>
#include <math.h>
using namespace std;

constexpr int LIMIT = 100001;

bool array[LIMIT] = {
    true,
    true,
    false,
};

int main()
{
    int squrtLimit = (int)sqrt(LIMIT);

    for (int i = 2; i <= squrtLimit; i++)
        for (int j = i * i; j <= LIMIT; j += i)
            array[j] = true;

    int testCase;
    cin >> testCase;

    while (testCase--)
    {
        int m, n, count = 0;

        cin >> m >> n;

        if (m > n)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        if (m < 2)
            m = 2;

        for (int i = m; i <= n; i++)
            if (!array[i])
                count++;

        cout << count << endl;
    }

    return 0;
}