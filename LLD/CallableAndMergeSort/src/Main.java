import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Main {
    public static void main(String[] args) throws Exception {
        List<Integer> arrayToSort = List.of(8,2,4,1,9,6,0,7);
        /* Creating global 1 executor object */
//        ExecutorService es = Executors.newCachedThreadPool();

        ExecutorService es = Executors.newFixedThreadPool(10);
        //Sorter sorter = new Sorter(arrayToSort);
        Sorter sorter = new Sorter(arrayToSort,es);

        List<Integer> sortedArray = sorter.call();

        for (Integer in : sortedArray) {
            System.out.println(in);
        }
        //task is done please stop now
        es.shutdown();
    }
}