
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) 
{
    unsigned int n;
    int p, q, k, smaller, bigger;
    scanf("%u %d %d %d", &n, &p, &q, &k);
    smaller = p < q ? p : q;
    bigger = p > q ? p : q;
        
    int isOutOfRange = 0 > p || 0 > q || 32 < p + k || 32 < q + k;
    if(isOutOfRange)
    {
        printf("out of range\n");
        exit(1);
    }
         
    int isOverlapp = smaller == bigger || smaller + k >= bigger;
    if(isOverlapp)
    {
        printf("overlapping");
        exit(1);
    }
        
    unsigned int i;
    for (i = 0; i < k; i++) 
    {         
        //вземане на стойността
        unsigned int leftBit = n & (1 << smaller + i); 
        unsigned int rightBit = n & (1 << bigger + i);
        
        //зануляване 
        n &= ~(1 << smaller + i); 
        n &= ~(1 << bigger + i);
        
        //размяна
        unsigned int positions = (bigger + i) - (smaller + i); 
        n |= leftBit << positions;  
        n |= rightBit >> positions;
    }
    
    printf("%u", n);
    
    return (EXIT_SUCCESS);
}

