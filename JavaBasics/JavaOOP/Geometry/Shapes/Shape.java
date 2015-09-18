package Geometry.Shapes;

import Geometry.Interfaces.IVertex;

import java.util.ArrayList;

public abstract class Shape {
    private ArrayList<IVertex> vertices;

    protected Shape(){
        this.vertices = new ArrayList<>();
    }
}
