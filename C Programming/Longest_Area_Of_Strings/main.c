#include <stdio.h>
#include <stdlib.h>
#define INITIAL_BUFFER_SIZE 50

char* read_line();

char** get_longest_sequence(char**, size_t, size_t*);

int main(int argc, char** argv) 
{
    size_t count;
    scanf("%lu", &count);
    scanf("\n");
    char** elements = calloc(count, sizeof(char*));
    int i;
    for (i = 0; i < count; i++) 
    {
        elements[i] = read_line();
    }  
    
    size_t longest_count = 0;
    char** longest_sequence = get_longest_sequence(elements, count, &longest_count);
 
    printf("%lu\n", longest_count);
    for (i = 0; i < longest_count; i++) 
    {
        printf("%s\n", longest_sequence[i]);      
    }   
    
    for (i = 0; i < count; i++) 
    {
        free(elements[i]);
    } 

    free(longest_sequence);
    free(elements);
    return (EXIT_SUCCESS);
}

char** get_longest_sequence(char** elements, size_t count, size_t* longest_count)
{   
    size_t longest = 0;
    size_t current = 1;
    int i, start, end;
    for (i = 1; i < count; i++) 
    {      
        char* prev = elements[i - 1];
        char* next = elements[i];
        while(strcmp(prev, next) == 0)
        {
            current++;
            i++;
            if(i >= count)
            {
                break;
            }
            prev = elements[i - 1];
            next = elements[i];
        }
        
        if(current > longest)
        {
            longest = current;
            current = 1;
            end = i;
            start = end - longest ;
        }
    }
    
    char** longest_sequence = calloc(longest, sizeof(char*));
    int j;
    for (i = start, j = 0; i < end; i++, j++) 
    {
        longest_sequence[j] = elements[i];
    }
    
    *longest_count = longest;
    return longest_sequence;
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