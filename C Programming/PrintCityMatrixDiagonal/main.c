
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define INITIAL_BUFFER_SIZE 50

char* read_line();

int main(int argc, char** argv) 
{
    int count;
    scanf("%d", &count);
 
    const char* delimeter = " \t";
    char* cities[INITIAL_BUFFER_SIZE]; 
    int index;
    for(index = 0; index < count; index++)
    {
        scanf("\n");
        char* row = read_line();
        int counter = 0;
        char* city = strtok(row, delimeter);
        while(city)
        {
            if(counter == index)
            {
                size_t city_len = strlen(city);
                cities[index] = city;
                cities[index][city_len] = '\0'; 
                break;
            }
            
            counter++;
            city = strtok(NULL, delimeter);
        }
    }   
    
    
    for (index = 0; index < count; index++) 
    {        
        printf("%s\n", cities[index]);
    }
    
    return (EXIT_SUCCESS);
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