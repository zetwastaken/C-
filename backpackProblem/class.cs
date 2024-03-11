using System.Collections.Generic;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("backpackProblemTest")]

namespace backpackProblem{

class Item{
    public int weight;
    public int value;

    public double ratio;
    public Item(int weight, int value){
        this.weight = weight;
        this.value = value;
        this.ratio = (double)value / (double)weight;
    }
}

class Result{
    public int total_value;
    public int total_weight;
    public List<Item> result;
    public Result(List<Item> items){
        this.result = items;
        this.total_weight = 0;
        foreach (Item item in items){
            this.total_weight += item.weight;
            this.total_value += item.value;
        }
    }
    public override string ToString(){
        string results = "";
        results += "Total weight: " + total_weight + " Total value: " + total_value + "\n";
        foreach (Item item in result){
            results += "Weight: " + item.weight + " Value: " + item.value + "\n";
        }
        return results;
    }
}



class Problem{
 int n;
 public int maxCapacity;
 int seed;
 public List<Item> items;
 
        public Problem(int n, int seed, int maxCapacity=10)
        {
            this.n = n;
            this.seed = seed;
            this.maxCapacity = maxCapacity;
            items = new List<Item>();
            Random rand = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rand.Next(1, 10), rand.Next(1, 10)));
            }
            items.Sort((x, y) => y.ratio.CompareTo(x.ratio));
}


public Result solve(){
    Result resultTemp;
    // items.Sort((x, y) => y.ratio.CompareTo(x.ratio));
    items.Sort((x, y) =>
    {
        int ratioComparison = y.ratio.CompareTo(x.ratio);
        if (ratioComparison == 0)
        {
            return y.value.CompareTo(x.value);
        }
        return ratioComparison;
    });
    resultTemp = new Result(new List<Item>());
    int weight = 0;
    foreach (Item item in items){
        if (weight + item.weight <= maxCapacity){
            weight += item.weight;
            resultTemp.result.Add(item);
        }
    }
    Result result = new Result(resultTemp.result);

    return result;
}
    public override string ToString(){
    string result = "";
    foreach (Item item in items){
        result += "Weight: " + item.weight + " Value: " + item.value + "\n";
    }
        return result;  
    }


}

}
