import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08ExtractEmails {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String text = inputScanner.nextLine();
        String regex = "[a-z]+[\\w.-]*[a-z]+@[a-z]+\\-?[a-z]+(\\.[a-z]+\\-?[a-z]+)+";
        Pattern emailPattern = Pattern.compile(regex);
        Matcher emailMatcher = emailPattern.matcher(text);
        while (emailMatcher.find()){
            System.out.println(emailMatcher.group());
        }
    }
}
