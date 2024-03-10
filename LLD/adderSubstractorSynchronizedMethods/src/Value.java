public class Value {
    private int value;

    //case 2
    // public synchronized int getValue() {
    //     return value;
    // }
    // public synchronized void setValue(int value) {
    //     this.value = value;
    // }

    //case 3
    public int getValue() {
        return value;
    }
    public void setValue(int value) {
        this.value = value;
    }
    
    public synchronized void incrementByValue(int value)
    {
        this.value += value;
    }
}
