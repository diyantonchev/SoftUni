
#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main() {

    int n;
    scanf("%d",&n);
    int isNegative = 0;
    int i;
    for (i = 2; i < n + 2; i++) {
        if(isNegative)
        {
            printf("%d ",i / -1);
        }
        else
        {
            printf("%d ",i);
        }
        
        isNegative = !isNegative;
    }

    
    return (EXIT_SUCCESS);
}