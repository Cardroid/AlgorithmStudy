#include <iostream>
#include <math.h>
using namespace std;

constexpr int LIMIT = 10001;

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

    int testCase, m;
    cin >> testCase;

    while (testCase--)
    {
        cin >> m;

        int max = (int)((m / 2.0) + 0.5);

        for (int i = 0; i < max; i++)
        {
            int temp = max - i;

            if (!array[temp] && !array[m - temp])
            {
                cout << temp << " " << m - temp << "\n";
                break;
            }
        }
    }

    return 0;
}