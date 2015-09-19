package geometry.shapes.SpaceShapes;

import geometry.vertices.Vertex3D;

import java.util.ArrayList;

public class SquarePyramid extends SpaceShape {

    private Vertex3D baseCenter;
    private double baseWidth;
    private double height;
    private ArrayList<Vertex3D> vertices;

    public SquarePyramid(Vertex3D baseCenter, double baseWidth, double height) {
        super(baseCenter);
        this.baseCenter = super.getVertex();
        this.setBaseWidth(baseWidth);
        this.setHeight(height);

        this.vertices = super.getVertices();
    }

    public double getBaseWidth() {
        return this.baseWidth;
    }

    public void setBaseWidth(double baseWidth) {
        this.baseWidth = baseWidth;
    }

    public double getHeight() {
        return this.height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getArea() {
        double surfaceArea = this.baseWidth * this.baseWidth + 2 * this.baseWidth
                * Math.sqrt((this.baseWidth * this.baseWidth) / 4 + this.height * this.height);

        return surfaceArea;
    }

    @Override
    public double getVolume() {
        double volume = (this.baseWidth * this.baseWidth) * this.height / 3;
        return volume;
    }

    @Override
    public String toString() {
        StringBuilder squarePyramid = new StringBuilder();
        squarePyramid.append(String.format(
                "Square Pyramid:%nBase Center = %s;%nBase Width = %.2f;%nHeight = %.2f;%nVolume = %.2f;%nArea = %.2f;%n",
                super.getVertex().toString(), this.baseWidth, this.height, this.getVolume(), this.getArea()));

        return squarePyramid.toString();
    }
}
