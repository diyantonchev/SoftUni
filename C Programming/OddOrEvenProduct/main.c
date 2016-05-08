
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define BUFFER_SIZE 50

int main(int argc, char** argv) 
{
    char *input_line;
    fgets(input_line, BUFFER_SIZE, stdin);
    
    char *delimeter = " ";
    char *number_token; 
    number_token = strtok(input_line, delimeter);
    
    int even_product = 1, odd_product = 1, is_even = 0;
    
    while(number_token != NULL)
    {
        int current_number = atoi(number_token);
        
        if(is_even)
        {
            odd_product *= current_number;
        }
        else 
        {
            even_product *= current_number;
        }
        
        is_even = !is_even;
        
        number_token = strtok(NULL, delimeter);
    }
    
    if (even_product == odd_product) 
    {
         printf("yes\nproduct = %d", even_product); 
    }
    else
    {
        printf("no\nodd_product = %d\neven_product = %d", odd_product, even_product);
    }
           
    return (EXIT_SUCCESS);
}