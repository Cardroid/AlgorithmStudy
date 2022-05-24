#include <math.h>
#include <iostream>

using namespace std;

int toBase10(string bin)
{
    int count = 0, result = 0;

    for (int i = bin.length() - 1; i >= 0; i--)
        result += (bin[i] - '0') * pow(2, count++);

    return result;
}

int main()
{
    int testCase;
    cin >> testCase;

    int ip[4];
    string input;

    while (testCase--)
    {
        cin >> input;

        for (int posCounter = 0; posCounter <= 24; posCounter += 8)
        {
            string seg = input.substr(posCounter, 8);
            cout << toBase10(seg) << (posCounter == 24 ? '\n' : '.');
        }
    }

    return 0;
}