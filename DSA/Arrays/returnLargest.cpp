#include <bits/stdc++.h>
using namespace std;
bool compare(int a, int b)
{

    string a_bStr = to_string(a) + to_string(b);
    string b_aStr = to_string(b) + to_string(a);
    cout<<a<<" "<<b<<" "<<a_bStr<<" "<<b_aStr<<endl;
    if (a_bStr.compare(b_aStr) > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int main()
{
    system("cls");
    vector<int> vec = {3, 30, 34, 5, 9};
    sort(vec.begin(), vec.end(), compare);
    for (auto &it : vec)
        cout << it;
    cout << endl;
    string ans = "00000";
    cout<<ans.substr(4)<<endl;
    return 0;
}