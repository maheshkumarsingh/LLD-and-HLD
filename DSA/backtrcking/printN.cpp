#include <bits/stdc++.h>
using namespace std;

void printAllOptions(int i, int n, vector<int> &temp, vector<int> &options,int &count)
{
    if (i == n)
    {
        for (int i = 0; i < n; i++)
        {
            cout << temp[i] << " ";
        }
        return;
    }

    for (size_t j = 0; j < options.size(); j++)
    {
        temp[i] = options[j];
        printAllOptions(i + 1, n, temp, options,count);
    }
}
int main()
{
    // Write C++ code here
    int n;
    cin >> n;
    int  count=0;
    vector<int> options = {1,2};

    vector<int> temp(n, -1);

    printAllOptions(0, n, temp, options,count);
    cout << count << endl;
    return 0;
}