package Geometry.Shapes.SpaceShapes;

import Geometry.Interfaces.AreaMeasurable;
import Geometry.Interfaces.VolumeMeasurable;
import Geometry.Shapes.Shape;
import Geometry.Vertices.Vertex3D;

import java.util.ArrayList;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

    private Vertex3D vertex;
    private ArrayList<Vertex3D> vertices;

    protected SpaceShape(Vertex3D vertex) {

        this.setVertex(vertex);
        this.vertices = new ArrayList<Vertex3D>() {{
            add(vertex);
        }};
    }

    public ArrayList<Vertex3D> getVertices(){
        return this.vertices;
    }

    public Vertex3D getVertex() {
        return this.vertex;
    }

    public void setVertex(Vertex3D vertex) {
        this.vertex = vertex;
    }
}
