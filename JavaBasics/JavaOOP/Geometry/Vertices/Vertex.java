package Geometry.Vertices;

import Geometry.Interfaces.IVertex;

public class Vertex implements IVertex {

    private double x;
    private double y;

    public Vertex(double x, double y) {
        this.setX(x);
        this.setY(y);
    }

    public double getX() {
        return this.x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }

    public double calculateDistance(IVertex otherVertex) {
        double otherX = otherVertex.getX();
        double otherY = otherVertex.getY();

        double distance = Math.sqrt((this.x - otherX) * (this.x - otherX) + (this.y - otherY) * (this.y - otherY));
        return distance;
    }

    @Override
    public String toString(){
        return String.format("[x = %s, y = %s]", this.x, this.y);
    }
}
