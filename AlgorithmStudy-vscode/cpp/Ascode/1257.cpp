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

    int m;

    while (true)
    {
        int count = 0;

        cin >> m;

        if (m == 0)
            break;

        int max = m / 2;

        for (int i = 3; i <= max; i++)
        {
            if (!array[i] && !array[m - i])
                count++;
        }

        cout << count << "\n";
    }

    return 0;
}