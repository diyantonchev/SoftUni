package Geometry.Vertices;

import Geometry.Interfaces.IVertex;

public class Vertex3D extends Vertex {

    private double x;
    private double y;
    private double z;

    public Vertex3D(double x, double y, double z) {
        super(x, y);
        this.x = super.getX();
        this.y = super.getY();
        this.setZ(z);
    }

    public double getZ() {
        return this.z;
    }

    public void setZ(double z) {
        this.z = z;
    }

    @Override
    public double calculateDistance(IVertex otherVertex) {

        Vertex3D other = (Vertex3D)otherVertex;
        double otherX = other.getX();
        double otherY = other.getY();
        double otherZ = other.getZ();

        double distance = Math.sqrt((this.x - otherX) * (this.x - otherX) + (this.y - otherY) * (this.y - otherY) +
                (this.z - otherZ) * (this.z - otherZ));

        return distance;
    }

    @Override
    public String toString(){
        return String.format("[x = %s, y = %s, z = %s]", this.x, this.y, this.z);
    }
}
