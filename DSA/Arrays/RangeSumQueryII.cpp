#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    vector<int> A = {1, 2, 3, 4, 5};
    vector<vector<int>> B = {{1, 4}, {2, 3}};
    cout<<B.size()<<endl;
    for (size_t i = 0; i < B.size(); i++)
    {
        int sum = 0;
        cout<<B[i][0]<<"  "<<B[i][1]<<endl;
        for (int j = B[i][0]; j <= B[i][1]; j++)
        {
            sum+= A[j-1];
        }
        A[i] = sum;
    }
    A.resize(B.size());
    for(auto &it : A)
    cout<<it<<" ";
    return 0;
}