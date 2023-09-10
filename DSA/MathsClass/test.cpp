#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    int arr[] = {-3,13,10,1, 2, 4, 5, 7, 7,3,6,0,13,111};
    int maxi = *max_element(arr, arr + 6);
    cout << 6 - count(arr, arr + 6, maxi) << endl;

    // 2nd question
    int n=sizeof(arr)/sizeof(arr[0]);
    vector<pair<int,int>> ans;
    for (int i = 0; i < n; i++)
    {
        for (int j = i+1; j < n; j++)
        {
            if(arr[i]+arr[j]==10)
            ans.push_back({arr[i], arr[j]});
        }
    }
    for(auto &it:ans)
    cout<<it.first<<"  "<<it.second<<endl;
    cout<<endl;
    for(int i=0;i<n;i++)
    cout<<arr[i]<<",";
    cout<<endl;
    int i=0;
    int j=n-1;
    while(i<j)
    {
        arr[i] = arr[i]^ arr[j];
        arr[j] = arr[i]^ arr[j];
        arr[i] = arr[i]^ arr[j];
        i++;
        j--;
    }
    for(int i=0;i<n;i++)
    cout<<arr[i]<<",";
    cout<<endl;
    // 1 2 3 4 5
    int k;
    cin>>k;

    // int temp[k];
    // for(int i=0;i<k;i++)//1 2
    // temp[i] = arr[i];
    
    // for(int i=k;i<n;i++)
    // arr[i] = arr[i-k]; //3 4 5

    // for(int i=n-k;i<n;i++)
    // arr[i] = temp[i-k];
    //1 2 3 4 5
    //5 4 3 2 1
    //5 4 1 2 3
    int arr1[] = {1,2,3,4,5,6,7,8,9};
    int n1=sizeof(arr1)/sizeof(arr1[0]);
    reverse(arr1, arr1+n1);
    reverse(arr1, arr1+k);
    reverse(arr1+k,arr1+n1);
    for(int i=0;i<n1;i++)
    cout<<arr1[i]<<",";
    cout<<endl;




    vector<int> ans = {1,2,3,4,5,6,7,8,9,0};
    for(auto itr = ans.rbegin(); itr!= ans.rend();itr++)
    cout<<(itr->first)<<" ";
    return 0;
}