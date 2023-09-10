public class App implements Runnable{

    public static void doSomething()
    {
        System.out.println("Hello from doSomething" + Thread.currentThread().getName());
    }
    public static void main(String[] args) throws Exception {
        int a = 10;
        int b = 20;
        System.out.println("Hello, World!"+ a+b + Thread.currentThread().getName());

        doSomething();
    }
    @Override
    public void run()
    {
        System.out.println("Hello from run");
    }
}
