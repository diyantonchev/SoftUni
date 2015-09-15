import java.io.*;

public class _08SumNumbersFromATextFile {
    public static void main(String[] args) throws IOException {

        try {
            FileReader reader = new FileReader("Input.txt");
            BufferedReader bufferedReader = new BufferedReader(reader);

            String currentLine = bufferedReader.readLine();
            double sum = 0;

            while (currentLine != null) {

                double currentNumber = Double.parseDouble(currentLine);
                sum += currentNumber;

                currentLine = bufferedReader.readLine();
            }

            reader.close();
            bufferedReader.close();

            System.out.println(sum);
        } catch (NumberFormatException ex) {
            System.out.println("Error");
        } catch (IOException ex) {
            System.out.println("Error");
        }
    }
}