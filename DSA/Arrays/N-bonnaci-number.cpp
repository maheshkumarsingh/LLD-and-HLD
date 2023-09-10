#include <bits/stdc++.h>
using namespace std;

vector<int> nBonnaciNumber(int N, int M)
{
    int arr[M] = {0};
    arr[N - 1] = 1; // 0 0 1
    arr[N] = 1;
    int prefixSum = 1;
    for (int i = N + 1; i < M; i++)
    {
        prefixSum += prefixSum - arr[i - N - 1];
        arr[i] = prefixSum;
    }
    for (int i = 0; i < M; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;
    return {1, 2, 3};
}
int main()
{ 
    system("cls"); // 0, 0, 1, 1, 2, 4, 7, 13 N=3 and M=8
    int n, m;
    cin >> n >> m;
    vector<int> ans = nBonnaciNumber(n, m);
    for (auto &it : ans)
        cout << it << " ";
    cout << endl;

    vector<int> A(5*5);
    cout<<A.size()<<endl;
    return 0;
}