import java.util.ArrayList;
import java.util.List;
import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedDeque;

public class Store {
    private Queue<Object> items;

    public Store()
    {
        //items = new ArrayList<>();
        items = new ConcurrentLinkedDeque();
    }
    public void addItem(int producerID)
    {
        items.add(new Object());
        System.out.println("Item added.   size is " + items.size()+" By id: "+ producerID);
    }
    public void removeItem(int consumerID)
    {
        items.remove();

        System.out.println("Item removed. size is " + items.size() + " By id: " + consumerID);
    }

    public Queue<Object> getItems()
    {
        return items;
    }
}
