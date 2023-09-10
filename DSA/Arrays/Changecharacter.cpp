#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   string str ="abcabbccd";
   vector<int> counts(26);
    for(auto &it : str)
        counts[it -'a']++;
    vector<pair<int,int>> p;
    for(int i=0;i<26;i++)
    {
        p[i].first = counts[i];
        p[i].second = i+'a';
    }
    for(auto &it : p)
        cout<<it.first<<" "<<it.second<<endl;
   return 0;
}