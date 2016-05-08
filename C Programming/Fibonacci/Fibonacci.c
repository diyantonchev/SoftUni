#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) 
{
    //fibonacci
    int n;
    scanf("%d",&n);
    
    int previousNumber = 0;
    int i;
    for (i = 0; i < n; i++) 
    {
       int currentNumber = fibonacci(previousNumber);
       previousNumber = currentNumber;
       printf("%d ", currentNumber);
    }
}

int fibonacci(int n)
{
    if(n == 0 || n == 1)
    {
        return n;
    }
    
    return (n - 1) + (n - 2);
}

