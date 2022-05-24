#include <iostream>
#include <math.h>
using namespace std;

constexpr int LIMIT = 1000001;

bool array[LIMIT] = {
    true,
    true,
    false,
};

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int squrtLimit = (int)sqrt(LIMIT);

    for (int i = 2; i <= squrtLimit; i++)
        if (!array[i])
            for (int j = i * i; j <= LIMIT; j += i)
                array[j] = true;

    int m, n;

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
            cout << i << "\n";

    return 0;
}