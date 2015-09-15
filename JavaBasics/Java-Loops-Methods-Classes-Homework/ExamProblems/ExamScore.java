package ExamProblems;

import java.util.Scanner;
import java.util.TreeMap;

public class ExamScore {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        inputScanner.nextLine();
        inputScanner.nextLine();
        inputScanner.nextLine();

        TreeMap<Integer, TreeMap<String, Double>> examResultAggregate = new TreeMap<>();
        while (inputScanner.hasNextLine()) {
            String[] currentStudentInfo = inputScanner.nextLine().split("[^a-zA-z0-9.]+");
            if (currentStudentInfo.length < 4) {
                break;
            }

            String studentName = currentStudentInfo[1] + " " + currentStudentInfo[2];
            int examScore = Integer.parseInt(currentStudentInfo[3]);
            double grade = Double.parseDouble(currentStudentInfo[4]);

            if (!examResultAggregate.containsKey(examScore)){
                examResultAggregate.put(examScore,new TreeMap<>());
            }

            examResultAggregate.get(examScore).put(studentName,grade);
        }

        StringBuilder output = new StringBuilder();
        for (Integer examScore : examResultAggregate.keySet()) {
            output.append(String.format("%d -> ",examScore));
            output.append(examResultAggregate.get(examScore).keySet() + ";");

            double totalGradeSum = 0;
            for(Double grade : examResultAggregate.get(examScore).values()){
                totalGradeSum += grade;
            }

            int countOfGrades = examResultAggregate.get(examScore).values().size();
            double averageGrade = totalGradeSum / countOfGrades;
            output.append(String.format(" avg=%.2f",averageGrade));
            output.append("\n");
        }

        System.out.println(output);
    }
}
