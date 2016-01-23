
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define BUFFER_SIZE 256

long power(int, int);

long binary_to_decimal(char*);

int main(int argc, char** argv)
{
    /* char binaryString[BUFFER_SIZE];
    fgets(binaryString, BUFFER_SIZE,stdin);
   
    long decimalNumber = binary_to_decimal(binaryString);

    printf("%ld",decimalNumber); */
    
    int decimal;
    scanf("%d",&decimal);
        
    int bit,index = 0;
    char buffer[BUFFER_SIZE];
    while (decimal > 0) 
    {
        bit =  decimal % 2;
        buffer[index] = bit == 1 ? '1' : '0';
        decimal /= 2;
        index++;
    }
    
    buffer[index] = '\0';
    
    size_t size = strlen(buffer);
    char binary[size];
    int i,j;
    for (i = size - 1, j = 0; i >= 0; i--,j++) {
        binary[j] = buffer[i];
    }

    binary[j] = '\0';   
    
    printf("%s", binary);
    
    return (EXIT_SUCCESS);
}

long power(int x, int n) 
{   
    long result = 1;
    int i;
    for (i = 0; i < n; i++)
    {
        result *= x;
    }

    return result;
}

long binary_to_decimal(char* binaryNumber)
{
    size_t size = strlen(binaryNumber);
    
    long decimalNumber = 0;
    int i, index;
    for (i = size - 2, index = 0; i >= 0; i--, index++)
    {
        int currentBinaryNumber = binaryNumber[i] - '0';
        decimalNumber += currentBinaryNumber * power(2, index);
    }
    
    return decimalNumber;
}