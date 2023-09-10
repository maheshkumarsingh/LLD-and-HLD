public class Client {
    public static void main(String[] args) {
        // P obj = new P();
        // System.out.println(obj.d1);
        // System.out.println(obj.d);
        // obj.fun1();
        // obj.fun();
        // obj.sfun();

        // P obj = new C();
        // System.out.println(obj.d1);
        // System.out.println(obj.d);
        // obj.fun1();
        // obj.fun();
        // obj.sfun();

        // C obj = new P();
        // System.out.println(obj.d1);
        // System.out.println(obj.d);
        // obj.fun1();
        // obj.fun();
        // obj.sfun();

        C obj = new C();
        System.out.println(obj.d1); //10
        System.out.println(obj.d); //200
        obj.fun1(); //P's fun1
        obj.fun(); //C's fun
        obj.sfun(); //C's sfun
    }
}
