
#include <stdio.h>
#include <stdlib.h>

void get_vector_members(int[], int);

int main(int argc, char** argv) 
{   
    const int n = 3;
    
    int a[n];
    get_vector_members(a, n);
    int b[n];
    get_vector_members(b, n);

    int cross_product[n];
    cross_product[0] = a[1] * b[2] - a[2] * b[1];
    cross_product[1] = a[2] * b[0] - a[0] * b[2]; 
    cross_product[2] = a[0] * b[1] - a[1] * b[0];
    
    int i;
    for (i = 0; i < n; i++) 
    {
        printf("%d ", cross_product[i]);
    }
    
    return (EXIT_SUCCESS);
}

void get_vector_members(int vector[], int dimension)
{
    int i;
    for (i = 0; i < dimension; i++) 
    {
       scanf("%d", &vector[i]);
    }
}