import java.util.concurrent.Callable;

public class Adder implements Callable<Void>{
    private Value value;
    //private Lock lock;

    public Adder(Value value)
    {
        this.value = value;
        //this.lock = lock;
    }

    @Override

    public Void call() throws Exception //synchronized
    {
        for (int i = 1; i <= 100; i++) {
            System.out.println("Requesting lock for adding" + i);
            //lock.lock();
            //case synchronized
            // synchronized (value)
            // {
            //     value.value += i;
            // }
            
            //case synchronized method
            //int currentValue = value.getValue(); //lock is for only getvalue. between get and set value someone else took the lock. thats why we are getting another values.
            //value.setValue(currentValue + i);

            //case synchronized in both get and set
            value.incrementByValue(i);
            System.out.println("Added "+i);
            
            //lock.unlock();
        }
        return null;
    }
}
