package JavaBasics_21Sept_2014Evening;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _3ValidUsernames {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] words = inputScanner.nextLine().split("[\\s()\\\\/]+");
        Pattern usernamePattern = Pattern.compile("\\b[a-zA-Z][\\w_]{2,25}\\b");
        ArrayList<String> validUsernames = new ArrayList();
        for (String word : words) {
            Matcher usernameMatcher = usernamePattern.matcher(word);
            if (usernameMatcher.find()) {
                validUsernames.add(usernameMatcher.group());
            }
        }

        String[] longestUsernames = new String[2];
        int maxLength = 0;
        for (int i = 0; i < validUsernames.size() - 1; i++) {
            String firstUsername = validUsernames.get(i);
            String secondUsername = validUsernames.get(i + 1);
            int currentLength = firstUsername.length() + secondUsername.length();
            if (currentLength > maxLength) {
                maxLength = currentLength;
                longestUsernames[0] = validUsernames.get(i);
                longestUsernames[1] = validUsernames.get(i + 1);
            }
        }

        for (String longestUsername : longestUsernames) {
            System.out.println(longestUsername);
        }
    }
}
