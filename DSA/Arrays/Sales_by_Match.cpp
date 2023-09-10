#include<bits/stdc++.h>
using namespace std;
int ReturnPairOfSocks(vector<int> &vec)
{
    int ans =0;
    int count=1;
    sort(vec.begin(), vec.end());
    for(auto &it: vec)
    cout<<it<<" ";
    cout<<endl;
    for (int i = 1; i < vec.size(); i++)
    {
        if(vec[i]==vec[i-1]) count++;
        // if(vec[i]==3)
        // cout<<"3"<<endl;
        else
        {
            ans += count/2;
            cout<<ans<<"  "<<count<<" "<<vec[i]<<endl;
            count=1;
        }
    }
    ans += count/2;
    return ans;
    
}
int main()
{
   system("cls");
   vector<int> question = {1 ,1, 3, 1, 2, 1, 3, 3, 3, 3};
   cout<<ReturnPairOfSocks(question);
   return 0;
}