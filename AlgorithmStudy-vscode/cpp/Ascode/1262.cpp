#include <iostream>
using namespace std;

constexpr int LENGTH = 1001;

bool table[LENGTH];

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int testCase, inputCount, index;
    cin >> testCase;

    while (testCase--)
    {
        for (int i = 0; i < LENGTH; i++)
            table[i] = false;

        cin >> inputCount;

        for (int i = 0; i < inputCount; i++)
        {
            cin >> index;
            table[index] = true;
        }

        for (int i = 0; i < LENGTH; i++)
        {
            if (table[i])
                cout << i << " ";
        }
        cout << "\n";
    }

    return 0;
}