namespace backpackProblem{
    internal class Program{
        static void Main(string [] args){
            Problem problem = new Problem(10, 1);
            Console.WriteLine(problem.ToString());
            Result result = problem.solve();
            Console.WriteLine("--------\n");
            Console.WriteLine(result.ToString());
        }

    }
}