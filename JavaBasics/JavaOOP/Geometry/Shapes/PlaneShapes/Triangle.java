package Geometry.Shapes.PlaneShapes;

import Geometry.Vertices.Vertex;
import com.sun.javaws.exceptions.InvalidArgumentException;

import java.util.ArrayList;

public class Triangle extends PlaneShape {

    private Vertex pointA;
    private Vertex pointB;
    private Vertex pointC;
    private double sideA;
    private double sideB;
    private double sideC;
    private ArrayList<Vertex> vertices;

    public Triangle(Vertex pointA, Vertex pointB, Vertex pointC) throws InvalidArgumentException {
        super(pointA);

        this.pointA = super.getVertex();
        this.setPointB(pointB);
        this.setPointC(pointC);

        this.sideA = pointC.calculateDistance(pointB);
        this.sideB = pointC.calculateDistance(pointA);
        this.sideC = pointA.calculateDistance(pointB);

        this.isValidTriangleCheck();

        this.vertices = super.getVertices();
        vertices.add(pointB);
        vertices.add(pointC);
    }

    private void isValidTriangleCheck() throws InvalidArgumentException {
        boolean isValidA = sideB + sideC > sideA;
        boolean isValidB = sideA + sideC > sideB;
        boolean isValidC = sideA + sideB > sideC;
        boolean isValidTriangle = isValidA && isValidB && isValidC;
        if (!isValidTriangle) {
            String[] message = new String[]{"Invalid triangle points."};
            throw new InvalidArgumentException(message);
        }
    }

    public Vertex getPointB() {
        return this.pointB;
    }

    public void setPointB(Vertex pointB) {
        this.pointB = pointB;
    }

    public Vertex getPointC() {
        return this.pointC;
    }

    public void setPointC(Vertex pointC) {
        this.pointC = pointC;
    }

    @Override
    public double getArea() {
        double halfPerimeter = this.getPerimeter() / 2;
        double area = Math.sqrt(
                halfPerimeter * (halfPerimeter - this.sideA) * (halfPerimeter - this.sideB) * (halfPerimeter - this.sideC));

        return area;
    }

    @Override
    public double getPerimeter() {
        double perimeter = this.sideA + this.sideB + sideC;
        return perimeter;
    }

    @Override
    public String toString() {
        StringBuilder triangle = new StringBuilder();
        triangle.append(String.format(
                "Triangle:%na = %.2f;%nb = %.2f;%nc = %.2f;%nPerimeter = %.2f;%nArea = %.2f;%n",
                this.sideA, this.sideB, this.sideC, this.getPerimeter(), this.getArea()));
        triangle.append(String.format("Coordinates: %s%n", this.vertices.toString()));

        return triangle.toString();
    }
}
