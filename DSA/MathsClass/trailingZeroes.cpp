#include <bits/stdc++.h>
using namespace std;

int findTrailingZeroesInFact(int n)
{
    int res = 0;
    for (int i = 5; i <= n; i = i * 5)
    {
        res = res + n / i;
    }
    return res;
}
int main()
{
    system("cls");
    int t;
    cin >> t;
    while (t--)
    {
        int n;
        cin >> n;
        cout << "To find traling zeroes of " << n << "! = " << findTrailingZeroesInFact(n) << endl;
    }
    cout<<endl;
    cout<<floor(log2(11))<<endl;
    string ans = "mah";
    cout<<ans[7]<<endl;
    return 0;
}