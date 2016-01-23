
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void reverse_string(char source[], char destination[], int n, int m);

void print_str(char* str, int size);

int main(int argc, char** argv) 
{
    char str_to_reverse[] = "Recursion";
    int size = strlen(str_to_reverse);
    char reversed[size + 1];
    int n = 0, m = size - 1;
    reverse_string(str_to_reverse, reversed, n, m);
    printf("%s",reversed);
    
    return (EXIT_SUCCESS);
}

void reverse_string(char source[], char destination[], int n, int m)
{
    if (m < 0) 
    {
        destination[n] = '\0';
        return;
    }
    
    
    char current_char = source[n];
    destination[m] = current_char;
    n++;
    m--;
    reverse_string(source, destination, n, m);
}

void print_str(char* str, int size)
{
    int i;
    for (i = 0; i < size; i++)
    {
        printf("%c", str[i]);
    }
}