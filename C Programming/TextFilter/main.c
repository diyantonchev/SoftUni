
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define BUFFER_SIZE 255

int main(int argc, char** argv)
{
    char  banned_words[BUFFER_SIZE];
    fgets(banned_words,BUFFER_SIZE, stdin);
    size_t banned_words_length = strlen(banned_words);
    banned_words[banned_words_length - 1] = '\0';
    
    char text[BUFFER_SIZE];
    fgets(text, BUFFER_SIZE, stdin);
    size_t text_length = strlen(text);
    text[text_length - 1] = '\0';
    
    const char symbol = '*';
    const char *delimeter = ", ";
    char *banned_word = strtok(banned_words, delimeter);
    while(banned_word)
    {
        size_t word_length = strlen(banned_word);
        char *substring = strstr(text, banned_word);
        while(substring)
        {
            size_t index = substring - text;
            memset(&text[index], symbol, word_length);
            substring = strstr(((substring + 1)), banned_word);
        }
        
        banned_word = strtok(NULL, delimeter);
    }
    
    printf("%s", text);
    
    return (EXIT_SUCCESS);
}