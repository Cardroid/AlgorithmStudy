#include <iostream>
using namespace std;

constexpr int LENGTH = 3001;

bool table[LENGTH];

int main()
{
    int inputCount, n, diff, before;
    bool isFail;

    while (1)
    {
        isFail = false;
        cin >> inputCount;

        if (cin.eof())
            break;

        for (int i = 0; i < LENGTH; i++)
            table[i] = false;

        cin >> before;

        for (int i = 0; i < inputCount - 1; i++)
        {
            cin >> n;

            if (!isFail)
            {
                diff = abs(before - n);

                if (diff <= 0 || diff > inputCount || table[diff])
                    isFail = true;

                table[diff] = true;
                before = n;
            }
        }

        if (isFail)
            cout << "Not jolly"
                 << "\n";
        else
            cout << "Jolly"
                 << "\n";
    }

    return 0;
}