public class Adder implements Runnable{
    private int a,b;
    
    public Adder(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    @Override
    public void run() {
        System.out.println(this.a + this.b);
    }
    
}
