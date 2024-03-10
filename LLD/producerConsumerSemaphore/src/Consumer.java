import java.util.concurrent.Semaphore;

public class Consumer implements Runnable{
    private Store store;
    private Semaphore prodSemaphore;
    private Semaphore conSemaphore;
    int consumerID;
    public Consumer(Store store, Semaphore prodSemaphore, Semaphore conSemaphore, int consumerID)
    {
        this.store = store;
        this.prodSemaphore = prodSemaphore;
        this.conSemaphore = conSemaphore;
        this.consumerID = consumerID;
    }

    private void consumeItem()
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
            conSemaphore.acquire();
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
        store.removeItem(consumerID);
        prodSemaphore.release();
    }
    @Override
    public void run() {
        while(true)
        {
            consumeItem();
        }
    }

}   
