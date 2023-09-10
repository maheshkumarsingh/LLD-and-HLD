#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    int a;
    int b;
    cin >> a >> b;

    int gcd = 0;
    int minOfAandB=min(a, b);
    for (int i = 1; i * i <= minOfAandB; i++)
    {
        if (a % i == 0 && b % i == 0)
            gcd= max(gcd,i);
        int value = (minOfAandB/i);
        if((a % value)==0 && (b % value)==0)
            gcd = max(gcd, value);
    }
    cout<<gcd<<endl;
    return 0;
}