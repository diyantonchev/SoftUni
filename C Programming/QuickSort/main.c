#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define INITIAL_BUFFER_SIZE 50

char* read_line();

void quickSort(char** elements, int left, int right);

int main(int argc, char** argv) 
{
    size_t count;
    scanf("%lu", &count);
    scanf("\n");
    
    char** cities = calloc(count, sizeof(char*));
    int i;
    for (i = 0; i < count; i++) 
    {
        cities[i] = read_line();
    }
    
    quickSort(cities, 0, count - 1);
    
    for (i = 0; i < count; i++) 
    {
        printf("\n%s", cities[i]);
        free(cities[i]);
    }

    free(cities);
    
    return (EXIT_SUCCESS);
}

void quickSort(char** elements, int left, int right)
{    
    int i = left, j = right;
    char* pivot = elements[(left + right) / 2];
    while(i <= j)
    {
        while(strcmp(elements[i], pivot) < 0)
        {
            i++;
        }
        
        while(strcmp(elements[j], pivot) > 0)
        {
            j--;
        }
        
        if(i<=j)
        {
            char* temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
            
            i++;
            j--;
        }
    }
    
    if(left < j)
    {
        quickSort(elements, left, j);
    }
    
    if(i < right)
    {
        quickSort(elements, i, right);
    }
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