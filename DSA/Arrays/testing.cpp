#include<bits/stdc++.h>
using namespace std;

int test(int n)
{
    static int count =0;
    if(n%2==0) return 0;
    cout<<++count<<endl;
    return test(n-1) + test(floor(n/2));
}
int main()
{
   system("cls");
   int n;
   cin>>n;
   cout<<test(n);
   return 0;
}