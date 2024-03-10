import java.util.concurrent.atomic.AtomicInteger;

public class Value {
    public AtomicInteger value = new AtomicInteger(0);
    //atomic DS will only work when there is CS of ONLY one line
}
