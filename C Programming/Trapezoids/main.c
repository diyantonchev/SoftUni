#include <stdio.h>
#include <stdlib.h>

double calculateArea(double a, double b, double h)
{
    return ((a + b)  / 2.0 ) * h;
}

struct Trapezoid 
{
    double a;
    double b;
    double h;
    double area;
};

int main(int argc, char** argv) {

    struct Trapezoid trapezoid;
    scanf("%lf %lf %lf", &trapezoid.a,&trapezoid.b, &trapezoid.h);
    
    trapezoid.area = calculateArea(trapezoid.a,trapezoid.b, trapezoid.h);
    
    printf("%.2f",trapezoid.area);
    
    return (EXIT_SUCCESS);
}