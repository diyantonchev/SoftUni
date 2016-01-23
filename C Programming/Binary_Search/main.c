
#include <stdio.h>
#include <stdlib.h>

void bubble_sort(double*, int);

int binary_search(double, double*, int);

int main(int argc, char** argv) 
{
    int n;
    scanf("%d", &n);
    

    double array[n];
    int i;
    for (i = 0; i < n; i++) 
    {
        scanf("%lf ", &array[i]);
    }
    
    double searched_element;
    scanf("%lf", &searched_element);
    
    bubble_sort(array, n); 
    
    //int index = binary_search(searched_element, array, n);
    int min_index = 0;
    int max_index = n - 1;
    int index = binary_search_recursion(searched_element,array,min_index, max_index);
    printf("\n%d", index);
    
    return (EXIT_SUCCESS);
}

int binary_search_recursion(double element, double array[], int min_index, int max_index)
{    
    if(min_index > max_index)
    {       
        return -1;
    }
    
    int mid_index = (min_index + max_index) / 2;
    double mid_element = array[mid_index];
    
    if(element < mid_element)
    {
        max_index = mid_index - 1;    
    }
    else if (mid_element < element)
    {
        min_index = mid_index + 1;
    }
    else 
    {
        return mid_index;
    }
    
    binary_search_recursion(element, array, min_index, max_index);
}

int binary_search(double element, double array[], int size)
{
    int min_index = 0;
    int max_index = size - 1;
    
    while(max_index > min_index)
    {
        int mid_index = (max_index + min_index) / 2;
        double mid_element = array[mid_index];
        
        if (mid_element < element)
        {
            min_index = mid_index + 1;
        }
        else if (element < mid_element)
        {
            max_index = mid_index - 1;
        }
        else
        {
            return mid_index;
        }
    }

    return -1;
}

void bubble_sort(double *arr, int size)
{
    int has_swapped = 1;
    while (has_swapped)
    {
        has_swapped = 0;
        int i;
        for (i = 0; i < size - 1; i++)
        {
            if(arr[i] > arr[i + 1])
            {
                double temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                has_swapped = 1;
            }
        }
    }
}

