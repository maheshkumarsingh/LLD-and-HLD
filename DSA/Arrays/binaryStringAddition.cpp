#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    string res;
    string a = "111";
    string b = "11";
    int i = a.length() - 1;
    int j = b.length() - 1;
    int carry = 0;
    while (i >= 0 || j >= 0) // 111 11
    {
        int sum = carry;
        if (i >= 0)
            sum += a[i--] - '0';
        cout << sum << " ";
        if (j >= 0)
            sum += b[j--] - '0';
        cout << sum << " ";
        carry = sum > 1 ? 1 : 0;
        res += to_string(sum % 2);
        cout<<carry<<" "<<res<<endl;
    }
    if (carry)
        res += to_string(carry);
    reverse(res.begin(), res.end());
    cout<<carry<<" "<<res<<endl;
    return 0;
}