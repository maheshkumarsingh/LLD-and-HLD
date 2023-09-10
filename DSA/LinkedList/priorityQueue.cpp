#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   vector<int> vec = {5,6,7,8,2,3,1,4,5,2};
   priority_queue<int,vector<int>, greater<int>> pq(vec.begin(),vec.end());

   while(!pq.empty())
   {
      cout<<pq.top()<<" ";
      pq.pop();
   }
   cout<<endl;
   return 0;
}