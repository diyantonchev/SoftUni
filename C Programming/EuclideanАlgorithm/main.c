
#include <stdio.h>
#include <stdlib.h>

int get_biggest(int, int);

int get_smallest(int, int);

int main(int argc, char** argv) {

    int a, b;
    scanf("%d %d", &a, &b);
    
    int biggest = get_biggest(a, b);
    int smallest = get_smallest(a, b);    
    int greatest_common_divisor, remeinder = 1;
    while(remeinder != 0)
    {        
        remeinder = biggest % smallest;
                
        if(remeinder != 0)
        {
            biggest = smallest;
            smallest = remeinder; 
            greatest_common_divisor = remeinder;
        }
    } 
    
    printf("GCD of %d and %d = %d",a, b, greatest_common_divisor); 
    
    return (EXIT_SUCCESS);
}

int get_biggest(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    
    return b;
}

int get_smallest(int a, int b)
{
    if (a < b)
    {
        return a;
    }
    
    return b;
}