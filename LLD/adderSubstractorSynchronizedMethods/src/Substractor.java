import java.util.concurrent.Callable;

public class Substractor implements Callable<Void> {

    private Value value;
    //private Lock lock;

    public Substractor(Value value)
    {
        this.value = value;
        //this.lock = lock;
    }
    @Override
    public Void call() throws Exception {
        for (int i = 1; i <=100; i++) {
            System.out.println("Requesting lock for Subtraction" +i);
            //lock.lock();
            //case synchronized
            // synchronized (value)
            // {
            //     value.value -= i;
            // }
            //synchronized method
            //int currentValue = value.getValue();
            //value.setValue(currentValue - i);  //lock must be in both while getting and setting together.

            //case synchronized in both getter and setter
            value.incrementByValue(-i);
            System.out.println("Subtracted "+ i);
            //lock.unlock();
        }
        return null;
    }
}
