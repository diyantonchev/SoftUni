
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define INITIAL_BUFFER_SIZE 50

char* read_line();

int main(int argc, char** argv)
{
    const char* delimeter = "<>";
    char* info = read_line();
    while(info)
    {
        size_t line_len = strlen(info);
        char parsed_info[line_len];
        int param_has_parsed = 0;
        int value_has_parsed = 0;
        char* open_tag;
        char* close_tag;
        char* token = strtok(info, delimeter);
        while(token)
        {
            if(!param_has_parsed)
            {                   
                open_tag = token;
                
                size_t param_len = strlen(token);                
                char param[param_len];
                strncpy(param, token, param_len);               
                param[0] = toupper(token[0]);
                
                strncpy(parsed_info, param, param_len);
                parsed_info[param_len] = ':';
                parsed_info[param_len + 1] = ' ';
                parsed_info[param_len + 2] = '\0';
                
                param_has_parsed = 1;
            }
            else if(!value_has_parsed)
            {
                size_t value_len = strlen(token);
                char value[value_len];
                strncpy(value, token, value_len);
                
                strncat(parsed_info, value, value_len);
                
                size_t final_len = strlen(parsed_info);
                parsed_info[final_len] = '\0';
                
                value_has_parsed = 1;
            }
            else
            {
                size_t token_len = strlen(token);
                char temp_tag[token_len + 1];
                strncat(temp_tag, token, token_len);  
                temp_tag[token_len +1] = '\0';
                strncpy(close_tag, temp_tag,token_len + 1);
            }
            
            token = strtok(NULL, delimeter);
        }
                
        if(param_has_parsed && close_tag)
        {
            size_t tag_len = strlen(open_tag);
            char temp_tag[tag_len + 2];
            temp_tag[0] = '/';
            strncat(temp_tag, open_tag, tag_len);
            temp_tag[tag_len + 1] = '\0';
            if(strcmp(temp_tag, close_tag) == 0)
            {
                printf("\n%s", parsed_info);
            }
            else
            {
                printf("\nInvalid format");
            }            
        }
        else
        {
            printf("\nInvalid format");
        }
        
        info = read_line();
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