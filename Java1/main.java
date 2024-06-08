package Java1;

public class main {
    public static void main(String[] args) {
        Problem problem = new Problem(10, 12345, 1, 10);
        System.out.println(problem);

        Result result = problem.solve(50);
        System.out.println(result);
    }
}