#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    vector<string> A = {"abcdefgh", "aefghijk", "abcefgh"};
    for (auto &&i : A)
    {
        cout << i << " ";
    }
    cout << endl;
    sort(A.begin(), A.end());
    for (auto &&i : A)
    {
        cout << i << " ";
    }
    cout << endl;
    int n = A.size();
    string res = "";
    for (int i = 0; i < A[0].size(); i++)
    {
        if (A[0][i] == A[n - 1][i])
        {
            res += A[0][i];
        }
        if (A[0][i] != A[n - 1][i])
        {
            break;
        }
    }
    if (n == 1)
    {
        cout << A[0];
    }
    cout << res;
    return 0;
}