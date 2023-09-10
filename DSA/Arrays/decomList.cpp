#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   vector<int> nums = {1,2,3,4};
    int n = nums.size();;
    for (auto &&i : nums)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    // for(int i=0;i<n;i+=2)
    // {
    //     int freq = nums[i];
    //     int val = nums[i + 1];
    //     while(freq--) cout<<val<<" ";
    // }
    // cout<<endl;
    nums.insert(nums.begin()+1,2,100);
    for (auto &&i : nums)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    cout<<endl;
    pair<int, int> p = {1,2};
    cout<<p.first<<endl;
   return 0;
}