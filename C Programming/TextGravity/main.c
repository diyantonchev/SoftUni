
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#define BUFFER_SIZE 1000

void fill_matrix(int rows, int columns, char matrix[rows][columns], char* text, int length);

void run_gravity(int rows, int columns, char matrix[rows][columns]);

void print_matrix(int rows, int cols, char matrix[rows][cols]);

int main(int argc, char** argv)
{   
    int columns;
    scanf("%d", &columns);
    scanf("\n");
    
    char text[BUFFER_SIZE];
    fgets(text, BUFFER_SIZE, stdin);
    text[BUFFER_SIZE - 1] = '\0';
    
    int length = strlen(text) - 1;
    int rows = (length / columns) + 1;      
    char matrix[rows][columns];    
    fill_matrix(rows, columns, matrix, text, length);
    print_matrix(rows, columns, matrix);
    printf("\n");
    run_gravity (rows, columns, matrix);
    print_matrix(rows,columns, matrix);
    
    return (EXIT_SUCCESS);
}

void fill_matrix(int rows, int columns, char matrix[rows][columns], char* text, int text_length)
{
    int row, col, text_index = 0;
    for (row = 0; row < rows; row++)
    {
        for (col = 0; col < columns; col++) 
        {   
            if (text_index < text_length)
            {
                char current_letter = text[text_index];
                matrix[row][col] = current_letter;             
            }
            else
            {
                matrix[row][col] = ' ';
            } 
            
             text_index++;
        }      
    }
}

void run_gravity(int rows, int columns, char matrix[rows][columns])
{
    bool has_falling = true;
    
    while (has_falling) 
    {
        has_falling = false;
        int row, col;
        for (row = rows - 1; row > 0; row--) 
        {
            for (col = 0; col < columns; col++) 
            {
                char lower_cell  = matrix[row][col];
                char upper_cell = matrix[row - 1][col];
                if (lower_cell == ' ' && upper_cell != ' ') 
                {
                    matrix[row - 1][col] = lower_cell;
                    matrix[row][col] = upper_cell;
                    has_falling = true;
                }
            }
        }     
    }
}

void print_matrix(int rows, int cols, char matrix[rows][cols])
{
    int row, col;
    for (row = 0; row < rows; row++)
    {
        printf("| ");
        for (col = 0; col < cols; col++) 
        {   
            printf("%c ",matrix[row][col]);
        }
        
        printf("|\n");
    }
} 
