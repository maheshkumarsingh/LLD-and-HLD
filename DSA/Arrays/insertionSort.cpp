// Iterative CPP program to sort
// an array by swapping elements
#include <iostream>
#include <vector>
using namespace std;
using Vector = vector<int>;

// Utility function to print a Vector
void printVector(const Vector &V)
{
    for (auto e : V)
    {
        cout << e << " ";
    }
    cout << endl;
}

// Function performs insertion sort on
// vector V
void insertionSort(Vector &V)
{
    int N = V.size();
    int i, j, key;

    int count=0;
    for (i = 1; i < N; i++)
    {
        j = i;
        // Insert V[i] into list 0..i-1
        while (j > 0 and V[j] < V[j - 1])
        {

            // Swap V[j] and V[j-1]
            swap(V[j], V[j - 1]);
            count++;
            // Decrement j by 1
            j -= 1;
        }
    }
    cout<<count<<endl;
}

// Driver Code
int main()
{
    Vector A = {2, 0, 1, 3};

    cout << "Array: " << endl;
    printVector(A);

    cout << "After Sorting :" << endl;
    insertionSort(A);
    printVector(A);

    return 0;
}
