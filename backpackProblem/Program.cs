namespace backpackProblem{
    internal class Program{
        static void Main(string [] args){
         Problem problem = new Problem(3, 1,4);
        List<Item> items1 = new List<Item>(){ new Item(1, 1), new Item(2, 2), new Item(3, 3) };
        List<Item> items2 = new List<Item>(){ new Item(3, 3), new Item(2, 2), new Item(1, 1) };

            problem.items = items1;
            {
            Console.WriteLine(problem.ToString());
            Result result = problem.solve();
            Console.WriteLine("--------\n");
            Console.WriteLine(result.ToString());
            }
            problem.items = items2;
            Console.WriteLine("\n----------------\n----------------\n");
            {
            Console.WriteLine(problem.ToString());
            Result result = problem.solve();
            Console.WriteLine("--------\n");
            Console.WriteLine(result.ToString());
            }
        }

    }
}