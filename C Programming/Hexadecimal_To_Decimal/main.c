
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define  BUFFER_SIZE 255

int get_index_of(char, char*);

long long power(int, int);

int main(int argc, char** argv)
{
    char hexadecimal_values[] = { '0','1','2', '3', '4', '5', '6', '7', '8', '9', 'A','B','C', 'D', 'E', 'F' };
    
   char hexadecimal_string[BUFFER_SIZE];
   scanf("%s", hexadecimal_string);
   
   size_t size = strlen(hexadecimal_string);
       
   long long decimal = 0;
   int i, value, n;
    for (i = size - 1, n = 0; i >= 0; i--, n++) 
    {
        char current_digit = hexadecimal_string[i];
        value = get_index_of(current_digit, hexadecimal_values);
        decimal += value * power(16, n);
    }
    
   printf("%lld", decimal); 
           
    return (EXIT_SUCCESS);
}

int get_index_of(char ch, char* str)
{
    size_t size = strlen(str);
    int i;
    for (i = 0; i < size - 1; i++) {
        if(ch == str[i])
        {
            return i;
        }
    }
    
    return -1;
}

long long power(int x, int n) 
{   
    long long result = 1;
    int i;
    for (i = 0; i < n; i++)
    {
        result *= x;
    }

    return result;
}