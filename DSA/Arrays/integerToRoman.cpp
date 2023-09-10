#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    int num;
    cin>>num;
    vector<int> integers = {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
    vector<string> romans = {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
    string ans = "";
    int temp=0;
    for (int i = 12; i >= 0; i--)
    {
        temp = num/integers[i];
        
        for(int j=0;j<temp;j++)
            ans.append(romans[i]);
        
        num = num % integers[i];
        cout<<temp<<" "<<integers[i]<<" "<<ans<<endl;
    }
    return 0;
}