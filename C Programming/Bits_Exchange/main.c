
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv)
{   
    uint n;
    scanf("%u", &n);
    
    uint left_bytes = (7 << 24) & n;
    uint right_bytes = (7 << 3) & n;
    
    n &= ~(7 << 24);
    n &= ~(7 << 3);
    
    uint positions = 24 - 3; 
    n |= (left_bytes >> positions);
    n |= (right_bytes << positions);   
    
    printf("%u", n);
    
    return (EXIT_SUCCESS);
}

