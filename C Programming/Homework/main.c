
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define  BUFFER_SIZE 255

double reverse(char number[], int *error);

int get_last_index(char*, char);

int main(int argc, char** argv)
{
    char number[BUFFER_SIZE];
    scanf("%s", number);
    
    int error;
    double reversed = reverse(number, &error);
    
    if(error == 1)
    {
        printf("Invalid format");
        return 1;
    }
    
    printf("%.3lf", reversed);
    
    return (EXIT_SUCCESS);
}

double reverse(char number[], int *error)
{    
    size_t size = strlen(number);   
    char reversed_string[size];
    int i, j;
    for (i = size - 1, j = 0; i >= 0; i--,j++) 
    {   
        if (!isdigit(number[i]))
        {
            *error = 1;
            return 0;
        }
        
        reversed_string[j] = number[i];
    }
    
    double reversed_number = atof(reversed_string);
    *error = 0;
    return reversed_number;
}