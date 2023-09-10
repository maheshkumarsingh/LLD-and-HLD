#include <bits/stdc++.h>
using namespace std;
vector<int> productArrayPuzzle(vector<int> nums)
{
    int n = nums.size();
    int prefixProd[n];
    int suffixProd[n];
    vector<int> ans;
    prefixProd[0] = nums[0];
    
    for (int i = 1; i < n; i++) 
    {
        prefixProd[i] = nums[i] * prefixProd[i - 1];
    }
    suffixProd[n - 1] = nums[n - 1];
    for (int i = n - 2; i >= 0; i--)
    {
        suffixProd[i] = suffixProd[i + 1]*nums[i];
    }
    
    for (int i = 0; i < n; i++)
    {
        if (i == 0)
            ans.push_back(suffixProd[1]);
        else if (i == n - 1)
            ans.push_back(prefixProd[n - 2]);
        else
            ans.push_back(prefixProd[i - 1] * suffixProd[i + 1]);
    }
    return ans;
}
int main()
{
    system("cls");
    vector<int> nums = {1, 2, 3, 4, 5};
    vector<int> ans = productArrayPuzzle(nums);
    for (auto &it : ans)
        cout << it << " ";
    cout << endl;
    return 0;
}