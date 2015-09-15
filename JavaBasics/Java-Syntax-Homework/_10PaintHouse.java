package _10PaintAHouseAsSVG;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.GeneralPath;
import java.awt.geom.Rectangle2D;
import java.util.ArrayList;

public class PaintHouse extends JPanel {

    private ArrayList<String> inputCoordinates;

    public PaintHouse(ArrayList<String> inputCoordinates) {
        this.inputCoordinates = inputCoordinates;
    }

    public PaintHouse() {
        this.inputCoordinates = new ArrayList<>();
    }

    public void paintComponent(Graphics graphics) {
        super.paintComponent(graphics);
        this.setBackground(Color.white);

        Graphics2D graphics2D = (Graphics2D) graphics;
        int scale = 35;

        this.drawLeftHouseBody(graphics2D, scale);
        this.drawRightHouseBody(graphics2D, scale);

        GeneralPath roof = new GeneralPath();
        this.drawHouseRoof(roof, graphics2D, scale);

    }

    private void drawLeftHouseBody(Graphics2D graphics, int scale) {
        graphics.setStroke(new BasicStroke(3));

        Shape rectangleLeft = new Rectangle2D.Double(
                12.5 * scale, 8.5 * scale, 5 * scale, 5 * scale);

        graphics.setPaint(Color.LIGHT_GRAY);
        graphics.fill(rectangleLeft);
        graphics.setPaint(Color.black);
        graphics.draw(rectangleLeft);
    }

    private void drawRightHouseBody(Graphics2D graphics, int scale) {
        graphics.setStroke(new BasicStroke(3));

        Shape rectangleRight = new Rectangle2D.Double(
                20 * scale, 8.5 * scale, 2.5 * scale, 5 * scale);

        graphics.setPaint(Color.LIGHT_GRAY);
        graphics.fill(rectangleRight);
        graphics.setPaint(Color.black);
        graphics.draw(rectangleRight);
    }

    private void drawHouseRoof(GeneralPath roof, Graphics2D graphics, int scale) {
        roof.moveTo(12.5 * scale, 8.5 * scale);
        roof.lineTo(17.5 * scale, 3.5 * scale);
        roof.lineTo(22.5 * scale, 8.5 * scale);
        roof.closePath();

        graphics.setPaint(Color.LIGHT_GRAY);
        graphics.fill(roof);
        graphics.setPaint(Color.black);
        graphics.draw(roof);
    }
}

