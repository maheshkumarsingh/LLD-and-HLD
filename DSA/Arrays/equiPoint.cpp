#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   vector<int> question = {-7,1,5,2,-4,3,0};
   for(int i=1;i<question.size();i++)
   {
      question[i]+=question[i-1];
   }
   for(auto &it : question)
   cout<<it<<" ";
   cout<<endl;

   for(int i=1;i<question.size();i++)
   {
    if(question[i]-question[i-1] == question[i]-question[i+1])
    {
        cout<<i<<" ";
        break;
    }
   }
   cout<<endl;
   return 0;
}