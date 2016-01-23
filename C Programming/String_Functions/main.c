
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "strfunc.h"

int main(int argc, char** argv) 
{
    char* names = read_line();
    char* names_for_remove = read_line();
    
    char* remove_list[sizeof(char*)];
    int index = 0;
    char* name_to_remove = strtok(names_for_remove, " ");
    while(name_to_remove)
    {
        size_t len = strlength(name_to_remove);
        remove_list[index] = name_to_remove;
        remove_list[len + 1] = '\0';
        index++;
        name_to_remove = strtok(NULL, " ");
    }    
    
    char* names_list[sizeof(char*)];
    index = 0;
    char* current_name = strtok(names, " ");
    while(current_name)
    {
        if(!contains(remove_list, index, current_name))
        {
            size_t len = strlength(current_name);
            names_list[index] = current_name;
            names_list[len + 1] = '\0';
            index++;
        }
        
        current_name = strtok(NULL, " ");
    }
    
    char* result_list = string_join(names_list, index, " ");
    printf("%s", result_list);
    
    free(result_list);
    free(names);
    free(names_for_remove); 
            
    return (EXIT_SUCCESS);
}

