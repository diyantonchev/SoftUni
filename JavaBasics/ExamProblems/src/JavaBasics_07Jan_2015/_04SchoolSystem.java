package JavaBasics_07Jan_2015;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.TreeMap;

public class _04SchoolSystem {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int linesOfInformation = Integer.parseInt(inputScanner.nextLine());
        TreeMap<String, TreeMap<String, ArrayList<Integer>>> studentGrades = new TreeMap<>();
        for (int i = 0; i < linesOfInformation; i++) {
            String[] info = inputScanner.nextLine().split("\\s+");
            String studentName = info[0] + " " + info[1];
            String subject = info[2];
            int grade = Integer.parseInt(info[3]);

            if (!studentGrades.containsKey(studentName)) {
                studentGrades.put(studentName, new TreeMap<>());
            }
            if (!studentGrades.get(studentName).containsKey(subject)) {
                ArrayList<Integer> grades = new ArrayList<Integer>() {{
                    add(grade);
                }};
                studentGrades.get(studentName).put(subject, grades);
            } else {
                studentGrades.get(studentName).get(subject).add(grade);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String student : studentGrades.keySet()) {
            output.append(String.format("%s: [", student));
            StringBuilder currentStudentAverageGrades = new StringBuilder();
            for (String subject : studentGrades.get(student).keySet()) {
                double averageGrade = averageOf(studentGrades.get(student).get(subject));
                currentStudentAverageGrades.append(String.format("%s - %.2f, ", subject, averageGrade));
            }
            output.append(String.format("%s]%n", currentStudentAverageGrades.toString().substring(0, currentStudentAverageGrades.length() - 2)));

            currentStudentAverageGrades.delete(0, currentStudentAverageGrades.length());
        }

        System.out.print(output.toString().trim());
    }

    private static double averageOf(ArrayList<Integer> grades) {
        double averageGrade = 0;
        for (int i = 0; i < grades.size(); i++) {
            averageGrade += grades.get(i);
        }
        averageGrade /= grades.size();
        return averageGrade;
    }
}
