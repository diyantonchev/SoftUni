#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <limits.h>
#include <float.h>

long long factorial(int);

long power(int, int);

int main(int argc, char** argv) {
    
    int n, x;
    scanf("%d %d", &n, &x);
    
    double sum = 1;
    int i;
    for (i = 1; i <= n; i++) 
    {
        sum += factorial(i) / (double)power(x, i);
    } 
    
    printf("%.5lf",sum);
    
    return (EXIT_SUCCESS);
}

long long factorial(int n) {
   
    if (n == 1)
    {
        return 1;
    }
    
    long long result = n * factorial(n - 1);
    return result;
}

long power(int x, int n) {
   
    int result = 1;
    int i;
    for (i = 0; i < n; i++) {
        result *= x;
    }

    return result;
}