package Java1;

import java.util.List;

public class Result {
    private List<Integer> itemIndices;
    private List<Integer> itemCounts;
    private int totalValue;
    private int totalWeight;

    public Result(List<Integer> itemIndices, List<Integer> itemCounts, int totalValue, int totalWeight) {
        this.itemIndices = itemIndices;
        this.itemCounts = itemCounts;
        this.totalValue = totalValue;
        this.totalWeight = totalWeight;
    }


    public List<Integer> getItemIndices() {
        return itemIndices;
    }

    public List<Integer> getItemCounts() {
        return itemCounts;
    }

    public int getTotalValue() {
        return totalValue;
    }

    public int getTotalWeight() {
        return totalWeight;
    }

    @Override
    public String toString() {
        return "Result{" +
                "itemIndices=" + itemIndices +
                ", itemCounts=" + itemCounts +
                ", totalValue=" + totalValue +
                ", totalWeight=" + totalWeight +
                "}\n";
    }
}
