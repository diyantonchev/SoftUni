
#include <stdio.h>
#include <stdlib.h>
#include "arr.h"
#define LENGTH(array) sizeof(array) / sizeof(array[0])

int main(int argc, char** argv) 
{      
    double array[] = { 6.6, 3.3, 8.8, 7.7, 10, 6.3 };
    int size = LENGTH(array);
    
    double min = arr_min(array, size);
    double max = arr_max(array,size);
    double sum = arr_sum(array, size);
    double number = 8.8;
    int is_contain = arr_contains(number, array, size);
    
    printf("Array: ");
    print_arr(array, size);
    printf("Min element: %.2f\nMax element: %.2f\nSum: %.2f\nContains \"%.2f\": %s\n",
            min, max, sum, number, is_contain == 1 ? "True" : "False");
    
    arr_clear(array, size);
    printf("Array cleared: ");
    print_arr(array, size);
    
    double firstArr[] = { 1, 2, 3, 4, 5 };
    int first_size = LENGTH(firstArr);
    double secondArr[] = { 6, 7, 8, 9 };
    int second_size = LENGTH(secondArr);

    printf("First Array: ");
    print_arr(firstArr, first_size);
    printf("Second Array: ");
    print_arr(secondArr, second_size);
    
    double *mergedArr = arr_merge(firstArr, first_size, secondArr, second_size);
    int merged_size = first_size + second_size;
    printf("Merged: ");
    print_arr(mergedArr, merged_size);
    
    return (EXIT_SUCCESS);
}