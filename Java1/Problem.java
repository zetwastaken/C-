package Java1;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Random;

public class Problem {
    private int n;
    private int seed;
    private int lowerBound;
    private int upperBound;
    List<Przedmiot> items;

    public Problem(int n, int seed, int lowerBound, int upperBound) {
        this.n = n;
        this.seed = seed;
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.items = new ArrayList<>();

        Random random = new Random(seed);
        for (int i = 0; i < n; i++) {
            int value = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            int weight = random.nextInt(upperBound - lowerBound + 1) + lowerBound;
            items.add(new Przedmiot(value, weight, i));
        }
    }

    public Result solve(int capacity) {
        items.sort(Comparator.comparingDouble(item -> -((double) item.getValue() / item.getWeight())));

        List<Integer> itemIndices = new ArrayList<>();
        List<Integer> itemCounts = new ArrayList<>();
        int totalValue = 0;
        int totalWeight = 0;

        for (int i = 0; i < items.size() && capacity > 0; i++) {
            Przedmiot item = items.get(i);
            int maxCount = capacity / item.getWeight();
            if (maxCount > 0) {
                itemIndices.add(item.getIndex());
                itemCounts.add(maxCount);
                totalValue += maxCount * item.getValue();
                totalWeight += maxCount * item.getWeight();
                capacity -= maxCount * item.getWeight();
            }
        }

        return new Result(itemIndices, itemCounts, totalValue, totalWeight);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Problem{");
        sb.append("n=").append(n);
        sb.append(", seed=").append(seed);
        sb.append(", lowerBound=").append(lowerBound);
        sb.append(", upperBound=").append(upperBound);
        sb.append(", items=\n");
        for (Przedmiot item : items) {
            sb.append(item).append("\n");
        }
        sb.append('}');
        return sb.toString();
    }

    public static void main(String[] args) {
        Problem problem = new Problem(10, 12345, 1, 10);
        System.out.println(problem);

        Result result = problem.solve(50);
        System.out.println(result);
    }
}