#include <bits/stdc++.h>
using namespace std;
class Matrix
{
public:
    int rows;
    int columns;
    vector<vector<int>> matrix;
    Matrix(int rows, int columns)
    {
        this->rows = rows;
        this->columns = columns;

        for (int i = 0; i < rows; i++)
        {
            vector<int> vec(columns);
            matrix.push_back(vec);
        }
    }
    void input()
    {
        // Complete the function
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                cin >> matrix[i][j];
            }
        }
    }

    Matrix add(Matrix x)
    {
        Matrix ans = Matrix(rows, columns);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                ans.matrix[i][j] = matrix[i][j] + x.matrix[i][j];
            }
        }
        return ans;
    }
    Matrix substract(Matrix x)
    {
        Matrix ans = Matrix(rows, columns);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                ans.matrix[i][j] = matrix[i][j] - x.matrix[i][j];
            }
        }
        return ans;
    }
    Matrix transpose()
    {
        Matrix ans = Matrix(rows, columns);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                ans.matrix[j][i] = matrix[i][j];
            }
        }
        return ans;
    }
    void print()
    {
        // Complete the function
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                cout << matrix[i][j] << " ";
            }
            cout <<endl<<endl;
        }
    }
};

int main()
{
    system("cls");
    Matrix a(3, 3);
    a.input();
    a.print();
    Matrix b(3, 3);
    b.input();
    b.print();

    Matrix c1 = a.add(b);
    c1.print();
    Matrix c2 = a.substract(b);
    c2.print();
    Matrix c3 = a.transpose();
    c3.print(); 
    return 0;
}