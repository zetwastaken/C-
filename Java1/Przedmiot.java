package Java1;

public class Przedmiot {
    private int value;
    private int weight;
    private int index;

    public Przedmiot(int value, int weight, int index) {
        this.value = value;
        this.weight = weight;
        this.index = index;
    }

    public int getValue() {
        return value;
    }

    public int getWeight() {
        return weight;
    }
    public int getIndex() {
        return index;
    }

    @Override
    public String toString() {
        return "Przedmiot{" +
                "value=" + value +
                ", weight=" + weight + ", index=" + index +
                '}';
    }
}