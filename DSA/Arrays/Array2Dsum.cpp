#include <bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");

   vector<vector<int>> que =
       {
           {1, 2, 3, 4, 9, 10}, {5, 6, 7, 8}, {9, 2, 3, 4}
       };

   //cout << que[0].size();
   vector<vector<int>> ans(que.size(), vector<int>(que[0].size()));
   for (int i = 0; i < que.size(); i++)
   {
      ans.push_back(que[i]);
   }
   
   for (int i = 0; i < ans.size(); i++)
   {
      for (size_t j = 0; j < ans[i].size(); j++)
      {
         cout<<ans[i][j]<<" ";
      }
      cout<<endl;
   }
   
   return 0;

   
}