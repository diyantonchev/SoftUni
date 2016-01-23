
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <stdbool.h>

int main(int argc, char** argv)
{
    int n;
    scanf("%d", &n);

    bool isPrime = true;
    if (n < 2)
    {
        isPrime = false;
    }
    else 
    {
        int i;
        for (i = 2; i <= sqrt(n); i++) 
        {
            int reminder = n % i;
            if (reminder == 0) {
                isPrime = false;
                break;
            }
        }
    }

    printf("%s", isPrime ? "true" : "false");

    return (EXIT_SUCCESS);
}

