import java.util.Scanner;

public class Client {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();

        Adder add = new Adder(a, b);
        ScalerThread addThread = new ScalerThread(add);
        addThread.start();
    }
}