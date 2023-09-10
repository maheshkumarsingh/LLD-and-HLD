#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   set<int> se;
   se.insert(1);
   se.insert(2);
   se.insert(3);
   se.insert(4);
   se.insert(1);
   se.insert(2);
   se.insert(3);
   se.insert(4);
   auto it = se.find(4);
   cout<<*it<<endl;
   auto itr = se.count(7);
   cout<<itr<<endl;
   return 0;
}