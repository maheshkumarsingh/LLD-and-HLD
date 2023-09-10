#include<bits/stdc++.h>
using namespace std;
vector<int> binaryToGrayFrom0ToN(int n)
{
    vector<int> ans;
    for(int i=0;i<pow(2,n);i++)
    {
        ans.push_back(i ^ (i>>1));
    }
    return ans;
}
int main()
{
   system("cls");
   int n;
   cin>>n;
   vector<int> ans = binaryToGrayFrom0ToN(n);
   for(auto &it : ans)
   cout<<it<<" ";
   return 0;
}