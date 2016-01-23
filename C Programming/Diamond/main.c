
#include <stdio.h>
#include <stdlib.h>

void fill_matrix(size_t size, char matrix[size][size], char symbol)
{
    int row, col;
    for (row = 0; row < size; row++) 
    {       
        for (col = 0; col < size; col++) 
        {
            matrix[row][col] = symbol;
        }
    }
}

void print_matrix(size_t size, char matrix[size][size])
{
    int row, col;
    for (row = 0; row < size; row++) 
    {
        for (col = 0; col < size; col++)
        {
            printf("%c", matrix[row][col]);
        }
        
        printf("\n");
    }
}

int main(int argc, char** argv) 
{
    int n;
    scanf("%d", &n);
    
    char diamondMatrix[n][n];
    fill_matrix(n, diamondMatrix, '.');
    
    int center = n / 2;
    int row, left_asterisk_index = 0, right_asterisk_index = 0;
    for (row = 0; row < n; row++) 
    {
        if(row <= center)
        {
            left_asterisk_index = center - row;
            right_asterisk_index = center + row;
        }
        else
        {
            left_asterisk_index++;
            right_asterisk_index--;
        }
        
        diamondMatrix[row][left_asterisk_index] = '*';
        diamondMatrix[row][right_asterisk_index] = '*';
    }
    
    print_matrix(n, diamondMatrix);
    
    return (EXIT_SUCCESS);
}

