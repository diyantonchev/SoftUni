
#include <stdio.h>
#include <stdlib.h>
#include "arr.h"
#include <limits.h>
#include <float.h>

double arr_min(double array[], int size)
{
    double min_element = DBL_MAX;
    int i; 
    for (i = 0; i < size; i++)
    {      
        double current_element = array[i];
        if (min_element > current_element)
        {
            min_element = current_element;
        }
    }

    return min_element;
}

double arr_max(double array[], int size)
{
    double max_element = DBL_MIN;
    int i; 
    for (i = 0; i < size; i++)
    {      
        double current_element = array[i];
        if (max_element < current_element)
        {
            max_element = current_element;
        }
    }

    return max_element;
}

void arr_clear(double array[], int size)
{
    int i;
    for (i = 0; i < size; i++)
    {        
        array[i] = 0;    
    }

}

double arr_sum(double array[], int size)
{
    double sum = 0;
    
    int i;
    for (i = 0; i < size; i++)
    {        
        sum += array[i];    
    }
    
    return sum;
}

int arr_contains(double element, double array[], int size)
{
    int is_contain = 0;
    
    int i;
    for (i = 0; i < size; i++)
    {        
        double current_element = array[i];      
        if (current_element == element)
        {
            is_contain = 1;
        }

    }
    
    return is_contain;
}

void print_arr(double array[], int size)
{
    int i;
    printf("[ ");
    for (i = 0; i < size; i++)
    {
        printf("%.2f ",array[i]);
    }
    
    printf("]\n");
}

double* arr_merge(double array_one[], int size_one, double array_two[], int size_two)
{
    size_t size = size_one + size_two;
    double *merged_arr = malloc(size);
    
    if(merged_arr != NULL)
    {
        int i, j = 0;
        for (i = 0; i < size; i++)
        {
            if(i < size_one)
            {
                merged_arr[i] = array_one[i];
            }
            else
            {
                merged_arr[i] = array_two[j];
                j++;
            }
        }
    }  
   
    return merged_arr;
}