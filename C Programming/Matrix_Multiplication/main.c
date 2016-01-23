
#include <stdio.h>
#include <stdlib.h>

void fill_matrix(int rows_count, int cols_count, int matrix[rows_count][cols_count]);

void multiply_matrices(int n, int m, int first_matrix[n][m], int second_matrix[m][n], int result[n][n]);

void print_matrix(int rows_count, int cols_count, int matrix[rows_count][cols_count]);

int main(int argc, char** argv) 
{
    int n, m;
    scanf("%d %d", &n, &m);
    
    int first_matrix[n][m];
    fill_matrix(n, m, first_matrix);
    
    int second_matrix[m][n];
    fill_matrix(m, n, second_matrix);
    
    int result_matrix[n][n];
    multiply_matrices(n, m, first_matrix,second_matrix, result_matrix);
    print_matrix(n, n, result_matrix);
    
    return (EXIT_SUCCESS);
}

void fill_matrix(int rows_count, int cols_count, int matrix[rows_count][cols_count])
{
    int row, col;
    for (row = 0; row < rows_count; row++)
    {       
        for (col = 0; col < cols_count; col++) 
        {
            scanf("%d", &matrix[row][col]);
        }
    }
}

void print_matrix(int rows_count, int cols_count, int matrix[rows_count][cols_count])
{
    int row, col;
    for (row = 0; row < rows_count; row++)
    {       
        for (col = 0; col < cols_count; col++) 
        {
            printf("%d ", matrix[row][col]);
        }
        
        printf("\n");
    }
}

void multiply_matrices(int n, int m, int first_matrix[n][m], int second_matrix[m][n], int result[n][n])
{    
    int row1, col1, row2, col2;
    for (col2 = 0; col2 < n; col2++) 
    {
        for (row1 = 0; row1 < n; row1++) 
        {  
           int current_cell = 0;
           for (col1 = 0, row2 = 0; col1 < m; col1++, row2++)
           {
              current_cell += first_matrix[row1][col1] * second_matrix[row2][col2];
           }
           
           result[row1][col2] = current_cell;
        }       
    }  
}