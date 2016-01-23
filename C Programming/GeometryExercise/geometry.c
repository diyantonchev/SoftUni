#include "geometry.h"

int is_Circles_Intesect(double x1, double y1, double r1, double x2, double y2, double r2) {
   
    double distance = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
    
    int isIntersect = (r1 - r2) * (r1 - r2) <= distance && distance <= (r1 + r2) * (r1 + r2);

    return isIntersect;
}

int is_Valid_Triangle(double sideA, double sideB, double sideC) {
    return   sideA + sideB > sideC && sideA + sideC > sideB &&
             sideB + sideC > sideA;
}