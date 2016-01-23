
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>

struct Circle 
{
    double centerX;
    double centerY;
    double radius;
};

struct Rectangle 
{
    double top;
    double left;
    double width;
    double height;
};

int main(int argc, char** argv) {

    struct Circle circle;
    circle.centerX = 1;
    circle.centerY = 1;
    circle.radius = 1.5;
    
    struct Rectangle rectangle;
    rectangle.top = 1;
    rectangle.left = -1;
    rectangle.width = 6;
    rectangle.height = 2;

    double pointX, pointY;
    scanf("%lf %lf",&pointX, &pointY);
    
    bool isInsideCircle = sqrt((circle.centerX - pointX) * (circle.centerX - pointX) +
                    (circle.centerY - pointY) * (circle.centerY - pointY)) 
                    <= circle.radius;

    bool isOutsideRectangle = pointY > rectangle.top ||
                              pointY < rectangle.top - rectangle.height ||
                              pointX > rectangle.left + rectangle.width ||
                              pointX < rectangle.left;
    
    if(isInsideCircle && isOutsideRectangle){
        printf("yes");
    } else {
        printf("no");
    }
    
    return (EXIT_SUCCESS);
}

