#include<bits/stdc++.h>
using namespace std;
int sumOfN(int n)
{
    //cout<<n<<endl;
    if(n==0) return 0;
    return n + sumOfN(n-1);
}

int factofN(int n)
{
    if(n==0) return 1;

    return n * factofN(n-1);
}
int NthFibonacciNumber(int n)
{
    if(n<=1) return n;
    return NthFibonacciNumber(n-1) + NthFibonacciNumber(n-2);
}
void printNumbers(int n)
{
    static int count =0;
    cout<<n<<" "<<count++<<endl;
    if(n==1) {
        cout<<n<<"hey";
        return;
    }
    printNumbers(n-1);
    cout<<n<<"hii";
}
int main()
{
   system("cls");
   int N;
   cin>>N;

   cout<<sumOfN(N)<<endl;
   cout<<factofN(N)<<endl;
   cout<<NthFibonacciNumber(N)<<endl;
   printNumbers(N);
   return 0;
}