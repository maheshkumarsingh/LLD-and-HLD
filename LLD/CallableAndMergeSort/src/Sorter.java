import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class Sorter implements Callable<List<Integer>>
{
    private List<Integer> arrayToSort;
    private ExecutorService es;

    public Sorter(List<Integer> arrayToSort, ExecutorService es)
    {
        this.arrayToSort = arrayToSort;
        this.es = es;
    }
    @Override
    public List<Integer> call() throws Exception {
        if(arrayToSort.size() <=1)
            return arrayToSort;
        if (arrayToSort.size() <= 2000) {
            // non multithread
        }
        List<Integer> leftArrayToSort = new ArrayList<>();
        List<Integer> rightArrayToSort = new ArrayList<>();

        int mid = arrayToSort.size()/2;

        for (int i = 0; i < mid; i++) {
            leftArrayToSort.add(arrayToSort.get(i));
        }

        for (int i = mid; i < arrayToSort.size(); i++) {
            rightArrayToSort.add(arrayToSort.get(i));
        }

        /*recursive call function and simple program
        Sorter leftArraySorter = new Sorter(leftArrayToSort);
        List<Integer> leftSortedArray = leftArraySorter.call();

        Sorter rightArraySorter = new Sorter(rightArrayToSort);
        List<Integer> rightSortedArray = rightArraySorter.call(); */

        //multithreaded program

        //ExecutorService es = Executors.newCachedThreadPool();
        //Sorter leftArraySorter = new Sorter(leftArrayToSort);
        Sorter leftArraySorter = new Sorter(leftArrayToSort,es);
        Future<List<Integer>> leftSortedArrayFuture = es.submit(leftArraySorter);

        //Sorter rightArraySorter = new Sorter(rightArrayToSort);
        Sorter rightArraySorter = new Sorter(rightArrayToSort,es);
        Future<List<Integer>> rightSortedArrayFuture = es.submit(rightArraySorter);

        List<Integer> leftSortedArray = leftSortedArrayFuture.get(); ///blocking
        List<Integer> rightSortedArray = rightSortedArrayFuture.get(); //blocking



        int i=0;
        int j=0;

        List<Integer> sortedArray = new ArrayList<>();


        while (i < leftSortedArray.size() && j < rightSortedArray.size()) {
            if (leftSortedArray.get(i) <= rightSortedArray.get(j)) {
                sortedArray.add(leftSortedArray.get(i));
                i++;
            } else {
                sortedArray.add(rightSortedArray.get(j));
                j++;
            }
        }

        while (i < leftSortedArray.size()) {
            sortedArray.add(leftSortedArray.get(i));
            i++;
        }

        while (j < rightSortedArray.size()) {
            sortedArray.add(rightSortedArray.get(j));
            j++;
        }
        return sortedArray;
    }
}
