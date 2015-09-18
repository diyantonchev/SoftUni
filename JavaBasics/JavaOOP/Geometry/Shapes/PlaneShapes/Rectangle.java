package Geometry.Shapes.PlaneShapes;

import Geometry.Vertices.Vertex;

import java.util.ArrayList;

public class Rectangle extends PlaneShape {

    private Vertex vertex;
    private double width;
    private double height;
    private ArrayList<Vertex> vertices;

    public Rectangle(Vertex vertex, double width, double height) {
        super(vertex);

        this.vertex = super.getVertex();
        this.setWidth(width);
        this.setHeight(height);
        this.vertices = super.getVertices();
    }

    public double getWidth() {
        return this.width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return this.height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getArea() {
        return this.width * this.height;
    }

    @Override
    public double getPerimeter() {
        return 2 * (this.width + this.height);
    }

    @Override
    public ArrayList<Vertex> getVertices() {
        return this.vertices;
    }

    @Override
    public String toString() {
        StringBuilder rectangle = new StringBuilder();
        rectangle.append(String.format(
                "Rectangle:%nWidth = %.2f;%nHeight = %.2f;%nPerimeter = %.2f;%nArea = %.2f;%n",
                this.width, this.height, this.getPerimeter(), this.getArea()));
        rectangle.append(String.format("Coordinates: %s%n", this.vertices.toString()));

        return rectangle.toString();
    }
}
