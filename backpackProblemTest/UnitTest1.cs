using backpackProblem;

namespace backpackProblemTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodCountElements()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach (int n in sizes)
        {
            Problem problem = new Problem(n);
            Assert.AreEqual(n, problem.values.Count);
        }
    }
}