package Geometry.Shapes.SpaceShapes;

import Geometry.Vertices.Vertex3D;
import com.sun.javaws.exceptions.InvalidArgumentException;

import java.util.ArrayList;

public class Sphere extends SpaceShape {

    private double radius;
    private ArrayList<Vertex3D> vertices;

    public Sphere(Vertex3D center, double radius) throws InvalidArgumentException {
        super(center);

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
        double area = 4 * Math.PI * radius * radius;
        return area;
    }

    @Override
    public double getVolume() {
        double volume = (double) 4 / 3 * Math.PI * radius * radius * radius;
        return volume;
    }

    @Override
     public String toString(){
        StringBuilder sphere = new StringBuilder();
        sphere.append(String.format(
                "Sphere:%nCenter = %s;%nRadius = %.2f;%nVolume = %.2f;%nArea = %.2f;%n",
                super.getVertex(), this.radius, this.getVolume(), this.getArea()));

        return sphere.toString();
    }
}
