
#include <stdio.h>
#include <stdlib.h>
#include "geometry.h"

int main(int argc, char** argv) {

    double a = 1;
    double b = 2;
    double c = 3;
    int isValidTriangle = is_Valid_Triangle(a, b, c);
    printf("%s\n", isValidTriangle ? "Yes" : "No");

    double x1 = 0;
    double y1 = 0;
    double r1 = 2;

    double x2 = 3;
    double y2 = 3;
    double r2 = 1;
    int isIntersect = is_Circles_Intesect(x1, y1, r1, x2, y2, r2);
    printf("%s\n", isIntersect ? "Yes" : "No");

    return (EXIT_SUCCESS);
}

