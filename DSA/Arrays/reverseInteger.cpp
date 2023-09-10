#include <bits/stdc++.h>
using namespace std;
int ReverseInteger(int x)
{
    int sign = x > 0 ? 1 : -1;
    int num = abs(x);
    int rev = 0;
    while (num)
    {
        if(rev >= INT_MAX || rev<=INT_MIN)
            return 0;
        rev = rev * 10 + num % 10;
        num /= 10;
    }
    return (rev >= INT_MAX || rev<=INT_MIN)?0:sign * rev;
}
int main()
{
    system("cls");
    int num;
    cin >> num;
    int ans = ReverseInteger(num);
    cout << ans << endl;
    return 0;
}