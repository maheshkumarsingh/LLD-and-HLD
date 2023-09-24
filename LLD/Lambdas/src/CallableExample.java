import java.util.concurrent.Callable;

public class CallableExample {
    public static void main(String[] args) throws Exception {
        
        Callable<String> callable = ()->{
            System.out.println("Calling from callable");
            return "done";
        };

        Callable<String> callable1 = ()-> returnStatus();
        callable1.call();

        Callable<String> callable2 = CallableExample::returnStatus;
        callable2.call();
    }
    
    public static String returnStatus(){
        System.out.println("Calling from callable");
        return "done";
    }
}
