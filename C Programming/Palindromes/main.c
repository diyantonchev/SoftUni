
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define BUFFER_SIZE 150
#define INITIAL_SIZE 10

int is_palindrome(char*, size_t);

int array_contains(char**, size_t, char*);

char** get_unique_palindromes(char**, size_t, size_t*);

void bubble_sort(char**, size_t);

char* string_join(char**, size_t, char*);

void error(char*);

int main(int argc, char** argv) 
{
    char text[BUFFER_SIZE];
    fgets(text,BUFFER_SIZE,stdin);
    size_t text_length = strlen(text);
    text[text_length - 1] = '\0';
    
    char* palindromes[text_length];
    int index = 0;
    const char* delimeter = " ,.?!";
    char* word = strtok(text, delimeter);
    while(word)
    {
        size_t word_length = strlen(word);
        if(is_palindrome(word, word_length))
        {
            *(palindromes + index) = word;
            palindromes[index][word_length] = '\0';
            index++;
        }
        
        word = strtok(NULL, delimeter);
    }
    
    size_t count = 0;
    char** unique_palindromes = get_unique_palindromes(palindromes, index, &count);
    bubble_sort(unique_palindromes, count);
    
    char* string_of_palindromes = string_join(unique_palindromes, count, ", ");
    printf("%s", string_of_palindromes);
    
    free(unique_palindromes);
    free(string_of_palindromes);
    
    return (EXIT_SUCCESS);
}

char* string_join(char** strings, size_t size, char* delimeter)
{
    size_t result_string_size = INITIAL_SIZE;
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
    
    result_string[current_count - 2] = '\0';
    char* final_string  = realloc(result_string, current_count + 1);
    if (!result_string)
    {
        return NULL;
    }
    
    return final_string;
}

void bubble_sort(char** array, size_t size)
{
    int has_swapped = 1;
    while(has_swapped)
    {
        has_swapped = 0; 
        int i;
        for (i = 1; i < size; i++) 
        {
            char* first_string = array[i -1];
            char* second_string = array[i];
            if(strcmp(first_string, second_string) > 0)
            {
                array[i - 1] = second_string;
                array[i] = first_string;
                has_swapped = 1;
            }
        }
    }
}

char** get_unique_palindromes(char** palindromes, size_t length, size_t* count)
{
    char** unique_palindromes = calloc(length, sizeof(char*));
    if(!unique_palindromes)
    {
        error("Error allocating string array");
    }
    
    int i, index = 0;
    for (i = 0; i < length; i++) 
    {
        char* current_palindrome = palindromes[i];
        if(!array_contains(unique_palindromes, index, current_palindrome))
        {
            unique_palindromes[index] = current_palindrome;
            index++;
        }        
    }
    
    *count = index;
    return unique_palindromes;
}

int array_contains(char** array, size_t count, char* word)
{
    int i;
    for (i = 0; i < count; i++)
    {
        if(strcmp(array[i], word) == 0)
        {
            return 1;
        }
    }
    
    return 0;
}

void error(char *message)
{
   perror(message);
   exit(1);
}

int is_palindrome(char* word, size_t word_length)
{
    char reversed_word[word_length + 1]; 
    int i, j;
    for (i = word_length - 1, j = 0; i >= 0; i--, j++) 
    {
        reversed_word[j] = word[i];
    }
    
    reversed_word[j] = '\0';
    
    if (strcmp(word,reversed_word) == 0) 
    {
        return 1;
    }

    return 0;
}