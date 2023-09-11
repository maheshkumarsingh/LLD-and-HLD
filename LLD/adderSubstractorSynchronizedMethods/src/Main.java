import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;
// import java.util.concurrent.locks.Lock;
// import java.util.concurrent.locks.ReentrantLock;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) throws Exception{

        //Lock lock = new ReentrantLock();
        Value value = new Value();
        //Adder adder = new Adder(value, lock);
        Adder adder = new Adder(value);
        //Substractor substractor = new Substractor(value, lock);
        Substractor substractor = new Substractor(value);

        ExecutorService executorService = Executors.newCachedThreadPool();

        Future<Void> adderFuture = executorService.submit(adder);
        Future<Void> substrectorFuture = executorService.submit(substractor);

        adderFuture.get();
        substrectorFuture.get();
        System.out.println(value.getValue());
        executorService.shutdown();
    }
}