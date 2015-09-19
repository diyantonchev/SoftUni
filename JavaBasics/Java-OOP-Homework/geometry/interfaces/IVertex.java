package geometry.interfaces;

public interface IVertex {
    double getX();

    double getY();

    double calculateDistance(IVertex otherVertex);
}
