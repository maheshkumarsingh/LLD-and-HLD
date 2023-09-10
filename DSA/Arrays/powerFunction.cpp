#include<bits/stdc++.h>
using namespace std;
//approach1
int pow(int a, int n)
{
    if(n==0) return 1;
    return a*pow(a,n-1);
}
int powApproach2(int a, int n)//2^4 = 2^2 * 2^2
{
    if(n==0) return 1;
    if(n%2==0) return powApproach2(a,n/2) * powApproach2(a,n/2);
    else return powApproach2(a,n/2) * powApproach2(a,n/2)*a;
}
int powApproach3(int a, int n,int mod)
{
    long x = powApproach3(a,n/2,mod)%mod;
    if(n==0) return 1;
    if((n&1)==0) return ((x%mod) * (x%mod))%mod;
    else return ((((x%mod)*(x%mod)%mod)*(a%mod))%mod);
}
int main()
{
   system("cls");
   cout<<pow(5,2)<<endl;
   cout<<pow(2,3)<<endl;
   cout<<powApproach2(5,3)<<endl;
   cout<<powApproach2(5,2)<<endl;
   //cout<<powApproach3(100,100,10e9+7)<<endl;
   cout<<floor(5/2)<<endl;
   return 0;
}