package JavaFundamentals_4October_2015;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04DragonArmy {

    final static double DefaultHealth = 250;
    final static double DefaultDamage = 45;
    final static double DefaultArmor = 10;

    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        LinkedHashMap<String, TreeMap<String, ArrayList<Double>>> dragonStats = new LinkedHashMap();
        int numberOfInputLines = Integer.parseInt(inputScanner.nextLine());
        for (int i = 0; i < numberOfInputLines; i++) {

            String input = inputScanner.nextLine();
            String[] dragonsInfo = input.split("\\s+");

            String dragonType = dragonsInfo[0];
            String dragonName = dragonsInfo[1];
            String damageInfo = dragonsInfo[2];
            String healthInfo = dragonsInfo[3];
            String armorInfo = dragonsInfo[4];

            double damage = tryParseInfo(damageInfo, DefaultDamage);
            double health = tryParseInfo(healthInfo, DefaultHealth);
            double armor = tryParseInfo(armorInfo, DefaultArmor);

            ArrayList<Double> currentStats = new ArrayList<Double>() {{
                add(damage);
                add(health);
                add(armor);
            }};

            if (!dragonStats.containsKey(dragonType)) {
                dragonStats.put(dragonType, new TreeMap<>());
            }

            dragonStats.get(dragonType).put(dragonName, currentStats);
        }

        StringBuilder output = new StringBuilder();
        for (String dragonType : dragonStats.keySet()) {

            double overallDamage = 0;
            double overallHealth = 0;
            double overallArmor = 0;

            StringBuilder currentDragonTypeStats = new StringBuilder();
            for (String dragonName : dragonStats.get(dragonType).keySet()) {

                double currentDragonDamage = dragonStats.get(dragonType).get(dragonName).get(0);
                double currentDragonHealth = dragonStats.get(dragonType).get(dragonName).get(1);
                double currentDragonArmor = dragonStats.get(dragonType).get(dragonName).get(2);

                overallDamage += currentDragonDamage;
                overallHealth += currentDragonHealth;
                overallArmor += currentDragonArmor;

                currentDragonTypeStats.append(
                        String.format(
                                "-%s -> damage: %.0f, health: %.0f, armor: %.0f%n",
                                dragonName, currentDragonDamage, currentDragonHealth, currentDragonArmor));
            }

            int count = dragonStats.get(dragonType).size();
            overallDamage = calculateOverallStat(overallDamage, count);
            overallHealth = calculateOverallStat(overallHealth, count);
            overallArmor = calculateOverallStat(overallArmor, count);

            output.append(String.format("%s::(%.2f/%.2f/%.2f)%n", dragonType, overallDamage, overallHealth, overallArmor));
            output.append(currentDragonTypeStats);
        }

        System.out.println(output.toString().trim());
    }

    private static double calculateOverallStat(double overallStat, int count) {
        return overallStat / count;
    }

    private static double tryParseInfo(String statInfo, double defaultValue) {
        if (!statInfo.equals("null")) {
            return Double.parseDouble(statInfo);
        }
        return defaultValue;
    }
}
