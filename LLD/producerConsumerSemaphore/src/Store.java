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
    public void addItem()
    {
        items.add(new Object());
        System.out.println("Item added. size is" + items.size());
    }
    public void removeItem()
    {
        items.remove();

        System.out.println("Item removed. size is" + items.size());
    }

    public Queue<Object> getItems()
    {
        return items;
    }
}
