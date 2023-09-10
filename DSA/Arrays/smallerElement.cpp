#include <bits/stdc++.h>
using namespace std;
vector<int> getSmallerElemnts(vector<int> nums)
{
    int n = nums.size();
    vector<int> counts(101);

    for(auto &num : nums)
        counts[num] ++;
    
    vector<int> prefixCounts(101);
    prefixCounts[0]= counts[0];

    for(int i=1;i<101;i++)
        prefixCounts[i] = prefixCounts[i-1] + counts[i];
    vector<int> ans(n);
    for(int i=0;i<n;i++)
    {
        if(nums[i]==0)
            continue;
        ans[i] = prefixCounts[nums[i]] - counts[nums[i]];
    }
    return ans;
}
int main()
{
    system("cls");
    vector<int> nums = {8, 1, 2, 2, 3};
    for (auto &it : nums)
        cout << it << " ";
    cout << endl;
    vector<int> vec = nums;
    sort(vec.begin(), vec.end());
    map<int, int> mp;
    for (int i = nums.size() - 1; i >= 0; i--)
        mp[vec[i]] = i;

    for (int i = 0; i < vec.size(); i++)
        nums[i] = mp[nums[i]];
    for (auto &it : nums)
        cout << it << " ";
    cout << endl;
    vector<int> ans = getSmallerElemnts(nums);
    for (auto &it : ans)
        cout << it << " ";
    cout << endl;
    return 0;
}