
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void print_matrix(size_t rows, size_t cols, size_t length, char matrix [rows][cols][length]);

int main(int argc, char** argv) 
{
    const size_t palindromeLen = 4;
    size_t rows;
    scanf("%lu", &rows);
    size_t cols = 3;
    scanf("%lu", &cols);
    
    char matrix[rows][cols][palindromeLen];
    
    int row, col;
    for (row = 0; row < rows; row++) 
    {
        char firstLast = 'a' + row; 
        
        for (col = 0; col < cols; col++) 
        {
            char middle = 'a' + row + col;
            
            matrix[row][col][0] = firstLast;
            matrix[row][col][1] = middle;
            matrix[row][col][2] = firstLast;
            matrix[row][col][3] = '\0';                   
        }
    }
    
    print_matrix(rows, cols, palindromeLen, matrix);
    
    return (EXIT_SUCCESS);
}

void print_matrix(size_t rows, size_t cols, size_t length, char matrix[rows][cols][length])
{
    int row, col, index;
    for (row = 0; row < rows; row++)
    {
        for (col = 0; col < cols; col++)
        {
            printf("%s ", matrix[row][col]);
        }
        
        printf("\n");
    }
}
