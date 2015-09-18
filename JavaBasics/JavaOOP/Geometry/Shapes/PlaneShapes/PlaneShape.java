package Geometry.Shapes.PlaneShapes;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.PerimeterMeasurable;
import Geometry.Shapes.Shape;
import Geometry.Vertices.Vertex;

import java.util.ArrayList;

public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable, Comparable<PlaneShape> {
    private Vertex vertex;
    private ArrayList<Vertex> vertices;

    protected PlaneShape(Vertex vertex) {
        this.setVertex(vertex);
        this.vertices = new ArrayList<Vertex>() {{
            add(vertex);
        }};
    }

    public Vertex getVertex() {
        return this.vertex;
    }

    public void setVertex(Vertex vertex) {
        this.vertex = vertex;
    }

    public ArrayList<Vertex> getVertices() {
        return this.vertices;
    }

    @Override
    public int compareTo(PlaneShape other) {
        if (this.getPerimeter() > other.getPerimeter()) {
            return 1;
        } else if (other.getPerimeter() > this.getPerimeter()) {
            return -1;
        }

        return 0;
    }
}
