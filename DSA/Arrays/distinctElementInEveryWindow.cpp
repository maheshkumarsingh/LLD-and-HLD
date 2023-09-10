#include <bits/stdc++.h>
using namespace std;
vector<int> dNums(vector<int> &A, int B)
{
    unordered_map<int, int> umap;
    vector<int> result;
    for (int i = 0; i < B; i++)
    {
        if (umap.find(A[i]) == umap.end())
            umap.insert({A[i], 1});
        else
            umap[A[i]]++;
    }
    result.push_back(umap.size()); // pushing size of first window
    for (int i = B; i < A.size(); i++)
    {
        umap[A[i - B]]--;
        if (umap[A[i - B]] == 0)
            umap.erase(A[i - B]); // this condition is imp to reduce the size if the freq is 0
        if (umap.find(A[i]) == umap.end())
            umap.insert({A[i], 1});
        else
            umap[A[i]]++;
        result.push_back(umap.size());
    }
    return result;
}
int main()
{
    system("cls");

    return 0;
}