import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
import java.util.concurrent.locks.ReentrantLock;
import java.util.concurrent.locks.Lock;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) throws Exception{
        Lock lock = new ReentrantLock();
        Value value = new Value();
        Adder adder = new Adder(value, lock);
        Substractor substractor = new Substractor(value, lock);

        ExecutorService executorService = Executors.newCachedThreadPool();

        Future<Void> adderFuture = executorService.submit(adder);
        Future<Void> substrectorFuture = executorService.submit(substractor);

        adderFuture.get();
        substrectorFuture.get();
        executorService.shutdown();
        System.out.println(value.value);
    }
}