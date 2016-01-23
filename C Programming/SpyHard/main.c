#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define BUFFER_SIZE 150

char* convert_to_numeral_system(int number, int numeralSystem);

void reverse_string(char* src, char* dest, size_t size);

int main(int argc, char** argv) 
{   
    int numerealSystem;
    scanf("%d", &numerealSystem);
    scanf("\n");
    
    char msg[BUFFER_SIZE];
    fgets(msg, BUFFER_SIZE, stdin);
    
    size_t msg_size = strlen(msg) - 1;
    msg[msg_size] = '\0';
    
    char result[BUFFER_SIZE];
    sprintf(result,"%d%lu", numerealSystem, msg_size);
    
    int i, number = 0;
    for (i = 0; i < msg_size; i++) 
    {
        if(isalpha(msg[i]))
        {
            char current_letter = tolower(msg[i]);
            int position = (int)(current_letter - 'a') + 1;
            number += position;
        }
        else
        {
            number += msg[i];
        }        
    }
    
    char* converted = convert_to_numeral_system(number, numerealSystem);
    size_t converted_size = strlen(converted);
    strncat(result,converted,converted_size);
    
    printf("%s", result);
    free(converted);
    
    return (EXIT_SUCCESS);
}

char* convert_to_numeral_system(int number, int numeralSystem)
{ 
        char* current = (char*)malloc(BUFFER_SIZE);
        int index = 0;
        
        while(number > 0)
        {
            char digit = number % numeralSystem; 
            current[index] = digit + '0';
            number /= numeralSystem;
            index++;
        }
        
        current[index] = '\0';
        char* final = (char*)malloc(BUFFER_SIZE);
        reverse_string(current, final, index);
               
        free(current);
        
        return final;
}

void reverse_string(char* src, char* dest, size_t size)
{
    int i, j = 0;
    for (i = size - 1; i >= 0; i--, j++)
    {
        dest[j] = src[i];
    }
    
    dest[j] = '\0';
}
