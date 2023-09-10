#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    vector<int> vec = {1, 2, 3, 4};
    for(auto it = vec.rbegin();it!=vec.rend();it++)
    {
        cout<<*it;
    }
    cout<<endl;
    vector<vector<int>> ans;
    vector<int> subarray;
    for (int i=0;i<vec.size();i++)
    {
        subarray.clear();
        for(int j=i;j<vec.size();j++)
        {
            subarray.push_back(vec[j]);
            ans.push_back(subarray);
        }
    }
    for (int i=0;i<ans.size();i++)
    {
        for(int j=0;j<ans[i].size();j++)
        {
            cout<<ans[i][j];
        }
        cout<<endl;
    }
    return 0;
}