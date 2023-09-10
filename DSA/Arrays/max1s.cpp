#include<bits/stdc++.h>
using namespace std;

int maximum1s(vector<vector<int>> &vec)
{
    int minRow=INT_MAX;
    int row=0;
    int count=0;
    for (int i = 0; i < vec.size(); i++)
    {
        count=0;
        for (int j = 0; j < vec[i].size(); j++)
        {
            if(vec[i][j]==1) count++;
        }
        if(count>row)
        {
            row = count;
            minRow = i;
        }
        
    }
    return minRow;
}
int main()
{
   system("cls");
   vector<vector<int>> vec= {{0,1,1},{0,0,1},{0,1,1},{1,1,1},{1,1,1},{1,1,1}};
   cout<<maximum1s(vec)<<endl;
   return 0;
}