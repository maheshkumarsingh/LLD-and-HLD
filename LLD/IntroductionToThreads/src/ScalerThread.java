import java.util.HashMap;

public class ScalerThread extends Thread {
    private static HashMap<String, String> map = new HashMap<>();
    private static String threadName;
    
    ScalerThread(Runnable runnable)
    {
        super(runnable);
        threadName = runnable.getClass().getName();
    }

    @Override
    public void start(){
        super.start();
        map.put(threadName, this.getName());
    }
}
