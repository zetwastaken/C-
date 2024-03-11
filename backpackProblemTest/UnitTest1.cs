using System.Diagnostics;
using backpackProblem;

namespace backpackProblemTest;


[TestClass]
public class UnitTest
{
    [TestMethod]
    public void TestMethodCountElements()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach (int n in sizes)
        {
            Problem problem = new Problem(n, 11, 10); // Provide the 'seed' argument
            Assert.AreEqual(n, problem.items.Count);
        }
    }
    [TestMethod]
    public void TestMethodMaxCapacity()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach (int n in sizes)
        {
            Problem problem = new Problem(n, 11, 10); // Provide the 'seed' argument
            Assert.AreEqual(10, problem.maxCapacity);
        }
    }
    [TestMethod]
    public void TestMethodTotalWeight()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach (int n in sizes)
        {
            Problem problem = new Problem(n, 11, 10); // Provide the 'seed' argument
            int totalWeight = 0;
            foreach (Item item in problem.items)
            {
                totalWeight += item.weight;
            }
            Assert.AreEqual(totalWeight, problem.items.Sum(x => x.weight));
        }
    }
    [TestMethod]
    public void TestMethodTotalValue()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach (int n in sizes)
        {
            Problem problem = new Problem(n, 11, 10); // Provide the 'seed' argument
            int totalValue = 0;
            foreach (Item item in problem.items)
            {
                totalValue += item.value;
            }
            Assert.AreEqual(totalValue, problem.items.Sum(x => x.value));
        }
    }
    [TestMethod]
    public void TestIfOneElementPasses(){
        Problem problem = new Problem(2, 11, 10); // Provide the 'seed' argument
        List<Item> items = new List<Item>(){new Item(1, 1), new Item(20,20)};
        problem.items = items;
        Result result = problem.solve();
        Console.WriteLine(result.ToString());
        Assert.AreEqual(1, result.result.Count);
    }
    [TestMethod]
    public void TestIfEmptyWhenFail(){
            Random rand = new Random(10);
            int n = rand.Next(1, 10);
            List<Item> items = new List<Item>();
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rand.Next(6, 10), rand.Next(6, 10)));
            }
        Problem problem = new Problem(n, 10, 5); // Provide the 'seed' argument
        problem.items = items;
        Result result = problem.solve();
        Assert.AreEqual(0, result.result.Count);
    }
    [TestMethod]
    public void TestMethodOrderOfItems()
    {
        Problem problem = new Problem(3, 11, 4); // Provide the 'seed' argument

        // Create two sets of items with the same total weight and value, but different order
        List<Item> items1 = new List<Item>(){ new Item(1, 1), new Item(2, 2), new Item(3, 3) };
        List<Item> items2 = new List<Item>(){ new Item(3, 3), new Item(2, 2), new Item(1, 1) };

        problem.items = items1;
        Trace.WriteLine(problem.ToString());


        Result result1 = problem.solve();
        Trace.WriteLine(result1.ToString());

        problem.items = items2;
        Result result2 = problem.solve();
        Trace.WriteLine(result2.ToString());

        // Assert that the results are the same
        Assert.IsTrue(result1.result.ToString() == result2.result.ToString());
    }
    [TestMethod]
    public void TestOneInstance()
    {
        Problem problem = new Problem(3, 11, 4); // Provide the 'seed' argument
        List<Item> items1 = new List<Item>(){ new Item(1, 1), new Item(2, 2), new Item(3, 3) };
        problem.items = items1;
        Result result = problem.solve();
        Assert.AreEqual(4, result.total_value);
    }

}

