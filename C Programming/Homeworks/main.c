
#include <stdio.h>
#include <stdlib.h>

void print_matrix(int size, int matrix[size][size]);
void fill_matrix(int size, int matrix[size][size]);

int main(int argc, char** argv)
{
    int n;
    scanf("%d", &n);

    int size = n;
    int matrix[size][size];
    fill_matrix(size,matrix);
    int filled_rows = 0, filled_cols = 0;

    int row = 0, col, value = 1;
    while (size >= 0) 
    {
        for (col = filled_cols; col < size; col++) 
        {
            matrix[row][col] = value;
            value++;
        }

        filled_rows++;
        col--;
        for (row = filled_rows; row < size; row++) 
        {
            matrix[row][col] = value;
            value++;
        }

        row--;
        for (col = col - 1; col >= filled_cols; col--)
        {
            matrix[row][col] = value;
            value++;
        }

        col++;
        filled_cols++;
        for (row = row - 1; row >= filled_rows; row--)
        {
            matrix[row][col] = value;
            value++;
        }
        
        row++;
        size--;
    }
    
    print_matrix(n, matrix);
    
    return (EXIT_SUCCESS);
}

void fill_matrix(int size, int matrix[size][size])
{
    int row;
    for (row = 0; row < size; row++)
    {
        int col;
        for (col = 0; col < size; col++)
        {            
           matrix[row][col] = 0;
        }
    }
}

void print_matrix(int size, int matrix[size][size])
{
    int row;
    for (row = 0; row < size; row++)
    {
        int col;
        for (col = 0; col < size; col++)
        {            
            printf("%-3d ", matrix[row][col]);
        }

        printf("\n");
    }
}