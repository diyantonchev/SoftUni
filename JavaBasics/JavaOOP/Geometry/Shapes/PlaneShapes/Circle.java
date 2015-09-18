package Geometry.Shapes.PlaneShapes;

import Geometry.Vertices.Vertex;
import com.sun.javaws.exceptions.InvalidArgumentException;

import java.util.ArrayList;

public class Circle extends PlaneShape {

    private Vertex center;
    private double radius;
    private ArrayList<Vertex> vertices;

    public Circle(Vertex center, double radius) throws InvalidArgumentException {
        super(center);
        this.center = super.getVertex();
        this.setRadius(radius);
        this.vertices = super.getVertices();
    }

    public double getRadius() {
        return this.radius;
    }

    public void setRadius(double radius) throws InvalidArgumentException {

        if (radius < 0) {
            String[] message = new String[]{"Radius cannot be negative."};
            throw new InvalidArgumentException(message);
        }

        this.radius = radius;
    }

    @Override
    public double getArea() {
        return Math.PI * radius * radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * radius;
    }

    @Override
    public String toString() {
        StringBuilder circle = new StringBuilder();
        circle.append(String.format(
                "Circle:%nCenter = %s;%nRadius = %.2f;%nCircumference = %.2f;%nArea = %.2f;%n",
                this.center, this.radius, this.getPerimeter(), this.getArea()));

        return circle.toString();
    }
}
