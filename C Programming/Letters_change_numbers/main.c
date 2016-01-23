
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define INITIAL_BUFFER_SIZE 50

double get_number(char* str, size_t len)
{
    char temp[len];
    int i, j;
    for (i = 1, j = 0; i < len; i++, j++)
    {
      temp[j] = str[i];  
    }
    
    char* remeinder;
    double number = strtod(temp, &remeinder);
    
    return number;
}

char* read_line()
{
    size_t size = INITIAL_BUFFER_SIZE;
    char* line = calloc(size, sizeof(char));
    if(!line)
    {
        perror("Error allocating memory");
        return NULL;
    }
    
    size_t index = 0;
    char current_char = getchar();
    if(current_char != '\n' && current_char != EOF)
    {
        while(current_char != '\n' && current_char != EOF)
        {
            if(index >= size)
            {
                size_t new_size = size * 2;
                char* resized_line = realloc(line, new_size);
                if(!resized_line)
                {      
                    perror("Error allocating memory");
                    return NULL;
                }

                line = resized_line;
                size = new_size;
            }

            line[index] = current_char;
            index++;
            current_char = getchar();
        }

        line[index] = '\0';

        char* final_line = realloc(line, index + 1);
        if(!final_line)
        {
            perror("Error allocating memory");
            return NULL;
        }

        return final_line;
    }
    
    return NULL;
}

int main(int argc, char** argv)
{
    char* line =  read_line();
    
    double sum = 0;
    char* token = strtok(line, " \t");
    while(token)
    {
        size_t length = strlen(token);
        
        char firstLetter = token[0];
        char lastLetter = token[length - 1];
        double number = get_number(token, length);
        
        if(firstLetter == toupper(firstLetter))
        {
            number /= (int)(firstLetter - 'A') + 1;      
        }
        else 
        {
            number *= (int)(firstLetter - 'a') + 1;
        }
        
        if(lastLetter == toupper(lastLetter))
        {
                 number -= (int)(lastLetter - 'A') + 1;
        }
        else 
        {
            number += (int)(lastLetter - 'a') + 1;
        }
        
        sum += number;
        token = strtok(NULL, " \t");
    }
    
    printf("%.2lf", sum);
    
    return (EXIT_SUCCESS);
}