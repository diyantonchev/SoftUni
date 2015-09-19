package JavaBasics_08February2015;

import java.util.HashMap;
import java.util.Scanner;

public class _01GandalfsStash {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        HashMap<String, Integer> typesOfFood = new HashMap<String, Integer>() {{
            put("cram", 2);
            put("lembas", 3);
            put("apple", 1);
            put("melon", 1);
            put("honeycake", 5);
            put("mushrooms", -10);
        }};

        int gandalfsMood = Integer.parseInt(inputScanner.nextLine());
        String[] inputFoods = inputScanner.nextLine().toLowerCase().split("[^a-zA-Z]+");

        for (String food : inputFoods) {
            if (typesOfFood.containsKey(food)) {
                gandalfsMood += typesOfFood.get(food);
            } else {
                gandalfsMood -= 1;
            }
        }

        System.out.println(gandalfsMood);
        if (gandalfsMood < -5) {
            System.out.println("Angry");
        } else if (gandalfsMood <= 0 && gandalfsMood >= -5) {
            System.out.println("Sad");
        } else if (gandalfsMood > 0 && gandalfsMood <= 15) {
            System.out.println("Happy");
        } else if (gandalfsMood > 15) {
            System.out.println("Special JavaScript mood ");
        }
    }
}
