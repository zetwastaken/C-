package Java1;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

import java.util.List;

public class ProblemTest {

    private Problem problem;

    @BeforeEach
    public void setUp() {
        problem = new Problem(10, 12345, 1, 10);
    }

    @Test
    public void testAtLeastOneItemMeetsConstraints() {
        int capacity = 10;
        Result result = problem.solve(capacity);

        boolean atLeastOneItemFits = result.getItemIndices().size() > 0;
        assertTrue(atLeastOneItemFits, "There should be at least one item in the solution if at least one item meets the constraints.");
    }

    @Test
    public void testNoItemMeetsConstraints() {
        Problem problemWithLargeWeights = new Problem(10, 12345, 100, 200);
        int capacity = 50;
        Result result = problemWithLargeWeights.solve(capacity);

        assertEquals(0, result.getItemIndices().size(), "There should be no items in the solution if no item meets the constraints.");
    }

    @Test
    public void testItemsWithinSpecifiedRange() {
        for (Przedmiot item : problem.items) {
            assertTrue(item.getWeight() >= 1 && item.getWeight() <= 10, "Item weight should be within the specified range.");
            assertTrue(item.getValue() >= 1 && item.getValue() <= 10, "Item value should be within the specified range.");
        }
    }

    @Test
    public void testCorrectnessOfResultForSpecificInstance() {
        Problem specificProblem = new Problem(5, 12345, 1, 10);
        Result result = specificProblem.solve(20);

        List<Integer> itemIndices = result.getItemIndices();
        List<Integer> itemCounts = result.getItemCounts();
        int calculatedTotalWeight = 0;
        int calculatedTotalValue = 0;

        for (int i = 0; i < itemIndices.size(); i++) {
            Przedmiot item = specificProblem.items.get(itemIndices.get(i));
            int count = itemCounts.get(i);
            calculatedTotalWeight += item.getWeight() * count;
            calculatedTotalValue += item.getValue() * count;
        }

        assertEquals(result.getTotalWeight(), calculatedTotalWeight, "The total weight should match the calculated total weight.");
        assertEquals(result.getTotalValue(), calculatedTotalValue, "The total value should match the calculated total value.");
    }
}