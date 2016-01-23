#include "strfunc.h"

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

char* string_join(char** strings, size_t size, char* delimeter)
{
    size_t result_string_size = INITIAL_BUFFER_SIZE;
    char* result_string = calloc(result_string_size, sizeof(char));
    if(!result_string)
    {
        return NULL;
    }
    
    size_t delimeter_length = strlen(delimeter);
    int i, current_count = 0;
    for (i = 0; i < size; i++)
    {       
        char* current_string = strings[i];
        size_t current_string_length = strlen(current_string);
        size_t total_length = current_string_length + delimeter_length;
        if(current_count + total_length >= result_string_size)
        {
            size_t new_buffer_size = result_string_size + (total_length * 2);
            char* resized_string = realloc(result_string, new_buffer_size);
            if(!resized_string)
            {
                return NULL;
            }
           
            result_string = resized_string;
            result_string_size = new_buffer_size;
        }
        
        strncat(result_string, current_string, current_string_length);
        strncat(result_string, delimeter, delimeter_length);
        current_count += total_length;
    }
    
    result_string[current_count - 1] = '\0';
    char* final_string  = realloc(result_string, current_count + 1);
    if (!result_string)
    {
        return NULL;
    }
    
    return final_string;
}

char* substr(char* string, size_t position, size_t length)
{
    size_t string_length = strlength(string);
    if(position >= string_length)
    {
        return NULL;
    }
    
    char* substring = calloc(string_length + 1, sizeof(char));
    if(!substring)
    {
        return NULL;
    }
    
    int i, j;
    for (i = position, j = 0; j < length; i++, j++) 
    {
        if(i >= string_length)
        {
            break;
        }
        
        substring[j] = string[i]; 
    }
    
    substring[j] = '\0';    
    return substring;
}

int strsearch(char* src, char* substr)
{
    char* substring = strstr(src, substr);
    if(substring)
    {
        return 1;
    }
    
    return 0;
}

size_t strlength(char* string)
{
    size_t counter = 0;
    while(*string != '\0')
    {
        counter++;
        string++;
    }
    
    return counter;
}

int word_count(char* text, char delimeter)
{
    int count = 1;
    char* match = strchr(text, delimeter);
    while(match)
    {
       count++;
       match = strchr(match + 1, delimeter);
    }
    
    return count;
}

int contains(char** list, size_t count, char* string)
{
    
    int i;
    for (i = 0; i < count; i++) 
    {
        if(strcmp(list[i], string) == 0)
        {
            return 1;
        }
    }
    
    return 0;
}