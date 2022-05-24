#include <iostream>
#include <string>

using namespace std;

string toBase2(int n)
{
    string r = "";
    while (n > 0)
    {
        if (n % 2 == 1)
            r = "1" + r;
        else
            r = "0" + r;
        n >>= 1;
    }

    return r;
}

int main()
{
    int testCase;
    cin >> testCase;

    string input;

    while (testCase--)
    {
        cin >> input;

        int before = 0;

        for (int i = 0; input[i] != '\0'; i++)
        {
            if (input[i] == '.')
            {
                string result = toBase2(stoi(input.substr(before, i)));
                cout << result.insert(0, 8 - result.size(), '0');
                before = ++i;
            }
        }

        string result = toBase2(stoi(input.substr(before, input.length())));
        cout << result.insert(0, 8 - result.size(), '0');

        cout << endl;
    }

    return 0;
}