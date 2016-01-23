
#include <stdio.h>
#include <stdlib.h>

int* arr_merge(int array_one[], int size_one, int array_two[], int size_two);

void bubble_sort(int*, int);

void print_array(int array[], int size);

void fill_array(int arr[], int size);

int main(int argc, char** argv)
{
    int first_length;
    scanf("%d", &first_length);
    
    int second_length;
    scanf("%d", &second_length);
    
    int first_arr[first_length];
    fill_array(first_arr,first_length);
    int second_arr[second_length];
    fill_array(second_arr, second_length);
    print_array(first_arr,first_length);
    print_array(second_arr,second_length);
    
    int *merged_array = arr_merge(first_arr, first_length,second_arr, second_length);
    int merged_size = first_length + second_length;
    bubble_sort(merged_array, merged_size);
    print_array(merged_array, merged_size);   
    
    int count = get_unique_count(merged_array, merged_size);
   
    int unique_array[count];
    unique_array[0] = merged_array[0];
    int i, j = 1;
    for (i = 1; i < merged_size; i++) 
    {
        if (merged_array[i - 1] != merged_array[i])
        {
            unique_array[j] = merged_array[i];
            j++;
        }
    }
    
    print_array(unique_array, count);
    
    return (EXIT_SUCCESS);
}

void bubble_sort(int *arr, int size)
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
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                has_swapped = 1;
            }
        }
    }
}

int get_unique_count(int arr[], int size)
{
    int count;
    int i;
    for (i = 0; i < size - 1; i++) 
    {     
        int element = arr[i];
        int j;
        for (j = i + 1; j < size; j++)
        {
            if (arr[j] == element)
            {
                count++;
                i += 1;
            }
            else 
            {
                break;
            }
        }
    }
    
    int unique_count = size - count;
    return unique_count;
}

void fill_array(int arr[], int size)
{
    int i;
    for (i = 0; i < size; i++) 
    {
        scanf("%d", &arr[i]);
    }
}

int* arr_merge(int array_one[], int size_one, int array_two[], int size_two)
{
    size_t size = size_one + size_two;
    int *merged_arr = malloc(size);
    
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