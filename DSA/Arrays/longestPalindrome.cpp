#include <bits/stdc++.h>
using namespace std;
int expand(int i, int j, string &A)
{ // expanding left and right from i and j as center index for palindrome
    while (i >= 0 && j < A.length() && A[i] == A[j])
    {
        i--;
        j++;
    }
    return j - i - 1; // returning the palindrome length
}

string longestPalindrome(string A)
{
    int ans = 1;
    int l = 0, r = 0;
    for (int i = 0; i < A.length(); i++)
    {
        int len1 = expand(i, i, A);     // when palindrome is of odd length with ith index as center
        int len2 = expand(i, i + 1, A); // when palindrome is of even length
        if (len1 > ans)
        { // selecting maximum length
            ans = len1;
            l = i;
        }
        if (len2 > ans)
        {
            ans = len2;
            l = i;
        }
    }
    r = l + (ans / 2);                                      // since l is the center point
    l = (ans % 2 == 0) ? l - (ans / 2) + 1 : l - (ans / 2); // decreasing l value respectively
    string res = "";
    for (int i = l; i <= r; i++)
    {
        res += A[i];
    }

    return res;
}
int main()
{
    system("cls");
    string str;
    cin >> str;
    cout << longestPalindrome(str) << endl;
    return 0;
}