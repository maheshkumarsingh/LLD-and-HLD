#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   
   int i=5;
   while(i--)
   {
      cout<<i<<" ";
   }
   cout<<endl;
   for (int i = 5; i >= 0; i--)
   {
      if(i==2)
         continue;
      cout<<i<<" ";   
   }
   
   return 0;
}