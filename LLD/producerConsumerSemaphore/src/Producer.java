import java.util.concurrent.Semaphore;

public class Producer implements Runnable{
    private Store store;
    private Semaphore prodSemaphore;
    private Semaphore conSemaphore;
    public Producer(Store store, Semaphore prodSemaphore, Semaphore conSemaphore)
    {
        this.store = store;
        this.prodSemaphore = prodSemaphore;
        this.conSemaphore = conSemaphore;
    }

    private void produceItem()
    {
        //Case 1: busy waiting and race condition in getItems()
        // while(!(store.getItems().size() > 0 ))
        // {
        //     try {
        //         Thread.sleep(10);
        //     } catch (InterruptedException e) {
        //         e.printStackTrace();
        //     }
        // }
        try {
            prodSemaphore.acquire();
        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        try {
            Thread.sleep(20);
        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        store.addItem();
        conSemaphore.release();
    }
    @Override
    public void run() {
        while(true)
        {
            produceItem();
        }
    }
    
}
