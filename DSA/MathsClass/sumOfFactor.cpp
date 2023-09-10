#include <bits/stdc++.h>
using namespace std;
int sumFactor(int A)
{
    int sum = 0;
    if (A == 1)
        return 0;
    for (int i = 1; i * i <= A; i++)
    {
        if (A % i == 0)
        {
            sum += i;
            if (i != (A / i) && i!=1)
                sum += (A / i);
            cout<<sum<<"  "<<i<<endl;
        }
    }
    cout<<sum<<endl;
    if (sum == A)
        return 1;
    else
        return 0;
}
int main()
{
    system("cls");
    int A,B;
    cin >> A>>B;
    // cout << sumFactor(A);
    double ans = (double)(A * 1.5 + B);
    cout<<(int)ans<<endl;

    return 0;
}