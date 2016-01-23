
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define BUFFER_SIZE 1000

void print_text(int rows, int cols, char matrix[rows][cols])
{
    int row, col;
    for (row = 0; row < rows; row++)
    {
        for (col = 0; col < cols; col++) 
        { 
            if (matrix[row][col] != '1')
            {
                printf("%c",matrix[row][col]);
            } 
        }
    }
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

int main(int argc, char** argv)
{
    char text[BUFFER_SIZE];
    fgets(text, BUFFER_SIZE, stdin);
    text[BUFFER_SIZE - 1] = '\0';
    
    int columns;
    scanf("%d", &columns);
    
    int text_length = strlen(text) - 1;    
    int rows = (text_length / columns) + 1;      
    char matrix[rows][columns];    
    fill_matrix(rows, columns, matrix, text, text_length);
    
    scanf("\n");
    int current_bomb;
    int bombs = scanf("%d", &current_bomb);
    while (bombs > 0) 
    {
        int row, has_bombard = 0;
        for (row = 0; row < rows; row++)
        {
           if(matrix[row][current_bomb] != ' ')
           {
               matrix[row][current_bomb] = '1';
               has_bombard = 1;
           } 
           else if(has_bombard )
           {
               break;
           }
        }
        
        bombs = scanf("%d", &current_bomb);
    }
    
     print_text(rows, columns, matrix);
    
    return (EXIT_SUCCESS);
}