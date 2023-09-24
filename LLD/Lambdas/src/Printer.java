public class Printer implements Runnable{

    @Override
    public void run() {
        System.out.println("Name of the thread"+ Thread.currentThread().getName());
    }
    
}
