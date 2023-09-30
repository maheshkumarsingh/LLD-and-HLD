import java.util.ArrayList;
import java.util.List;

public class Client {
    public static void main(String[] args) {
        List<Integer> list = List.of(1,2,3,4,5,6,7,8,9,10);
        list.forEach((val)-> System.out.print(val + " "));
        System.out.println("\n");
        printList(list);
        printSquareMap(list);
        printEvenNumbers(list);
        printEvenSquare(list);
    }

    public static void printList(List<Integer> list)
    {
        list.stream().forEach((val)-> System.out.print(val + " "));
        System.out.println("\n");
    }
    public static void printSquareMap(List<Integer> list)
    {
        list.forEach((val)-> System.out.print(val * val + " "));
        System.out.println("\n");

        list.stream().forEach((val)-> System.out.print(val * val + " "));
        System.out.println("\n");

        list.stream().map((val)-> val * val).forEach((val)-> System.out.print(val +" "));
        System.out.println("\n");
    }

    public static void printEvenNumbers(List<Integer> list)
    {
        list.stream().filter((val)-> val % 2 ==0).forEach((val)-> System.out.print(val +" "));
        System.out.println("\n");
    }
    public static void printEvenSquare(List<Integer> list)
    {
        list.stream().filter((val)-> val % 2 == 0).forEach((val)-> System.out.print(val * val + " "));
        System.out.println("\n");
        list.stream().filter((val)-> val % 2==0).map((val)-> val * val).forEach((val)-> System.out.print(val + " "));
        System.out.println("\n");
    }
    // Question 7
    // Given a list of integers, print its sum
    // Special methods called "reducers" that return a single value
    // Example: "reduce" and "collect"
    public static void printSum(List<Integer> list) {
        int sum = list.stream().
                reduce(0,(currentElement, currentSum) -> {
                    return currentElement + currentSum;
                });

        System.out.println(sum);
    }
}
