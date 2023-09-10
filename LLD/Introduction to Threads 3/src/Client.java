import java.util.Scanner;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class Client {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        //ExecutorService executorService = Executors.newFixedThreadPool(10);
        for (int index = 1; index <= n; index++) {
            TableCreator tableCreator = new TableCreator(index);
            ScalerThread scalerThread = new ScalerThread(tableCreator);
            scalerThread.start();
            //executorService.execute(tableCreator);
        }
    }
}
