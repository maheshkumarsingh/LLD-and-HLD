#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    int A = 4;
    int i = 1;
    while (i <= A)
    {
        if (i * i == A)
        {
            cout << i << endl;
            break;
        }
        else
            i++;
    }
    return 0;
}