#include <bits/stdc++.h>
using namespace std;
int getLongestSubarray(const vector<int> &arr)
{
    // int diff = 0;
    // int longestSub = INT_MIN;
    // int n = vec.size();
    // int count = 1;
    // for (int i = 0; i < n; i++)
    // {
    //     count=1;
    //     for (int j = i + 1; j < n; j++)
    //     {
    //         int diff = abs(vec[j] - vec[i]);
    //         if ((diff == 1 || diff == 0))
    //         {
    //             count++;
    //         }
    //         else
    //         {
    //             break;
    //         }
    //     }
    //     longestSub = max(longestSub, count);
    // }
    // return longestSub;

    unordered_set<int> hs;
    int i=0;
    int j=1;
    int longestSub=0;
    while(i< arr.size()-1)
    {
        hs.insert(arr[i]);
        while(j<arr.size() && abs(arr[i]- arr[j])<2)
        {
            if(hs.find(arr[j])== hs.end())
            {
                if(hs.size()==2)
                    break;
                else
                    hs.insert(arr[j]);
            }
        ++j;
        }
        longestSub= max(longestSub,j-i);
        j=++i + 1;
        hs.clear();
    }
    return longestSub;
}
int main()
{
    system("cls");
    vector<int> vec = {0,1,2,1,2};
    int ans = getLongestSubarray(vec);
    cout << ans << endl;
    return 0;
}