#include <stdio.h>
#include <stdlib.h> 
#define INITIAL_BUFFER_SIZE 50

int main(int argc, char** argv) 
{
    int bytes;
    scanf("%d", &bytes);
    scanf("\n");
    
    int result[bytes];
    
    int step;
    scanf("%d", &step);
    scanf("\n");
    
    int i, index = 0, bit_index = 0;
    for (i = 1; i <= bytes; i++)
    {
        int number;
        scanf("%d", &number);
        scanf("\n");       
        
        int bit;
        for (bit = 7; bit >= 0; bit--) 
        {
            if((bit_index % step == 1) || (step == 1 && bit_index > 0))
            {
               number |= (1 << bit);
            }    
            
            bit_index++;
        }       
     
        result[index] = number;
        index++;
    }
    
    for (index = 0; index < bytes; index++) 
    {
        printf("%d\n", result[index]);
    }
    
    return (EXIT_SUCCESS);
}