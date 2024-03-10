package LLD.Lambdas.src;

import java.util.function.Function;

public class Client {
    public static void main(String[] args){
        /*Lecture 1 in Lambdas
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
         */

        //Lecture 2 Case 1
        //decider("upper","mahesh");
        //Case 2 we don't want to print values using this way instead of this we want that main should receive some functions
        decider("upper").apply("testing");

    }

    public static int doOperation(int a, int b, IMathOperation mathOperation)
    {
        System.out.println("Operation1");
        System.out.println("Operation2");
        return mathOperation.operate(a, b);
    }

    public static Function<String, String> decider(String value)
    {
        if(value.equals("upper"))
        {
            //printUpper(text);
            //return (val)-> printUpper(val);
            return Client::printUpper;  //Method reference
        }
        else if(value.equals("lower"))
        {
            //printLower(text);
            //return (val)->printLower(val);
            return Client::printLower;
        }
        else
        {
            //print(text);
            //return (val)->print(val);
            return Client::print;
        }
    }
    public static String printUpper(String text)
    {
        System.out.println(text.toUpperCase());
        return "from Upper";
    }

    public static String printLower(String text)
    {
        System.out.println(text.toLowerCase());
        return "from Lower";
    }

    public static String print(String text)
    {
        System.out.println(text);
        return "from Print";
    }
}
