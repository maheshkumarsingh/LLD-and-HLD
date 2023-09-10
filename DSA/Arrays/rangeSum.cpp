#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   vector<int> A = {7, 3, 1, 5, 5, 5, 1, 2, 4, 5 };
   vector<vector<int>> B = {{7, 10},{3, 10},{3, 5},{1, 10}};
   for(auto &it:A)
   cout<<it<<" ";
   cout<<endl;
   vector<long long> ans;

   for (size_t i = 1; i < A.size(); i++) //12 28 11 38
   {
    A[i] += A[i-1];
   }
   for(auto &it:A)
   cout<<it<<" ";
   cout<<endl;
   for(int i=0;i<B.size();i++)
   {
    if(B[i][0] - 2<0)
    ans.push_back(A[B[i][1]-1]);
    else
    ans.push_back(A[B[i][1]-1] - A[B[i][0] - 2]);
   }
   for(auto &it:ans)
   cout<<it<<" ";
   cout<<endl;
   return 0;
}