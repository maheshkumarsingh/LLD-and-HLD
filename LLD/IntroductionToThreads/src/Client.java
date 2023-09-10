public class Client {
    public static void main(String[] args) throws Exception {
        System.out.println("I am the main class");
        Adder add = new Adder();
        Substractor sub = new Substractor();
        ScalerThread adder = new ScalerThread(add);
        ScalerThread substractor = new ScalerThread(sub);
        adder.start();
        substractor.start();
    }
}
