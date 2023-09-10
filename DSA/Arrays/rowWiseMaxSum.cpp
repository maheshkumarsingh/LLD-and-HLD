#include <bits/stdc++.h>
using namespace std;


int getMod(int n)
{
    int mod = 1e9+7;
    int ans = n%mod;
    if(ans < 0) ans = (ans+ mod)%mod;
    return ans;
}
long solve(vector<vector<int>> &A)
{
    vector<vector<long>> pf(A.size(), vector<long>(A[0].size()));
    // build prefix sum matrix
    int rows= A.size();
    int cols = A[0].size();
    //prefix matrix row wise
    for(int i=0;i<rows;i++){
        for(int j=1;j<cols;j++){
            A[i][j] = getMod(A[i][j] + A[i][j-1]);
        }
    }
    //prefix matrix col wise
    for(int i=0;i<cols;i++){
        for(int j=1;j<rows;j++){
            A[j][i] = getMod(A[j][i] + A[j-1][i]);
        }
    }
    for (int i = 0; i < rows; i++)
    {
        long sum = 0;
        for (int j = 0; j < cols; j++)
        {
            cout<<A[i][j]<<" ";
        }
        cout<<endl;
    }
    cout<<endl;
    
    int n = A.size();
    int m = A[0].size();
    // // row-wise sum
    // for (int i = 0; i < n; i++)
    // {
    //     long sum = 0;
    //     for (int j = 0; j < m; j++)
    //     {
    //         sum += A[i][j];
    //         pf[i][j] = sum;
    //     }
    // }
    // // col-wise sum
    // for (int i = 0; i < m; i++)
    // {
    //     long sum = 0;
    //     for (int j = 0; j < n; j++)
    //     {
    //         sum += pf[j][i];
    //         pf[j][i] = sum;
    //     }
    // }
    // for (int i = 0; i < n; i++)
    // {
    //     long sum = 0;
    //     for (int j = 0; j < m; j++)
    //     {
    //         cout<<pf[i][j]<<" ";
    //     }
    //     cout<<endl;
    // }
    // cout<<endl;
    long ans = INT_MIN;
    // here a1, b1 is iterating
    // a2, b2 is fixed A[n-1][m-1];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int a1 = i, b1 = j;
            int a2 = n - 1, b2 = m - 1;
            long result = A[a2][b2];
            if (a1 > 0)
                result -= A[a1 - 1][b2];
            if (b1 > 0)
                result -= A[a2][b1 - 1];
            if ((a1 > 0) && (b1 > 0))
                result = (result + A[a1 - 1][b1 - 1]);

            ans = max(ans, result);
        }
    }
    return ans;
}

int main()
{
    system("cls");
    vector<vector<int>> vec= {{1,2,3},{4,5,6},{7,8,9}};
    long ans = solve(vec);
    cout<<ans<<endl;
    return 0;
}