public class Client {
    public static void main(String[] args){
        
        Printer printer = new Printer();
        Thread thread = new Thread(printer);
        thread.start();
        
        //No need of printer class because we know that Runnable is having only one abstract class run
        Thread threadLambdas = new Thread(()-> System.out.println("Thread from lambdas" + Thread.currentThread().getName()));
        threadLambdas.start();

        // Add add = new Add();
        // System.out.println(add.operate(5, 5));

        IMathOperation add1 = (a,b) -> a+b;
        IMathOperation add2 = Integer::sum;
        System.out.println(add1.operate(5, 5));
        System.out.println(add2.operate(5, 5));

        IMathOperation add3 = (a,b) -> a+b;
        IMathOperation sub = (a,b) -> a-b;
        System.out.println("doOperation " + doOperation(5, 5, add3));
        System.out.println("doOperation " + doOperation(7, 5, sub));
    }

    public static int doOperation(int a, int b, IMathOperation mathOperation)
    {
        System.out.println("Operation1");
        System.out.println("Operation2");
        return mathOperation.operate(a, b);
    }
}
