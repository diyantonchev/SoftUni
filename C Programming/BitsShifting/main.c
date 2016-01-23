#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
    int64_t bits;
    scanf("%ld", &bits);
    scanf("\n");
    
    int count;
    scanf("%d", &count);
    
    int i;
    for (i = 0; i < count; i++) 
    {
        int64_t sieve;
        scanf("%ld", &sieve);
        scanf("\n");
        
        sieve = ~sieve;
        bits &= sieve;
    }
    
    int one_bits = 0;
    for (i = 0; i < 64; i++) 
    {
        int64_t  bitsRight = bits >> i;
        if((bitsRight & 1) == 1)
        {
            one_bits++;
        }
    }
    
    printf("%d", one_bits);
    
    return (EXIT_SUCCESS);
}

