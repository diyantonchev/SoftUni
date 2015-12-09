package JavaFundamentals_Retake_26Oct2015;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04LegendaryFarming {
    public static void main(String[] args) {

        final String ResultMessage = "%s obtained!";

        Scanner inputScanner = new Scanner(System.in);

        HashMap<String, String> materialItemPairs = new HashMap<String, String>() {{
            put("motes", "Dragonwrath");
            put("fragments", "Valanyr");
            put("shards", "Shadowmourne");
        }};

        TreeMap<String, Double> keyMaterials = new TreeMap<String, Double>() {{
            put("motes", 0.0);
            put("fragments", 0.0);
            put("shards", 0.0);
        }};

        TreeMap<String, Double> junks = new TreeMap<>();

        String result = new String();
        while (inputScanner.hasNextLine()) {
            String[] quantityMaterialPairs = inputScanner.nextLine().split("\\s+");
            for (int i = 0; i < quantityMaterialPairs.length - 1; i += 2) {

                if (!result.isEmpty()) {
                    break;
                }

                double quantity = Integer.parseInt(quantityMaterialPairs[i]);
                String material = quantityMaterialPairs[i + 1].toLowerCase();

                if (keyMaterials.containsKey(material)) {
                    double oldQuantity = keyMaterials.get(material);
                    double newQuantity = oldQuantity + quantity;
                    keyMaterials.put(material, newQuantity);

                    if (newQuantity >= 250) {
                        keyMaterials.put(material, newQuantity - 250);
                        result = String.format(ResultMessage, materialItemPairs.get(material));
                    }

                } else {
                    if (!junks.containsKey(material)) {
                        junks.put(material, 0.0);
                    }

                    double oldQuantity = junks.get(material);
                    junks.put(material, oldQuantity + quantity);
                }
            }

            if (!result.isEmpty()) {
                break;
            }
        }

        System.out.println(result);

        keyMaterials
                .entrySet()
                .stream()
                .sorted((k1, k2) -> k2.getValue().compareTo(k1.getValue()))
                .forEach(pair -> System.out.printf("%s: %.0f%n", pair.getKey(), pair.getValue()));

        junks.entrySet()
                .stream()
                .forEach(pair -> System.out.printf("%s: %.0f%n", pair.getKey(), pair.getValue()));
    }
}
