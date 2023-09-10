#include<bits/stdc++.h>
using namespace std;
int maxArea(vector<int>& height) {
        int maxWater = INT_MIN;
        int length = 0;
        int minHeight = 0;
        int start =0;
        int end = height.size()-1;
        for(int i=0;i<height.size();i++)
        {
            for(int j=i+1;j<height.size();j++)
            {
                minHeight = min(height[i], height[j]);
                length = j-i;

                maxWater = max(maxWater, minHeight*length);
            }
        }
        
        // while(start<end)
        // {
        //     minHeight = min(height[start], height[end]);
        //     length = end - start;
        //     maxWater = max(maxWater, length * minHeight);
        //     while(minHeight >= height[start] && start<end) start++;
        //     while(minHeight >= height[end] && start<end) end--;
        // }
        return maxWater;
    }
int main()
{
   system("cls");
   vector<int> vec = {1,2,1};
   cout<<maxArea(vec)<<endl;
   return 0;
}