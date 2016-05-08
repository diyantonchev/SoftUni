#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

struct Circle {
  double centerX;
  double centerY; 
  double radius;
};

int main(int argc, char** argv)
{
    struct Circle circle;
    circle.centerX = 0.0;
    circle.centerY = 0.0;
    circle.radius = 2.0;
    
    double pointX, pointY;
    scanf("%lf %lf",&pointX, &pointY);
    
    bool isInside = sqrt((circle.centerX - pointX) * (circle.centerX - pointX) +
                    (circle.centerY - pointY) * (circle.centerY - pointY)) 
                    <= sqrt(circle.radius * circle.radius);
    
    printf("%s", isInside ? "Yes" : "No");    
        
    return (EXIT_SUCCESS);
}