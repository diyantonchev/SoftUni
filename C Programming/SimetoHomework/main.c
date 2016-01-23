
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

void print_Matrix(int N, int array[N][N]);

void print_array(int array[], int size);

int get_min(int array[], int size);

void bubble_sort (int array[], int size);

int main(int argc, char** argv) 
{

    printf("Да се състави програма за обработка на масива А[N,N], където данните са цели числа в интервала [-500:1000].\n\n");
    printf("Валентин Панкин\n\n");
    
    const int K = -500;
    const int L = 1000;

    printf("Enter array size N: ");
    int N;
    scanf("%d", &N);

    int A[N][N];
    int row, col;
    for (row = 0; row < N; row++) 
    {
        for (col = 0; col < N; col++) 
        {
            printf("Enter value for array A[%d][%d]:\n", row, col);
            scanf("%d", &A[row][col]);
        }
    }

    printf("\nArray A:\n");
    print_Matrix(N, A);
        
    printf("\nДа се образува едномерен масив C[N], елементите на който са минималните елементи от всеки ред на масива А: \n");
    int C[N];
    for (row = 0; row < N; row++) 
    {
        C[row] = get_min(A[row],N);
    }
    
    print_array(C,N);
    
    printf("\nПолученият масив да се сортира по големина: \n");
    bubble_sort(C,N);
    print_array(C,N);
    
    return (0);
}

void bubble_sort (int array[], int size)
{
    int has_swapped = 1;
    while (has_swapped)
    {
        has_swapped = 0;

        int i;
        for (i = 0; i < size - 1; i++)
        {
            if(array[i] > array[i + 1])
            {
                int old_value = array[i];
                array[i] = array[i + 1];
                array[i + 1] = old_value;
                has_swapped = 1;
            }
        }
    }  
}

int get_min(int array[], int size)
{
    int min_element = INT_MAX;
    int i; 
    for (i = 0; i < size; i++)
    {      
        int current_element = array[i];
        if (min_element > current_element)
        {
            min_element = current_element;
        }
    }

    return min_element;
}

void print_array(int array[], int size)
{
    int i;
    printf("[ ");
    for (i = 0; i < size; i++) 
    {
        printf("%d ",array[i]);
    }
    
    printf("]\n");
}

void print_Matrix(int N, int array[N][N]) {
    int row, col;
    for (row = 0; row < N; row++) {
        for (col = 0; col < N; col++) {
            printf("%d ", array[row][col]);
        }

        printf("\n");
    }
}