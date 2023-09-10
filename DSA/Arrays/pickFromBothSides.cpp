#include<bits/stdc++.h>
using namespace std;

int pickFromBothSide(vector<int> A, int B)
{
    int maxSum =0;
    for(int i=0;i<B;i++)
    {
        maxSum += A[i]; 
    }

    int temp =B;
    int sum = maxSum;
    for (size_t i = A.size()-1; i >=A.size() - B; i--)
    {
        sum += A[i] - A[temp-1];  
        maxSum = max(sum, maxSum);
        temp--;
    }
    return maxSum;


    
}
int main()
{
   system("cls");
   vector<int> A;
   int n;
   cin>>n;
   while(n--)
   {
    int k;
    cin>>k;
    A.push_back(k);
   }
   int B;
   cin>>B;

   int maxSum = pickFromBothSide(A,B);
   cout<<maxSum<<endl;

   
   return 0;
}